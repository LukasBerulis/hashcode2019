using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class ReadSomeShit
    {
        
        public static Photo[] readFile()
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("in/a_example.txt"))
                {
                    string line;
                    // Read the stream to a string, and write the string to the console.
                    int index = 0;
                    int n = int.Parse(sr.ReadLine());
                    Photo[] pictures = new Photo[n];
                    Console.WriteLine(n);
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] values = line.Split();
                        char orientation = Char.Parse(values[0]);
                        int tagCount = int.Parse(values[1]);
                        List<string> tags = new List<string>();
                        for (int i = 2; i < tagCount + 2; i++)
                            tags.Add(values[i]);
                        pictures[index++] = new Photo(orientation, tags);

                    }
                    return pictures;
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            //should not happen
            return new Photo[1];
        }
    }
}
