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
        static string[] fileNames = { "a_example.txt", "b_lovely_landscapes.txt", "c_memorable_moments.txt", "d_pet_pictures.txt", "e_shiny_selfies.txt" };
        //static string fileName = "e_shiny_selfies.txt";
        static void Main(string[] args)
        {
            foreach (string fileName in fileNames) {
                var photos = ReadSomeShit.readFile(fileName);
                var slides = SlideBuilder.createSlides(photos);
                WriteSomeShit.writeToFile(slides, "result" + fileName);
            }
        }
    }
}
