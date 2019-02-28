using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace main
{
    static class IO
    {
        public static List<Photo> ReadFile(string filename)
        {
            Console.WriteLine("Hello my name is Romas");
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(filename))
                {
                    // Read the stream to a string, and write the string to the console.
                    string line = null;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Split(' ').Length < 2) continue;
                    }
                        
                    

                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }


            return null;
        }
    }
}
