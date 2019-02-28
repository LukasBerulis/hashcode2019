using System.Collections.Generic;

namespace main
{
    public class Photo
    {
        public int index { get; set;}
        public char orientation {get;set;}
        public List<string> tags {get;set;}

        public Photo(char orientation, List<string> tags, int index) {
            this.orientation = orientation;
            this.tags = new List<string>();
            this.tags.AddRange(tags);
            this.index = index
        }
    }
}