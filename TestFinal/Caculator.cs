using System;
using System.Collections.Generic;
using System.Text;

namespace TestFinal
{
    public class Caculator
    {
        public int TongSoLe(int n)
        {
            if (n < 1) return 0;

            int tong = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    tong += i;
                }
            }

            return tong;
        }
    }
}
