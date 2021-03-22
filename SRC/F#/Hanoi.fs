open System

(*
    F# Hanoi.fs
*)

let rec hanoi n from to_ via =
    if n > 1 then
        hanoi (n - 1) from via to_
        printf "%c -> %c\n" from to_
        hanoi (n - 1) via to_ from

    else 

        printf "%c -> %c\n" from to_


//표준 입력에서 명령를 받아서 실행
let n = Console.ReadLine() in
hanoi (int n) 'a' 'b' 'c'
