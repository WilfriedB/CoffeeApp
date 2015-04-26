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

[<Activity(Theme="@style/Theme.Splash", MainLauncher=true, NoHistory=true, Label = "SplashActivity")>]
type SplashActivity() = 
    inherit Activity()
    override x.OnCreate(bundle) = 
        base.OnCreate(bundle)
        x.StartActivity( typeof<MainActivity>)
