using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(System.IO.File.ReadAllText(@"F:\1CSharp\13-Tema1_Exceptions\13-Tema-1\Ex1\data.txt"));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The file path is not correct.");
            }

            catch (NotSupportedException)
            {
                Console.WriteLine("The path is not in a valid format.");
            }
            catch (System.IO.FileNotFoundException)
            {
               
                Console.WriteLine("Could not finde file!");
            }
            catch (System.IO.PathTooLongException)
            {
                Console.WriteLine("The file path or file name, exceed the maximum length.");
                
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Console.WriteLine("The file path is invalid.");
            }
           
            catch (System.IO.IOException)
            {
                Console.WriteLine("An I/O error occurred while opening the file.");
            }
            Console.ReadLine();
           
        }
    }
}
