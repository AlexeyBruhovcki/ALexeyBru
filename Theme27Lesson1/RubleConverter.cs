using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme27Lesson1
{
    internal class RubleConverter
    {
        public decimal ToDollars(decimal rubles)
        {
            return rubles * 0.011m;
        }
        public decimal ToEuros(decimal rubles)
        {
            return rubles * 0.01m;
        }
        public decimal ToZlotys(decimal rubles)
        {
            return rubles * 0.045m;
        }
        public decimal ToYuan(decimal rubles)
        {
            return rubles * 0.083m;
        }
        public decimal ToRupes(decimal rubles)
        {
            return rubles * 0.95m;
        }
    }
}
