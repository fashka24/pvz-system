#nowarn "0064"
namespace Lut1e

module PVZ =
    open System

    type entity_t = Plant | Zombie | Non

    let get_anyway (ebj_: int) = ebj_
    let findInList (list_: 'T list, fn_: 'A -> bool) =
        let mutable _ewew = 0
        let mutable result_ = 0
        let mutable needs_block_found = false
        
        while _ewew < list_.Length do
            if fn_ list_[_ewew] then
                result_ <- _ewew
                needs_block_found <- true
            _ewew <- _ewew + 1
        if needs_block_found then result_
        else -1
    let getWinRate (row_size: int, sections: entity_t list, debuf_use: bool) =
        if debuf_use then printfn "start getting win rate\t[2]"
        let mutable win_rate = 0
        let mutable fisrt_z = findInList (sections, (fun (e: entity_t) -> e = entity_t.Zombie))
        (*
            P P P N N N *Z N Z
        *)
        if debuf_use then printfn $"first zombie gets (%d{fisrt_z})\t[3..]"
        let mutable indX = fisrt_z
        let mutable last_p = 0

        while indX > 0 do
            if sections[indX] = entity_t.Plant then
                last_p <- indX
                indX <- 0
            else indX <- indX - 1
        if debuf_use then printfn $"last plant gets (%d{last_p})\t[3..]"
        win_rate <- fisrt_z - last_p

        win_rate