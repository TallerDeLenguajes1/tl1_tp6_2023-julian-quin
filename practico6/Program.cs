
//----------Ejercicio1------------------------
/*
int intNum = 0;
bool anda= false;
string? Numtexto = " ";
int digito;
int NumReversa=0;

while (!anda)
{
    Console.WriteLine("Ingrese un número valido: ");
    Numtexto = Console.ReadLine();
    anda = int.TryParse(Numtexto, out intNum);
    if (!anda)
    {
        Console.WriteLine(Numtexto + "No es un numero valido");
    }
    
}

if(intNum > 0 )
{
    while (intNum != 0)
    {
        digito = intNum % 10;
        intNum /= 10;
        NumReversa = NumReversa * 10 + digito;
    }
    Console.WriteLine("Número invertido: " + NumReversa);
}
*/


//------------------Ejercicio4---------------------
string? frase1, frase2, subcadena;
int longitud=0;
Console.WriteLine("Ingresa cualquier texto");
frase1 = Console.ReadLine();
Console.WriteLine(frase1);
if(frase1!=null){

    longitud= frase1.Length;
    Console.WriteLine($"La longitud es: {longitud}");

}else Console.WriteLine("no hay cadena");
//concatenacion
Console.WriteLine("Ingresa cualquier texto");
frase2 = Console.ReadLine();
Console.WriteLine("concatenacion: " + frase1 + frase2);
//subcadena
subcadena= frase1.Substring(4,4);
Console.WriteLine($"subcadena: {subcadena}");

//forech
foreach (char caracter in frase1)
{
    Console.WriteLine(caracter);
}

//buscar palabra 
bool Si_No;
int contador=0;
Console.WriteLine("Ingresa la palabra a buscar");
subcadena= Console.ReadLine();
string [] palabras = frase1.Split(" "); // pensado para una frase con delimitador de espacio
longitud = palabras.Length; //calculo la cantidad de indices del arreglo
for (int i = 0; i < longitud; i++)
{
    Si_No=palabras[i].StartsWith(subcadena);
    if(Si_No) contador ++;
}
Console.WriteLine($"La ocurrencia de la palbra {subcadena} en la cadena es de {contador} veces");

// convierto la cadena a mayuscula y minuscula
frase1=frase1.ToUpper();
Console.WriteLine($"cadena en mayuscula: {frase1}");
frase1=frase1.ToLower();
Console.WriteLine($"cadena en minuscula: {frase1}");



