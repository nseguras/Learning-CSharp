// See https://aka.ms/new-console-template for more information

/* 
  Multiple comentarios
  en bloque
*/

// Declaraciones de Variables
string nombre = "Nico";
var url = "nsegura.cl";
Console.WriteLine("Hola " + nombre + " url : " + url);

//-------------------------------------------
// TIPOS DE VARIABLE.

// numeros enteros
byte miByteNumero = 255;  // numeros enteros 0 a 255 pequeños 8 bits

short miShortNumero = 123;  // numero pequeño 16 bits

int miNumero = 100;       // numeros enteros normales de 32 bits
int otroNumeroEntero = -500; // Pos y neg

long miNumeroLong = -9999999; // Numeros muy grandes 64 bits

// numeros racionales
float miFloatNumero = 622.36f;  // Flotante. Necesita f  32 bits. 7 digitos.

double miDoubleNumero = 96.25;  // Usa más memoria. Double no necesita f.  64 bits.  15 digitos.

decimal miDecimalNumero = 487.567m;  // Gasta más memoria que double. Necesita m. %sirve para divisas. 28 digitos.

// Condicion y texto
bool mstatusProducto = true;  // True or False

string miCadena = "esta es una cadena de texto";

char miCaracter = 'A'; //Solo almacena un caracter. Con apostrofe.

// %% En general se usa: string - bool - bytes - decimal - double - int. 

//-------------------------------------------

const int miConstanteNumerica = 500; // Const es constante que no se puede modificar nunca más. 

// Las VARIABLES pueden cambiar su valor, pero las CONSTANTES no cambian nunca su valor. Aplicable todo de variable a constante. 
miCadena = "esta es mi nueva cadena de texto";

//-------------------------------------------

// Palabras clave de C#. Reservadas.

//-------------------------------------------

// Declaracion de valores nulos. Colocar ? para definir null.

bool? miVariableNull = null;
int?   nuNumeroNull = null;
string miCadenaNull = null;


//-------------------------------------------








