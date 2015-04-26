namespace CoffeeApp_Droid

open System
open Android.App
open Android.Content
open Android.OS
open Android.Runtime
open Android.Views
open Android.Widget

open CoffeeApp.Core

[<Activity(Label = "CoffeeApp")>]
type MainActivity() = 
    inherit Activity()
    override this.OnCreate(bundle) = 
        base.OnCreate(bundle)
        // Set our view from the "main" layout resource
        this.SetContentView(Resource_Layout.Main)
        let listView = this.FindViewById<ListView>(Resource_Id.drinkItemListView)
        let service = new DataService()
        let items = service.DrinkItems
        listView.Adapter <- new DrinkItemAdapter(this, items)
        let resetButton = this.FindViewById<Button>(Resource_Id.resetButton)
        resetButton.Click.Add(fun arg ->
            service.Reset()
            listView.Adapter <- new DrinkItemAdapter(this, items)
        )
