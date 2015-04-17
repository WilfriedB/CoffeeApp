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
        let drinkItem = items.[position]
        let resultView =
            match view with
            | null -> library.initView( context.LayoutInflater.Inflate(Resource_Layout.DrinkRowView, null), drinkItem)
            | x -> x
        resultView
