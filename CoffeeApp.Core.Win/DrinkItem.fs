namespace CoffeeApp.Core

open System
open System.ComponentModel

type DrinkItem (name:string) =
    let mutable count = 0
    let event = Event<PropertyChangedEventHandler,PropertyChangedEventArgs>()
    interface INotifyPropertyChanged with
        [<CLIEvent>]
        member this.PropertyChanged = event.Publish
    member this.Name = name
    member this.Count = count
    member this.Increase() =
        match count with
        | Int32.MaxValue -> ()
        | _ -> count <- count + 1
        event.Trigger(this, new PropertyChangedEventArgs("Count"))
    member this.Decrease() =
        match count with
        | 0 -> ()
        | _ -> count <- count - 1
        event.Trigger(this, new PropertyChangedEventArgs("Count"))
    member this.Reset() =
        count <- 0
        event.Trigger(this, new PropertyChangedEventArgs("Count"))
 