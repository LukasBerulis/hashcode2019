using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class WriteSomeShit
    {

        public static void writeToFile(List<Slide> slides, string filename)
        {
            try
            {
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(filename))
                {
                    file.WriteLine(slides.Count());
                    foreach (var slide in slides)
                    {

                        if (slide.indexes.Item2 >= 0)
                        {
                            file.WriteLine(slide.indexes.Item1 + " " + slide.indexes.Item2);
                        }
                        else
                        {
                            file.WriteLine(slide.indexes.Item1);
                        }
                    }
                }
            }
            catch (Exception e0)
            {
                Console.WriteLine(e0.ToString());
            }
        }
    }
}
