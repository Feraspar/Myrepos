﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._2_1_
{
    class Program
    {
        public static int A = 0;
        public static int B = 0;
        public static int res = 0;


        static void Main(string[] args)
        {

        }
        public static void sub()
        {
            res = A - B;
            Console.WriteLine(Environment.NewLine + "A - B = " + res);
            
        }
        public static void mult()
        {
            res = A * B;
            Console.WriteLine(Environment.NewLine + "A * B = " + res);
        }
    }
}
