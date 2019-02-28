using System.Collections.Generic;

namespace main
{
    public class SlideBuilder
    {
        public static List<Slide> createSlides(Photo[] photos)
        {
            List<Slide> slides = new List<Slide>();
            List<Photo> verticals = new List<Photo>();
            Photo vertical = null;
            foreach (Photo photo in photos) {
                if (photo.orientation == 'H') {
                    Slide slide = new Slide();
                    slide.tagArray = photo.tags;
                    slide.indexes = new System.Tuple<int, int>(photo.index, -1);
                    slides.Add(slide);
                } else {
                    verticals.Add(photo);
                }
            }
            verticals.Sort((a, b) => {
                a.tagArray.Count > b.tagArray.Count;
            });

            for(int i=0; i < verticals.Count; i++) {
                Slide slide = new Slide();
                HashSet<string> mergedTags = new HashSet<string>();
                foreach (var tag in verticals[i]) {
                    mergedTags.Add(tag);
                }
                foreach (var tag in verticals[verticals.Count-i])
                {
                    mergedTags.Add(tag);
                }
                slide.tagArray = mergedTags;
                slide.indexes = new System.Tuple<int, int>(verticals[i].index, verticals[verticals.Count-i].index);
            }

            return slides;
        }
    }
}