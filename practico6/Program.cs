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