using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Net.WebClient webClient = new System.Net.WebClient();

            try
            {
                webClient.DownloadFile("https://upload.wikimedia.org/wikipedia/commons/4/40/Ninjaaa.jpg", @"F:\1CSharp\13-Tema1_Exceptions\13-Tema-1\Ex2\test.jpg");
                Console.WriteLine("Download complete!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The address parameter is null or the file name parameter is null!");
            }
            catch (System.Net.WebException)
            {
                Console.WriteLine("Invalid address or empty file or the file does not exist.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The File Name path is not of a legal form!");
            }
            finally
            {
                webClient.Dispose();
            }
           
            Console.ReadLine();
        }
    }
}
