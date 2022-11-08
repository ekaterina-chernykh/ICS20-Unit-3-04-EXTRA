// Created by: Ekaterina
// Created on: Oct 2022
//
// This program calculates volume of a sphere

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double fahrenheit;
        double celsius;

        Console.WriteLine("This program calculates fahrenheit to celsius");
        Console.WriteLine(" ");

        Console.WriteLine("Formula: (32°F − 32) × 5/9 = 0°C ");
        Console.WriteLine(" ");
        Console.Write("Enter fahrenheit: ");
        fahrenheit = Convert.ToDouble(Console.ReadLine());

        celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine(" ");
        Console.WriteLine("Celsius : " + celsius .ToString("0.00") + " °C");

        Console.WriteLine("\nDone.");
    }
}