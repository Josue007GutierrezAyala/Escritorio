using System;

namespace Actividad_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Imprime los numeros del x hasta el 60 de 3x3");
            Console.WriteLine("De donde arrancamos el ciclo (incio)");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De donde terminamos en ciclo (final");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De cuanto en cuanto ira el ciclo");
            z = Convert.ToInt32(Console.ReadLine());
            if (x < y)
            {
                for (int i = x; i <= y; i += z)
                {
                    Console.WriteLine("i =" + i);
                }
            }
            else if (x > y)
            {
                
                for (int i = x; i >= y; i -= z)
                {
                    Console.WriteLine("i =" + i);
                }

            }
         
        }
    }
}