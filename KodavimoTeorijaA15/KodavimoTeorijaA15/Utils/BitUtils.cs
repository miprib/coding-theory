using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodavimoTeorijaA15.Utils
{
    static class BitUtils
    {
        /// <summary>
        /// Patikrina ar simbolis yra bitas.
        /// </summary>
        /// <param name="c">Tikrinamas simbolis</param>
        /// <returns>Ar "c" yra bitas</returns>
        public static bool IsBit(char c)
        {
            if (c == '1' || c == '0')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Atlieka sudėtį moduliu 2
        /// </summary>
        /// <param name="a">Pirmas bitas</param>
        /// <param name="b">Antras bitas</param>
        /// <returns>"a" + "b" moduliu 2</returns>
        public static char AddMod2(char a, char b)
        {
            if ((a == '1' && b == '1') || (a == '0' && b == '0'))
            {
                return '0';
            }
            else
            {
                return '1';
            }
        }
    }
}
