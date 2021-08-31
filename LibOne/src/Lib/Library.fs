namespace Lib.LibOne

open System
open System.Threading.Tasks
open System.Reactive.Concurrency
open System.Reactive.Subjects
open System.Reactive.Linq
open System.Reactive.Threading.Tasks
open FSharp.Control.Reactive

module Publisher =
    let single<'a> (item: 'a) : IObservable<'a> =
        (Observable.single item)
            .SubscribeOn(ThreadPoolScheduler.Instance)

    let io<'a> (f: (unit -> 'a)) : IObservable<'a> =
        (Observable.single (f ()))
            .SubscribeOn(NewThreadScheduler.Default)

    let ofSeq<'a> (items: 'a seq) : IObservable<'a> = Observable.toObservable items //Observable.ofSeq items

    let async<'a> (task: Async<'a>) : IObservable<'a> = Observable.ofAsync (task)

    let task<'a> (task: Task<'a>) : IObservable<'a> = Observable.FromAsync(fun () -> task)

    let toAsync<'a> (observable: IObservable<'a>) : Async<'a list> =
        observable
        |> Observable.toList
        |> Observable.map List.ofSeq
        |> TaskObservableExtensions.ToTask
        |> Async.AwaitTask

module Say =
    let hello name = printfn "Hello %s" name
