open System
#load "src/system.fsx"
open Lut1e
open Lut1e.PVZ

let main (args) =
    printfn "Start eval \t\t[1]"

    let sections = [
        (* Non - void *)
        Plant; Plant; Plant; Non; Non; Plant; Zombie; Non; Zombie
    ]

    let my_win_rate =
        PVZ.getWinRate (
            9 (* row length *), sections, false (* enable debug *)
        ) * 10 (* resize to more readable digit *)

    printfn "End eval \t\t[1]\n"
    printfn $"Result win-rate: %d{my_win_rate}%c{'%'} / 3%c{'%'}"
    0

main fsi.CommandLineArgs