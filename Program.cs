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
                    Console.WriteLine($"Hola, {nombre}, eso no es una edad!");
                }
            }
            if (edad >= 18)
            {
                Console.WriteLine($"Hola, {nombre}, eres mayor de edad!");
            }
            else 
            {
                Console.WriteLine($"Hola, {nombre}, eres menor de edad!");
            }

             int calificacion; // Creamos una variable para guardar la calificación del usuario.
            while (true) // Empezamos un bucle que continuará pidiendo la calificación hasta que sea correcta.
            {
                Console.Write("Por favor, ingresa una calificación del 1 al 10: "); // Pide al usuario que ingrese una calificación.
                string entradaCalificacion = Console.ReadLine(); // Lee lo que el usuario escribe y lo guarda en la variable entradaCalificacion.
                if (int.TryParse(entradaCalificacion, out calificacion) && calificacion >= 1 && calificacion <= 10) // Intenta convertir la entrada a un número y verifica que esté entre 1 y 10.
                {
                    break; // Sale del bucle si la conversión fue exitosa y la calificación es válida.
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingresa un número entre 1 y 10."); // Muestra un mensaje de error si la entrada no es válida.
                }
            }
            
                Console.Write("Por favor, ingresa una calificación del 1 al 10: "); 
                if (calificacion >=8)
                {
                    Console.WriteLine("Buen trabajo, sigue asi");
                }
                else if (calificacion >=5)
                {
                    Console.WriteLine("Buen trabajo, pero hay margen para mejorar");
                }
                else
                {
                    Console.WriteLine("Necesitas mejorar");
                }
            
            Console.WriteLine("Presiona cualquier tecla para salir..."); // Muestra un mensaje indicando que el usuario debe presionar una tecla para salir.
            Console.ReadKey(); // Espera a que el usuario presione una tecla para cerrar la aplicación.
    }
}
}