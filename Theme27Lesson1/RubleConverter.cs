using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme27Lesson1
{
    internal class RubleConverter
    {
        public static decimal ToDollars(decimal rubles)
        {
            return rubles * 0.011m;
        }
        public static decimal ToEuros(decimal rubles)
        {
            return rubles * 0.01m;
        }
        public static decimal ToZlotys(decimal rubles)
        {
            return rubles * 0.045m;
        }
        public static decimal ToYuan(decimal rubles)
        {
            return rubles * 0.083m;
        }
        public static decimal ToRupes(decimal rubles)
        {
            return rubles * 0.95m;
        }
    }
}
