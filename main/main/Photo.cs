using System.Collections.Generic;

namespace main
{
    public class Photo
    {
        public char orientation {get;set;}
        public List<string> tags {get;set;}

        public Photo(char orientation, List<string> tags) {
            this.orientation = orientation;
            this.tags = new List<string>();
            this.tags.AddRange(tags);
        }
    }
}