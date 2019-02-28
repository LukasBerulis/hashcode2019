using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Slide
    {
        char position;
        List<string> tagArray;
        int index;

        public Slide(char p,  List<string> tags,int index)
        {
            position = p;
            tagArray = tags;
            this.index = index;
        }
        

        public override int GetHashCode()
        {
            int hash = 3;
            hash ^= position.GetHashCode();

            foreach(string tag in tagArray)
            {
                hash ^= tag.GetHashCode();
            }
            return hash;
        }
    }
}
