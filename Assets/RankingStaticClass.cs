using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    public static class RankingStaticClass
    {
        public static Dictionary<string, double> RankingDictionary = new Dictionary<string, double>();
        public static double CurrentPoints { get; set; }
    }
}
