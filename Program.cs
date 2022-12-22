// See https://aka.ms/new-console-template for more information

int numSecreto = new Random().Next(1,100);
ushort intentos =0;
Console.Clear();
Console.WriteLine($"Adivine el numero secreto de 0 a 100. En el menor numero de intentos ");
Console.WriteLine($" Para salir sin adivinar digite 999");

ushort numero;
Console.Write("Entre el numero =>");
do
{
    try
    {
        numero =ushort.Parse(Console.ReadLine());
    }
     catch(FormatException Error)
    {
        Console.WriteLine($"---------------");
        Console.WriteLine($"Debe ingresar numeros");
        Console.WriteLine($"---------------");
        numero = 0;
    }
    catch(Exception err)
    {
        Console.WriteLine($"---------------");
        Console.WriteLine($"Error de Windows");
        Console.WriteLine($"---------------");
        numero = 0;
    }
       finally {

        Console.WriteLine($"Entro por aquí de igual forma, soy útil para organizar ");

    }
    
    if (numero == 999) break;
    intentos++;
    if(numero < numSecreto)
    {
        Console.WriteLine($" Intento {intentos} : su numero es menor que el numero secreto ");

    } 
    if(numero > numSecreto)
    {
        Console.WriteLine($" Intento {intentos} : El numero es mayor que el numero secreto ");
    }

    
}while (numero != numSecreto);
    if(numero == 999)
        Console.WriteLine($" Ummm {intentos} Veo que no pido con el reto el numero era {numSecreto}");
    else 
        Console.WriteLine($" Felicitaciones el numero secreto es {numSecreto} y lo logro adivinar en {intentos} intentos ");
        Console.WriteLine($"Game Over ");


