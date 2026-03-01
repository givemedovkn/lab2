//11. На основе списка вещественных чисел получить список целых чисел, отбросив дробную часть.
open System

//Функция проверки натуральных чисел
let checkNum num : int =
    if num <= 0 
    then 0
    else 1

//Функция запроса числа у пользователя
let createFloatNum i : float =
    printf "Введите вещественное число: "
    let num =  float(Console.ReadLine())
    num

[<EntryPoint>]
let main _ =
    printf "Введите количество чисел: "
    let n = int(Console.ReadLine())
    //проверка натурального числа
    if (checkNum n) = 0 
    then printfn "Некорректное число!"
    else
        //список вещественных чисел
        let FloatNum = [for i in 1..n -> createFloatNum i]
        //список целых чисел
        let IntNum = List.map (fun floatNumber -> int floatNumber) FloatNum
        printfn "Список вещественных чисел: "
        printfn "%A " FloatNum
        printfn "Список натуральных чисел: "
        printfn "%A " IntNum
    0
