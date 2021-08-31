open System
open Lib.LibOne

let from whom = sprintf "from %s" whom

[<EntryPoint>]
let main args =

    let pub = Publisher.io (fun _ -> 10)

    pub
    |> Observable.subscribe (fun item -> printfn $"Item: {item}")
    |> ignore

    let asyncPub = Publisher.toAsync pub

    let result = Async.RunSynchronously asyncPub

    printfn $"Result {result}"
    0
