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
string? Numtexto = " "; // Los tipos de datos primitivos, como int, double, bool, etc., no pueden 
                        // contener valores nulos. Sin embargo, al agregar el signo de interrogación después 
                        //del tipo de dato, como int?, double?, bool?, se permite que ese tipo de dato pueda 
                        //aceptar el valor null además de los valores normales.
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

// funcion ( tipo.TryParse )
/*La función se utiliza para intentar convertir una representación de cadena (string) 
de un valor en un tipo de dato específico, sin lanzar una excepción en caso de que la conversión falle.
La principal ventaja de utilizar TryParse en lugar de otros métodos de conversión estándar, como 
Convert.ToInt32 o int.Parse, es que evita lanzar una excepción en caso de que la conversión no sea exitosa.
En su lugar, se utiliza un valor de retorno booleano para indicar si la conversión tuvo éxito o no.

La conversión utilizando int.TryParse puede no ser exitosa en las siguientes situaciones:

Si la cadena proporcionada no representa un número válido en formato entero. 
Por ejemplo, si se intenta convertir la cadena "abc" en un entero, la conversión fallará.
Si la cadena proporcionada es nula o está vacía. int.TryParse devuelve false en estos casos, 
ya que no se puede realizar ninguna conversión.


*/

// -------------- Ejercicio 2-----------------------
string? numeroText;
int eleccion=1;
float numero1=0,numero2=0, resultado=0;
int opcion;
bool valido= false;
do
{
    Console.WriteLine("( SELECCIONE LA OPERACION)");
    Console.WriteLine(" \t(1)Suma\n \t(2)Resta\n \t(3)Multiplicacion\n \t(4)division\n");
    numeroText= Console.ReadLine();
    int.TryParse(numeroText, out opcion);
    while (!valido)
    {
        Console.WriteLine("Dame el 1er numero: ");
        numeroText= Console.ReadLine();
        valido=float.TryParse(numeroText, out numero1);
        if (!valido)
        {
            Console.WriteLine("El numero " + numeroText + " no es valido");
        }
    }

    valido=false;

    while (!valido)
    {
        Console.WriteLine("Dame el 2do numero: ");
        numeroText= Console.ReadLine();
        valido=float.TryParse(numeroText, out numero2);
        if (!valido)
        {
            Console.WriteLine("El numero " + numeroText + " no es valido");
        }
    }

    valido = false;
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
    Console.WriteLine("¿ Desea hacer otra operacion ?");
    numeroText= Console.ReadLine();
    int.TryParse(numeroText, out opcion);

} while (opcion==1);