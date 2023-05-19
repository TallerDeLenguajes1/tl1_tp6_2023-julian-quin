// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!"); //pirnt f
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);*/

/*Construir un programa que permita invertir un número. Verifique que el
texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
número sólo si éste es mayor a 0.*/

/*int intNum = 0;
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
}*/

// -------------- Ejercicio 2-----------------------
string? numeroText;
int eleccion=1;
float numero1,numero2, resultado=0;
int decision;

Console.WriteLine("ingrese un numero para operar");
numeroText= Console.ReadLine();
float.TryParse(numeroText, out numero1);
Console.WriteLine("ingrese otro numero para operar");
numeroText= Console.ReadLine();
float.TryParse(numeroText, out numero2);

do
{
    Console.WriteLine("( SELECCIONE LA OPERACION)");
    Console.WriteLine("(1)Suma, (2)Resta, (3)Multiplicacion, (4)division");
    numeroText= Console.ReadLine();
    int.TryParse(numeroText, out eleccion);

    switch (eleccion)
    {
        case 1:
           resultado= numero1+numero2;
        break;
        case 2:
           resultado= numero1-numero2;
        break;
        case 3:
           resultado = numero1 * numero2;
        break;
        case 4:
           if (numero2!=0)
           {
               resultado= numero1/numero2;
           } else {
               Console.WriteLine("Error: intentas dividir un numero en cero");
           }
        break;
    }
    Console.WriteLine("Resultado = "+ resultado);
    Console.WriteLine("desea hacer otra operacion?");
    numeroText= Console.ReadLine();
    int.TryParse(numeroText, out decision);

} while (decision==1);