﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro quijote = new Libro();
            Console.WriteLine(quijote.Alquilar());
            Console.ReadLine();
        }
    }
}
