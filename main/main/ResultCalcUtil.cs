using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class ResultCalcUtil
    {
        public static int GetScore(ICollection<string> tags1, ICollection<string> tags2)
        {
            int factor1 = GetCommonTags(tags1, tags2);
            int factor2 = GetDifferentTags(tags1, tags2);
            int factor3 = GetDifferentTags(tags2, tags1);
            int min = Math.Min(factor1, factor2);
            min = Math.Min(min, factor3);
            return min;
        }

        public static int GetCommonTags(ICollection<string> tags1, ICollection<string> tags2)
        {
            return tags1.Intersect(tags2).Count();
        }

        public static int GetDifferentTags(ICollection<string> tags1, ICollection<string> tags2)
        {
            return tags1.Except(tags2).Count();
        }
    }
}
