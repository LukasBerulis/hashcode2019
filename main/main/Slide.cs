using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Slide
    {
        List<string> tagArray;
        int index;

        public Slide(List<string> tags,int index)
        {
            tagArray = tags;
            this.index = index;
        }
        
        public override int GetHashCode()
        {
            int hash = 3;

            foreach(string tag in tagArray)
            {
                hash ^= tag.GetHashCode();
            }
            return hash;
        }
    }
}
