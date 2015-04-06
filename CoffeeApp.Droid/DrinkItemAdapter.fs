namespace CoffeeApp_Droid
open System
open System.Collections.Generic

open Android.App
open Android.Content
open Android.OS
open Android.Runtime
open Android.Views
open Android.Widget

open CoffeeApp.Core

type DrinkItemAdapter(context:Activity, items: IList<DrinkItem>) = 
    inherit BaseAdapter<DrinkItem>()
    override this.Item
        with get(position) = items.[position]
    override this.Count
        with get() = items.Count
    override this.GetItemId(position) = int64 position
    override this.GetView(position, view, parent) =
        let view =
            match view with
            | null -> context.LayoutInflater.Inflate(Resource_Layout.DrinkRowView, null)
            | x -> x
        let drinkItem = items.[position]
        let countText = view.FindViewById<TextView>(Resource_Id.textViewProductCount)
        view.FindViewById<TextView>(Resource_Id.textViewProductName).Text <- drinkItem.Name
        countText.Text <- drinkItem.Count.ToString()
        view.FindViewById<Button>(Resource_Id.buttonPlus).Click.Add(fun e -> 
            drinkItem.Increase()
            countText.Text <- drinkItem.Count.ToString() )
        view.FindViewById<Button>(Resource_Id.buttonMin).Click.Add(fun e -> 
            drinkItem.Decrease()
            countText.Text <- drinkItem.Count.ToString() )
        view
