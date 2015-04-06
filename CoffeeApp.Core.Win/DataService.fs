namespace CoffeeApp.Core

open System.Collections.Generic

type DataService() = 
    let items = new List<DrinkItem>()
    member this.DrinkItems =
        items.Add(new DrinkItem("Koffie zwart"))
        items.Add(new DrinkItem("Koffie melk"))
        items.Add(new DrinkItem("Heet water"))
        items.Add(new DrinkItem("Koud water"))
        items.Add(new DrinkItem("Thee"))
        items
