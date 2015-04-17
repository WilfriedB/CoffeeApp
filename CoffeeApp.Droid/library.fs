namespace CoffeeApp_Droid

open System
open System.Collections.Generic
open System.Linq
open System.Text
open Android.App
open Android.Content
open Android.OS
open Android.Runtime
open Android.Views
open Android.Widget
open CoffeeApp.Core

module library =
    let initView (view:View, drinkItem:DrinkItem) =
        let countText = view.FindViewById<TextView>(Resource_Id.textViewProductCount)
        countText.Text <- drinkItem.Count.ToString()
        view.FindViewById<TextView>(Resource_Id.textViewProductName).Text <- drinkItem.Name
        view.FindViewById<Button>(Resource_Id.buttonPlus).Click.Add(fun _ -> 
            drinkItem.Increase()
            countText.Text <- drinkItem.Count.ToString() 
        )
        view.FindViewById<Button>(Resource_Id.buttonMin).Click.Add(fun _ -> 
            drinkItem.Decrease()
            countText.Text <- drinkItem.Count.ToString()
        )
        view
