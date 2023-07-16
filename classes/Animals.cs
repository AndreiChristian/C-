using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{

    internal class Animal
    {
        private string name;
        public string sound;
        static int numOfAnimals = 0;

        public Animal(string newName = "No Name", string newSound = "No sound")
        {
            this.name = newName;
            this.sound = newSound;

            numOfAnimals++;
        }

        public void MakeSound()
        {

            Console.WriteLine("{0} says {1}", this.name, this.sound);

        }

        static int GetNumAnimal()
        {

            return numOfAnimals;

        }

        public void SetName(string name)
        {

            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
            else
            {

                this.name = "No name";
                Console.WriteLine("The name must not have any digit");
            }

        }

        public string GetName()
        {

            return this.name;

        }


    }
}