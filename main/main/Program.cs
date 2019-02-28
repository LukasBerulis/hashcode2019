using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello my name is Romas");
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("input.txt"))
                {
                    
                    // Read the stream to a string, and write the string to the console.
                    while (line = sr.)
                    string line = sr.ReadToEnd();
                    if (line.Split(' ').length < 2) continue;
                   
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
