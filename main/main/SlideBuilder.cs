using System.Collections.Generic;

namespace main
{
    public class SlideBuilder
    {
        public static List<Slide> createSlides(List<Photo> photos)
        {
            List<Slide> slides = new List<Slide>();
            Photo vertical = null;
            foreach (Photo photo in photos) {
                if (photo.orientation == 'H') {
                    Slide slide = new Slide();
                    slide.tagArray = photo.tags;
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
                        slides.Add(slide);
                    } else {
                        vertical = photo;
                    }
                }
            }
             if (vertical != null) {
                Slide slide = new Slide();
                slide.tagArray = vertical.tags;
                slides.Add(slide);
            }

            return slides;
        }
    }
}