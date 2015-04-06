namespace CoffeeApp.Core

open System

type DrinkItem (name:string) =
    let mutable count = 0
    member this.Name = name
    member this.Count = count
    member this.Increase() =
        match count with
        | Int32.MaxValue -> ()
        | _ -> count <- count + 1
    member this.Decrease() =
        match count with
        | 0 -> ()
        | _ -> count <- count - 1

