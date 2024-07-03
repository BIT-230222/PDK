using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LT4
{
    class EditNumbers
    {
        public static int nhapsonguyenduong()
        {
            int n = 0;
            while (true)
            {
                try
                {
                    string sz;
                    sz = Console.ReadLine();
                    n = int.Parse(sz);
                    if (n > 0)
                        break;
                    else
                        Console.Beep();
                }
                catch
                {
                    Console.Beep();

                }
            }//while
            return n;
        }// nhapsonguyenduong

        public static float nhapsothuc4byte()
        {
            float x = 0.0F;
            while (true)
            {
                try
                {
                    string sz;
                    sz = Console.ReadLine();
                    x = float.Parse(sz);
                    break;
                }
                catch
                {
                    Console.Beep();
                }
            }//while
            return x;
        }// nhapsothuc4byte
    }
}
