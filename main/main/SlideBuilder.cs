using System.Collections.Generic;

namespace main
{
    public class SlideBuilder
    {
        public static List<Slide> createSlides(List<Photo> photos)
        {
            List<Slide> slides = new List<Slide>();
            Photo vertical;
            foreach (Photo photo in photos) {
                if (photo.orientation == 'H') {
                    Slide slide = new Slide();
                    slide.tagArray = photo.tags;
                    slides.Add(slide);
                } else {
                    if (vertical != null) {
                        Slide slide = new Slide();
                        HashSet<string> mergedTags = new HashSet();
                        mergedTags.AddRange(photo.tags);
                        mergedTags.AddRange(vertical.tags);
                        slide.tagArray.AddRange(mergedTags);
                        slides.Add(slide);
                    } else {
                        vertical = photo;
                    }
                }
            }
             if (vertical != null) {
                Slide slide = new Slide();
                HashSet<string> mergedTags = new HashSet();
                mergedTags.AddRange(photo.tags);
                mergedTags.AddRange(vertical.tags);
                slide.tagArray.AddRange(mergedTags);
                slides.Add(slide);
            }

            return slides;
        }
    }
}