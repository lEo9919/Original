﻿using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        /**
         * Escreva a sua solução aqui
         * Code your solution here
         * Escriba su solución aquí
         */

        double area, n, raio;
        n = 3.14159;
        raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        area = n * (raio * raio);



        Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

    }

}