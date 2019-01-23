using System;

namespace Confronto_library
{
    public static class Confronto
    {
        public static int Max(int n1, int n2)
        {
            int max = 0;

            if (n1 > n2)
            {
                max = n1;
            }
            else
            {
                max = n2;
            }

            return max;
        }


    }
}
