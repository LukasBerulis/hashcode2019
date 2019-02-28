using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class Slide
    {
        public List<string> tagArray;
        public Tuple<int, int> indexes;// if -1 doesn't exist
        public Slide()
        {
            tagArray = new List<string>();

        }
       public Slide(List<string> tags, Tuple<int, int> indexes)
        {
            tagArray = tags;
            this.indexes = indexes;
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
