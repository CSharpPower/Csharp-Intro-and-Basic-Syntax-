﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string d = Console.ReadLine();
            Console.Write(a = a.PadLeft(4, '0'));
            Console.Write(" ");
            Console.Write(b = b.PadLeft(4, '0'));
            Console.Write(" ");
            Console.Write(c = c.PadLeft(4, '0'));
            Console.Write(" ");
            Console.Write(d = d.PadLeft(4, '0'));
        }
    }
}
