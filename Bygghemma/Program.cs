﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bygghemma
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                int y = i % 3;
                int j = i % 5;
              
                if (y == 0)
                {
                    Console.Write(" Bygg ");
                }
                if (j == 0)
                {
                    Console.Write(" Hemma ");
                }
                if (y == 0 & j == 0)
                {
                    Console.Write(" ByggHemma ");
                }
                if(y!=0 & j!=0)
                {
                    Console.Write("{0,-3}", i);
                }
            }
        }
    }
}
