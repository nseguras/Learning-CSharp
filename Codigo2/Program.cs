
/* Este algoritmo se encarga de realizar operaciones basicas matemáticas de dos números;
 * 
 * 1.Usuario ingresa numero x.
 * 2.Usuario ingresa numero y.
 * 3.Programa captura valores y almacena.
 * 4.Programa opera valores.
 * 5.Programa muestra en pantalla.
 */


// Signo de exclamación señala que no es nulo. 



//if (primerNumeroString is null || primerNumeroString == "")
//{
//    Console.WriteLine("Ingreso un valor nulo o en blanco, termino el programa.");
//    return;
//}



// Algoritmo para evaluar si un texto tiene la nomeclatura de numero
// Si es posible convertir un texto a numero. 
// 1. Es declarar una variable resultado posible
// 2. Condicionar si el texto es nomeclatura numerica.
// 3. El cluente ingresa el tipo de operacion a realizar.
// Suma Resta Multiplicacion o Division
// 3. Si no es numero termina el programa.
// 4. Si es numero continua el programa.

// Pedir primer numero
using System.Net.Http.Headers;

Console.WriteLine("Ingrese X");
var primerNumeroString = Console.ReadLine();
int primerNumeroInt = 0;

if (String.IsNullOrEmpty(primerNumeroString))
{
    Console.WriteLine("El valor es nulo o vacio,con operador isNullOrEmpty.");
    return;
}

if ( !int.TryParse(primerNumeroString, out primerNumeroInt))
{
    Console.WriteLine("El valor ingresado no es un numero");
    return;

}

//if (primerNumeroInt >= 100)
//{
//    Console.WriteLine("Su numero es mayor o igual que cien");
//}
//else
//{
//    Console.WriteLine("Su numero es menor que cien");
//}

//if (primerNumeroInt <= 10)
//{
//    Console.WriteLine("menor a 10");
//}
//else if(primerNumeroInt > 10 && primerNumeroInt <= 20)
//{
//    Console.WriteLine("entre 10 y 20");
//}
//else
//{
//    Console.WriteLine("Su numero es menor que 10");
//}


//var primerNumeroInt = int.Parse(primerNumeroString!);

// Pedir Segundo numero
Console.WriteLine("Ingrese Y");
var segundoNumeroString = Console.ReadLine();
//var segundoNumeroInt = int.Parse(segundoNumeroString!);

if ( string.IsNullOrEmpty(segundoNumeroString))
{
    Console.WriteLine("Segundo numero esta en blanco o nulo");
    return;
}

var segundoNumeroInt = 0;

if (!int.TryParse(segundoNumeroString, out segundoNumeroInt))
{
    Console.WriteLine("El valor ingresado no es un numero");
    return;
}


Console.WriteLine("Selcciona: 1) Suma, 2) Resta, 3) Muliplicacion, 4) Division");

// Corrobora el tru o false si puede o no relacionarlo, y despues devuelve tipoOperacion o 0.

int tipoOperacion = int.TryParse(Console.ReadLine(), out tipoOperacion) ? tipoOperacion : 0;

var total = 0;
switch(tipoOperacion)
{
    case 1: total = primerNumeroInt + segundoNumeroInt;
        Console.WriteLine($"{primerNumeroInt} + {segundoNumeroInt} = {total} ");
        break;

    case 2: total = primerNumeroInt - segundoNumeroInt;
        Console.WriteLine($"{primerNumeroInt} - {segundoNumeroInt} = {total} ");
        break;

    case 3: total = primerNumeroInt * segundoNumeroInt;
        Console.WriteLine($"{primerNumeroInt} X {segundoNumeroInt} = {total}");
        break;

    case 4: total = primerNumeroInt / segundoNumeroInt;
        Console.WriteLine($"{primerNumeroInt} / {segundoNumeroInt} = {total}");
        break;

    default: Console.WriteLine("Ingreso un valor erroneo, debe ser de 1 al 4");
        return;
}







//// OPERACIONES MATEMATICAS

////var resultadoSuma = primerNumeroInt + segundoNumeroInt;
//var resultadoSuma = primerNumeroInt;
//resultadoSuma += segundoNumeroInt;
//Console.WriteLine("El resultado de la suma es " + resultadoSuma);

////var resultadoResta = primerNumeroInt - segundoNumeroInt;
//var resultadoResta = primerNumeroInt;
//resultadoResta -= segundoNumeroInt;
//Console.WriteLine("El resultado Resta es " + resultadoResta);

////var resultadoMultiplicacion = primerNumeroInt * segundoNumeroInt;
//var resultadoMultiplicacion = primerNumeroInt;
//resultadoMultiplicacion *= segundoNumeroInt;
//Console.WriteLine($"El resultado Multiplicacion es {resultadoMultiplicacion}");

////var resultadoDivision = primerNumeroInt / segundoNumeroInt;
//var resultadoDivision = primerNumeroInt;
//resultadoDivision /= segundoNumeroInt;
//Console.WriteLine($"El resultado Division es {resultadoDivision}");


