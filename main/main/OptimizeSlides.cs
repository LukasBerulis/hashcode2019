using System.Collections.Generic;

namespace main
{
    public class SlideOptimizer
    {
        public static LinkedList<Slide> optimize(List<Slide> slides)
        {
            LinkedList<Slide> optimized = new LinkedList<Slide>();
            for(int i=0; i<slides.Count-1; i++) {
                int max = 0;
                int targetSlide = i+1;
                for(int j=i+1; j<slides.Count; j++) {
                    int score = ResultCalcUtil.GetScore(slides[i].tagArray, slides[j].tagArray);
                    if (score > max) {
                        max = score;
                        targetSlide = j;
                    }
                }
                optimized.AddLast(slides[i]);
                optimized.AddLast(slides[targetSlide]);
            }
            return optimized;
        }
    }
}