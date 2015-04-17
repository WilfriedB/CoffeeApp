namespace CoffeeApp.Core

open System.Collections.Generic
open System.Linq

type DataService() = 
    let items = new List<DrinkItem>([new DrinkItem("Koffie zwart")
                                     new DrinkItem("Koffie melk")
                                     new DrinkItem("Heet water")
                                     new DrinkItem("Koud water")
                                     new DrinkItem("Thee")]
                                   )
    member this.DrinkItems =
        items
    member this.Reset() =
        for item in items do
            item.Reset()