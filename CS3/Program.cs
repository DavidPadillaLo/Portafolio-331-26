using System;

namespace CS3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sesion 6: Operadores:
            // Declaracion de la variables
            double a = 1;
            double b = 2;
            double resultado = 0;
            // a. Suma: +
            resultado = a + b;
            Console.WriteLine($"Resultado: {resultado}");
            // b. Resta: -
            resultado = a - b;
            Console.WriteLine($"Resultado: {resultado}");
            // c. Multiplicacion: *
            resultado = a * b;
            Console.WriteLine($"Resultado: {resultado}");
            // d. Division: /
            resultado = a / b; 
            Console.WriteLine($"Resultado: {resultado}");
            // e. Resto (modulo): %
            resultado = a % b;
            Console.WriteLine($"Resultado: {resultado}");
            
            // Incrementos y decrementos
            // resultado = resultado + 9;
            resultado += 9;
            resultado -= 5;
            Console.WriteLine($"Resultado: {resultado}");
  
            // 2. Operadores comparativos: 
            // a. Igualdad: ==
            // b. Diferencia: !=
            // c. Menor que: <
            // d. Mayor que: >      
            // f. Menor o igual que: <=
            // e. Meyor o igual que: >=  

            // Sesion 7: Operadores comparativos   
            bool m = false;
            m = 4 == 10;
            Console.WriteLine($"Igualdad: {m}");
            m = 5 != 5;
            Console.WriteLine($"Diferencia: {m}");
            m = 5 > 4;
            Console.WriteLine($"Mayor que: {m}");
            m = 4 < 5;
            Console.WriteLine($"Menor que: {m}");
            m = 9 >= 6;
            Console.WriteLine($"Mayor o igual que: {m}");
            m = 8 <= 1;
            Console.WriteLine($"Menor o igual que: {m}");

            // 3. Operadores Logicos
            // a. Y (AND): &&
            // b. O (OR): ||
            bool e = false; // ntrada 1
            bool f = true; // Entrada 2
            bool d = false; // Resultado
            d = e && f; 
            Console.WriteLine($"Y : {d}");
            d = e || f;
            Console.WriteLine($"O: {d}");

        }
    }
}