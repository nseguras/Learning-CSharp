// Bucle para imprimir 80 veces texto. 


for (int i = 1; i <= 80; i +=5)
{
    Console.WriteLine($"Esta es la vez {i}");
}

// 1.El usuario ingresa un numero en la consola
// 2.El programa multiplica por los primeros 10 numeros a este numero ingresado
// 3. Se debe imprimir el resultado en cada operacion

Console.WriteLine("Ingrese numero a multiplicar 10 veces");

var numeroParaMultiplicar = int.Parse( Console.ReadLine()! );
Console.WriteLine("----");

for (int i = 1; i<=10; i++)
{
    int resultado = i * numeroParaMultiplicar;
    Console.WriteLine($"{i} x {numeroParaMultiplicar} = {resultado}");
}