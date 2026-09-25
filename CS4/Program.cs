using System;
namespace CS4
{
    class Program
    {
        static void Main(string[] args)
        {
        // Sesiin 7: 
        // 
        int a = 0;
        if (a == 1) // Si el valor de "a" es igual a 1, entonces....
        {
            // Bloqye de instrucciones 
            Console.WriteLine("El valor de 'a' es igual a 0.");
            a += 1;
            Console.WriteLine($"a: {a}");
        }
        bool foco = false; // A la variable "doco", se le asigna, inicialmente, false.
        if (foco == true) // Si el valor de la variable "foco" es true, entonces ....
        {
            Console.WriteLine("El foco esta encendido"); // .../ impresion del estado del foco: encendidio.
        }    
        else // En caso contrario, entonces ....
        {
            Console.WriteLine("El foco esta apagado"); // .... impresion del estado del foco, apagado.
        }
        // Sesion 8.
        // 2. Estructura selectiva multiple (instruccion if-else if-else).
        // Declaracion e inicializacion
        int salon = 331; // A la variable "salon", se le agisna, inicialmente, 331.
        bool admin_1 = true;
        bool admin_2 = true;
        bool administrativas = false;
        administrativas = admin_1 || admin_2; 
        if (salon == 331) // Si el valor de la variable "salon" es 331, entonces ....
        {
            Console.WriteLine("Exactas"); // .... impresion de especialidad, "Exactas".
        }
        else if (administrativas == true)  // Si no es igual a 331, pero si a 332, entonces ....
        {
            Console.WriteLine("Administrativas"); // .... impresion de especialidad, "Administrativas".
        }
        else if (salon == 334) // Si no es igual a 331, ni 332, ni 333, pero si a 334, entoncess ....
        {
            Console.WriteLine("Biologicas"); // .... impresion de especialidad, "Biologicas".
        }
        else if (salon == 335) // Si no es igual a 331, ni 332, ni 333, ni 334, pero si a 335, entoncess ....
        {
            Console.WriteLine("Humanidades"); // .... impresion de especialidad, "Humanidades".
        }
        else // En cualquier otro caso, entonces .... 
        {
            Console.WriteLine("Salon no registrado"); // .... impresion "Salon no registrado".
        }
        }
    }
}