using System;
using System.Linq;

namespace TripleTrouble
{
    public class Kata
    {
        public static int TripleDouble(long num1, long num2)
        {
            return "0123456789".ToList().Any(x => num1.ToString().Contains(new String(x, 3)) && num2.ToString().Contains(new String(x, 2))) ? 1 : 0;
        }
    }    
}
