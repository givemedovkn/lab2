//Список содержит строки. Сколько из них имеет чётную длину?
open System

//Функция проверки натуральных чисел
let checkNum num : int =
    if num <= 0 
    then 0
    else 1

//Функция запроса строки
let createList i : string =
    printf "Введите строку: "
    let str =  Console.ReadLine()
    str

[<EntryPoint>]
let main _ =
    printf "Введите количество строк: "
    let n = int(Console.ReadLine())
    //проверка натурального числа
    if (checkNum n) = 0 
    then printfn "Некорректное число!"
    else
        //список строк
        let listLen = [for i in 1..n -> createList i]
        //подсчет четных длин строк
       let evenNum = List.fold (fun summ (str:string) -> 
            if str.Length % 2 = 0 then 
                summ+1 
            else summ ) 0 listLen
        printfn "Список строк: "
        printfn "%A " listLen
        printfn "Из них строк с четной длиной: %i" evenNum

    0
