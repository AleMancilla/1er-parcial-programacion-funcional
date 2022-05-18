// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.

open System

let suma a b = a + b

let resta a b = a - b

let multiplicacion a b = a * b

let division a b = a / b

[<EntryPoint>]
let main argv = 
    System.Console.WriteLine("Operadores de Suma, Resta, Multiplicación y divisíon")
    System.Console.WriteLine("Introduzca dos numeros")
    let num1 = Console.ReadLine()
    let num2 = Console.ReadLine()
    let valor1 = Convert.ToInt32(num1)
    let valor2 = Convert.ToInt32(num2)
    let valor3 = suma valor1 valor2
    let valor4 = resta valor1 valor2
    let valor5 = multiplicacion valor1 valor2
    let valor6 = division valor1 valor2
    Console.WriteLine("La suma de los dos numeros es : "+valor3.ToString())
    Console.WriteLine("La resta de los dos numeros es : "+valor4.ToString())
    Console.WriteLine("La multiplicacion de los dos numeros es : "+valor5.ToString())
    Console.WriteLine("La division de los dos numeros es : "+valor4.ToString())
    let tecla = Console.ReadKey()
    0 // devolver un código de salida entero
