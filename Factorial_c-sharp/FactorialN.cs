using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial
{
    class FactorialN : Program
    {
        int n;

        public FactorialN(int n)
        {
            this.n = n;
        }


        public void FactorialofN()
        {
            int f = 1;
            if (this.n == 0)
            {
                Console.WriteLine(0);
            }
            else if (this.n < 0)
            {
                Console.WriteLine("Enter correct number");
            }
            else
            {
                for (int i = 1; i <= this.n; i++)
                {
                    f = f * i;
                }
                Console.WriteLine(f);
            }

        }
    }
}