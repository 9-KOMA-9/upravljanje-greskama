﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upravljanje_greskama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int godRod;
            bool kontrola = false;
            do {
                Console.WriteLine(" upisite svoju godinu rođenja: ");
                try
                {
                    godRod = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("roden si: " + godRod + " godine ");
                    kontrola = true;
                }
                catch (Exception greska)
                {
                    Console.WriteLine(greska.Message);
                }
            }while (kontrola == false);
            Console.ReadKey();
        }
    }
}
