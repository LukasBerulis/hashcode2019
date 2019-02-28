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
            ReadSomeShit reader = new ReadSomeShit();
            List<Photo> photos = ReadSomeShit.readFile("input.txt").ToList();
            List<Slide> slides = SlideBuilder.createSlides(photos);
            int a = 0;
        }
    }
}
