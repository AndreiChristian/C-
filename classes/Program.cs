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


            Animal animal = new Animal(newName: "Dog", newSound: "Bark");
            Animal animal2 = new Animal(newName: "Dog", newSound: "Bark");

            animal2.MakeSound();

            animal2.sound = "Woof";

            Animal newanimal = animal2;

            newanimal.sound = "Meow";

            animal2.MakeSound();

            Rectangle rectangle1;
            rectangle1.length = 100;
            rectangle1.width = 200;

            double area = rectangle1.Area();

            Rectangle rectangle2 = rectangle1;

            rectangle2.width = 150;

            Console.WriteLine("The width of the rectangle is {0}", rectangle1.width);
            Console.WriteLine("The width of the rectangle is {0}", rectangle2.width);

            Console.WriteLine("The are of the rectangle is {0}", area);



        }

    }

}