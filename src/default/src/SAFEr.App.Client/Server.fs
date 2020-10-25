﻿module SAFEr.App.Client.Server

open Fable.Remoting.Client
open SAFEr.App.Shared.Communication

let service =
    Remoting.createApi()
    |> Remoting.withRouteBuilder Service.RouteBuilder
    |> Remoting.buildProxy<Service>