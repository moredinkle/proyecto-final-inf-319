open System
open System.Collections

 
[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    

    //fibonacci
    printfn "-----Fibonacci-----"
    printf "n: "
    let n = System.Int32.Parse(Console.ReadLine())
    let mutable a = 0
    let mutable b = 1
    let mutable aux = 0
    printf "0, "
    for i in 2..n do
        aux <- a
        a <- b
        b <- aux + a
        printf "%i, " a


    //calculadora
    printfn "\n-----Calculadora-----"
    let suma a b =  a + b
    let resta a b = a - b
    let multi a b = a * b
    let divi a b = a / b

    let calcu a b op = op a b 


    printf "a:"
    let a = System.Int32.Parse(Console.ReadLine())
    printf "b:"
    let b = System.Int32.Parse(Console.ReadLine())
    printf "operacion(suma, resta, multi o divi):"
    let op = Console.ReadLine()

    if op = "suma" then 
        let res = calcu a b suma
        printfn "Resultado:%i " res
    else if op = "resta" then 
        let res = calcu a b resta
        printfn "Resultado:%i " res
    else if op = "multi" then 
        let res = calcu a b multi
        printfn "Resultado: %i " res
    else if op = "divi" then 
        let res = calcu a b divi
        printfn "Resultado:%i " res
    else do printf"\nOperacion no reconocida"


    //matrices
    printfn "\n-----Calculadora de matrices-----"
    let sumat (a:int[,]) (b:int[,]) (c:int[,]) =
        for i = 0 to 1 do  
            for j = 0 to 1 do c.[i,j] <- a.[i,j] + b.[i,j]
    
    let resmat (a:int[,]) (b:int[,]) (c:int[,]) =
        for i = 0 to 1 do  
            for j = 0 to 1 do c.[i,j] <- a.[i,j] - b.[i,j]

    let mulmat (a:int[,]) (b:int[,]) (c:int[,]) =
        for i = 0 to 1 do  
            for j = 0 to 1 do
                c.[i,j] <- 0
                for k = 0 to 1 do c.[i,j] <- c.[i,j] + a.[i,k] * b.[k,j]


    let matrices a b c op = op a b c

    let mat1 = array2D [ [ 0; 0]; [0; 0] ]  
    let mat2 = array2D [ [ 0; 0]; [0; 0] ]  
    let c = array2D [ [ 0; 0]; [0; 0] ]  

    let a () = 
        printf "numero:"
        System.Int32.Parse(Console.ReadLine())

    printfn "Matriz 1"
    for i = 0 to 1 do  
        for j = 0 to 1 do  
            mat1.[i,j] <- a ()
    
    printfn "\nMatriz 2\n"
    for i = 0 to 1 do  
        for j = 0 to 1 do  
            mat2.[i,j] <- a ()

    printf "operacion(suma, resta o multi):"
    let op = Console.ReadLine()

    if op = "suma" then 
        matrices mat1 mat2 c sumat
    else if op = "resta" then 
        matrices mat1 mat2 c resmat
    else if op = "multi" then 
        matrices mat1 mat2 c mulmat
    else do printf"\nOperacion no reconocida"
    
    printfn "Resultado:\n%A " c


    //separar lista
    printfn "\n-----separar lista-----"
    printf "n:"
    let n = System.Int32.Parse(Console.ReadLine()) 
    let a () = 
        printf "numero:"
        System.Int32.Parse(Console.ReadLine())

    let lista = [ for i in 1 .. n -> a ()]    
    let pares = [for i in lista do if i%2=0 then yield i]
    let impares = [for i in lista do if i%2<>0 then yield i]
    
    printfn "\n pares"
    for i in pares do printf "%i " i

    printfn "\n impares"
    for i in impares do printf "%i " i
    
    //criba de eratostenes
    printfn "\n-----Criba-----"
    printf "max:"
    let max  = System.Int32.Parse(Console.ReadLine())
    let array = new BitArray(max, true);
    let lastp = Math.Sqrt(float max) |> int
    for p in 2..lastp+1 do
        if array.Get(p) then
            for pm in p*2..p..max-1 do
                array.Set(pm, false);
    let primos = [for i in 2..max-1 do if array.Get(i) then yield i]
    
    printfn "\n primos"
    for i in primos do printf "%i " i

    Console.ReadKey() |>ignore
    0 // devolver un código de salida entero