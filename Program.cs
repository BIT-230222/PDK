
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LT4
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.OutputEncoding = System.Text.Encoding.UTF8; // set encoding UTF-8 cho Console
            Console.WriteLine("Nhập số nguyên dương m:");
            m = EditNumbers.nhapsonguyenduong();
            Console.WriteLine("Nhập số nguyên dương n:");
            n = EditNumbers.nhapsonguyenduong();
            float x;
            Console.WriteLine("Nhập số thực x:");
            x = EditNumbers.nhapsothuc4byte();
            Console.WriteLine("m=" + m.ToString() + ",n=" + n.ToString() + ",x=" + x.ToString());

            float[,] a;
            a = array_float_2d.nhapmangfloat2d(m, n);
            if (a == null)
                Console.WriteLine("Không đủ bộ nhớ!");
            else
            {
                array_float_2d.hienthimangfloat2d(a);
                array_float_2d.ghimang2dfloat_file_csv(a, "a2d.csv");
                float[,] b = array_float_2d.docmang2dfloat_file_csv("a2d.csv");
                Console.WriteLine("Mảng đọc từ .csv là:");
                array_float_2d.hienthimangfloat2d(b);
            }//else
        }
    }
}
