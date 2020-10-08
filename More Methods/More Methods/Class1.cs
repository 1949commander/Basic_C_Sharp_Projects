using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Methods
{
    public class Class1
    {
        public static int PlusMethod(int x, int y) => x + y;

        public static double PlusMethod(double x, double y)
        {
            return x * y;
        }

        public static int PlusMethod(string x, int y)
        {
            return x - y;
        }
    }
}
