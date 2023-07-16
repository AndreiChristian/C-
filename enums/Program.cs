using System;
using System.Globalization;
using System.Text;

namespace ConsoleApi
{

    public class Program
    {

        static void PaintCar(CarColor cc = CarColor.Orange)
        {
            Console.WriteLine("The car was painted {0} with the code {1}", cc, (int)cc);
        }

        enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Yellow

        }

        static void Main(string[] args)
        {

            CarColor color1 = CarColor.Orange;
            CarColor color2 = CarColor.Orange;

            PaintCar();

            PaintCar(color1);
            PaintCar(color2);



        }

    }

}