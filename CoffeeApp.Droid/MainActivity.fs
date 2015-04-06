namespace CoffeeApp_Droid

open System
open Android.App
open Android.Content
open Android.OS
open Android.Runtime
open Android.Views
open Android.Widget

open CoffeeApp.Core

[<Activity(Label = "CoffeeApp", MainLauncher = true)>]
type MainActivity() = 
    inherit Activity()
    [<DefaultValue>]
    val mutable listView : ListView
    let mutable count : int = 1
    let mutable coffeeBlackCount : int = 0
    override this.OnCreate(bundle) = 
        base.OnCreate(bundle)
        // Set our view from the "main" layout resource
        this.SetContentView(Resource_Layout.Main)
        this.listView <- this.FindViewById<ListView>(Resource_Id.drinkItemListView)
        let a = new DataService()
        let items = a.DrinkItems
        this.listView.Adapter <- new DrinkItemAdapter(this, items)
