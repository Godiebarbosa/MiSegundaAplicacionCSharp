using System;
using System.Security.Cryptography;
namespace ConsoleApp
{
    class Program
    {
        static void Main()
        // Este es el punto de inicio de nuestra aplicación. El programa empieza a ejecutarse aquí.
    {
        Console.WriteLine("Bienvenido a mi segunda aplicacion");
        Console.Write("Digite nombre");
        string nombre = Console.ReadLine();
        Console.WriteLine($"Hola, {nombre}!");
        int edad;
        while(true)
            {  
                Console.Write("digite su edad real");
                string entradaEdad = Console.ReadLine();
                if (int.TryParse(entradaEdad, out edad))
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Hola, {nombre} eso no es una edad!");
                }
            }
            if (edad >= 18)
            {
                Console.WriteLine($"Hola, {nombre} eres mayor de edad!");
            }
            else 
            {
                Console.WriteLine($"Hola, {nombre}eres menor de edad!");
            }
            
            int calificacion;
            while(true){}
    }
    }
}
