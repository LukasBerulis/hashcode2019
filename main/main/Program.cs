using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Photo> photos = ReadSomeShit.readFile().ToList();
            List<Slide> slides = SlideBuilder.createSlides(photos);
            Console.WriteLine(" >> exit");
            Console.ReadKey();
        }
    }
}
