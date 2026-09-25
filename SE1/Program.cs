using System;

namespace SE1
{
    class Program
    {
        static void Main(string [] args)
        {
            // Sesion 9: Esxamen
            // Sesion 10: Solucion examen
            
            // 1. Proyecti en C#endregion
            // 2. Sintaxis de variable
            // tipo_de_dato identificador_variable; 
            bool a;
            int numero; 
            // 3. Interpolacion
            // Combinacion de datos, dentro de una cadena.
            numero = 10;
            a = true;
            Console.WriteLine($"Boolenao; {a}");
            Console.WriteLine($"Numero: {numero}");
            int m = 0;
            int n = -1;
            m += 4;
            m -= 4;
            m -= 7;
            n += 10;
            // 5. Operador rsto (modulo).
            int residuo = 0;
            residuo = 40 % 16;
            Console.WriteLine($"Residuo; {residuo}");
            // 6. Operadosres aritmeticos
            double operacion = 0;
            operacion = ((30 + 8 - 2) / 2) * -1;
            Console.WriteLine($"Operacion; {operacion}");
            // 7. 
            bool interruptor_1 = false;
            bool interruptor_2 = true;
            bool bombilla = interruptor_1 && interruptor_2;
            if (bombilla == true)
            {
                Console.WriteLine($"Bombilla: {bombilla}");
            } 
            else
            {
                Console.WriteLine($"Bombilla: {bombilla}");
            }
            // 8. 
            int dia = 15;
            string mes = "septiembre";

            if (dia == 16 && mes == "septiembre")
            {
                Console.WriteLine("Asueto");    
            }
            else
            {
                Console.WriteLine("Sin definir");
            }
            // 9. 
            bool resultado = (7 < 11) && (10 != 0);
            Console.WriteLine($"Resultado; {resultado}");
        }
    }   
}