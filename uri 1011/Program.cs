﻿using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double raio = double.Parse(Console.ReadLine());
        double PI = 3.14159;
        double volume = (4.0 / 3) * PI * Math.Pow(raio, 3);



        Console.WriteLine($"VOLUME = {volume.ToString("F3", CultureInfo.InvariantCulture)}");

    }

}