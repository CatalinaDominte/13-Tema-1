using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               int j = 0;
                Console.Write("Introduceti zece numere: ");
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write($"Introduceti numarul {i}: ");
                    int number = ReadNumber(1, 100, j);
                    j = number;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        static int ReadNumber(int start, int end, int j)
        {
            int number = int.Parse(Console.ReadLine());

            if ((number < start) || (number > end) || (number < j))
            {
                throw new ArgumentOutOfRangeException();
            }
            return number;
           
        }
    }
}
