// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open LibOne

// Define a function to construct a message to print
let from whom = sprintf "from %s" whom

[<EntryPoint>]
let main argv =

    let pub = Publisher.single 10

    let _ =
        pub
        |> Observable.subscribe (fun item -> printfn "Item: %i" item)

    Say.hello "Name"

    let message = from "F#" // Call the function
    printfn "Hello world %s" message
    0 // return an integer exit code
