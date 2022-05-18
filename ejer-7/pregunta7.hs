suma::Int -> Int -> Int
suma a b = a + b
resta::Int -> Int -> Int
resta a b = a - b
multiplicacion::Int -> Int -> Int
multiplicacion a b = a * b
division::Float -> Float -> Float
division a b = a / b

main = do
    print "Operadores de Suma, Resta, Multiplicación y divisíon"
    print "Introduzca dos numeros"
    valor1<-getLine
    valor2<-getLine
    print ("el valor1: "++valor1 ++" el valor2: "++valor2)
    print ("La suma es ")
    print (suma(read valor1 :: Int)(read valor2 :: Int))
    print ("La resta es ")
    print (resta(read valor1 :: Int)(read valor2 :: Int))
    print ("La multiplicacion es ")
    print (multiplicacion(read valor1 :: Int)(read valor2 :: Int))
    print ("La division es ")
    print (division(read valor1 :: Float)(read valor2 :: Float))