using System;
using TestLib;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematic matematic = new Matematic();

            try
            {
                Console.WriteLine(matematic.DelA_B(1, 2));
            }
            catch (Exception ex)
            { Console.WriteLine(ex.ToString()); }
          


            Console.WriteLine("Hello World!");
        }
    }
}
