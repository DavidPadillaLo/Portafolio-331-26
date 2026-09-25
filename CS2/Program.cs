using System;
// Espacio de nombre
namespace CS2
{
    // Clase Principal
    class Program
    {
        // Funcion Principal: (Main)
        static void Main(string[] args)
        {
            // Sesion 5: Tipos de datos
            // Sintaxis para declarar variables
            // Tipo_de_dato identificador_variables;
            // 1. Entero
            int a;
            // 2. Cadenas de texto
            string s;
            // 3.1 Flotante (presicion sencilla)
            float f; 
            // 3.2 Flotante (presicion doble)
            double d; 
            // 4. Booleano (logico)
            bool b;
            // Inicializaciones 
            a = 5;
            s = "Exactas"; 
            f = 8.5F; 
            // Flotante presicion sencilla (F/f)
            d = 9.5;
            b = true; 
            // Palabra reservada; identificador especial predefinido para el copilador.
            // Interpolacion: combinacion de datos dentro de una cadena ($)
            // Impresiones ($)
            Console.WriteLine($"Entero: {a}");
            Console.WriteLine($"Flotante (presicion sencilla): {f}");
            Console.WriteLine($"Flotante (presicion doble): {d}");
            Console.WriteLine($"Cadena de texto: {s}");
            Console.WriteLine($"Booleanos: {b}");
        } // Termino de la funcion principal
    } // Termino de la clase principal
} // Termino del espacio de nombres