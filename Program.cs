using System;

namespace problem1teoria10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double stopienwielomianu;
            double[] wspolczynnikiwielomianu = { 1, 1, 0, 1 };


            Console.WriteLine("Wartość wielomianu obliczona pierwszą metodą: {0}",
            Wielomian(1, wspolczynnikiwielomianu));
            Console.WriteLine("Wartość wielomianu obliczona drugą metodą: {0}",
            Wielomian(1, out stopienwielomianu,wspolczynnikiwielomianu)); 
            Console.WriteLine("Stopień wielomianu: {0}", stopienwielomianu);

            Console.WriteLine("\nInny sposób przekazania wartości współczynników wielomianu do metody");
            
            Console.WriteLine("\nWartość wielomianu obliczona pierwszą metodą: {0}", Wielomian(1, 0, 1, 2));

            Console.WriteLine("Wartość wielomianu obliczona drugą metodą: {0}", Wielomian(1, out stopienwielomianu, 0, 1, 2));

            Console.WriteLine("Stopień wielomianu: {0}", stopienwielomianu);
            Console.ReadKey();


        }
        
        static double Wielomian(double x, params double[] a)
        {
            double suma = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                suma = suma * x + a[i];
            }
            return suma;
        }

        static double Wielomian(double x, out double stopien, params double[] a)
        {
            stopien = a.Length - 1;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {
                    stopien--;
                    break; 
                }
            }
            return Wielomian(x, a);
        }
    }
}
