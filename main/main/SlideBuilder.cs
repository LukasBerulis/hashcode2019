using System.Collections.Generic;

namespace main
{
    public class SlideBuilder
    {
        public static List<Slide> createSlides(Photo[] photos)
        {
            List<Slide> slides = new List<Slide>();
            Photo vertical = null;
            foreach (Photo photo in photos) {
                if (photo.orientation == 'H') {
                    Slide slide = new Slide();
                    slide.tagArray = photo.tags;
                    slide.indexes = new System.Tuple<int, int>(photo.index, -1);
                    slides.Add(slide);
                } else {
                    if (vertical != null) {
                        Slide slide = new Slide();
                        HashSet<string> mergedTags = new HashSet<string>();
                        foreach (var tag in photo.tags) {
                            mergedTags.Add(tag);
                        }
                        foreach (var tag in vertical.tags)
                        {
                            mergedTags.Add(tag);
                        }
                        slide.tagArray.AddRange(mergedTags);
                        slide.indexes = new System.Tuple<int, int>(photo.index, vertical.index);
                        slides.Add(slide);
                    } else {
                        vertical = photo;
                    }
                }
            }
            // if (vertical != null) {
            //    Slide slide = new Slide();
            //    slide.indexes = new System.Tuple<int, int>(vertical.index, -1);
            //    slide.tagArray = vertical.tags;
            //    slides.Add(slide);
            //}

            return slides;
        }
    }
}