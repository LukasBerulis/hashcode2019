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
            var photos = ReadSomeShit.readFile();
            var slides = SlideBuilder.createSlides(photos);

            Console.ReadKey();
        }
    }
}
