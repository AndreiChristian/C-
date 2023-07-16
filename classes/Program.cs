using System;

namespace ConsoleApp
{

    public class Program
    {

        struct Rectangle
        {
            public double length;
            public double width;
            public Rectangle(double l = 1, double w = 1)
            {
                length = l;
                width = w;
            }

            public double Area()
            {

                return width * length;

            }

        }

        static void Main(string[] args)
        {

            Animal animal = new Animal("dog", "bark");

            Console.WriteLine(animal.GetName());

            animal.SetName("doggo");

            Console.WriteLine(animal.GetName());


        }

    }

}