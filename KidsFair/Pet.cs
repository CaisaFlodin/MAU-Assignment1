using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsFair
{
    public class Pet
    {
        //Initialize instance variables (fields) with their default value
        private string name;
        private int age;
        private bool isFemale;

        //Method for starting program
        public void Start()
        {
            ReadAndSavePetData();
            DisplayPetInfo();
        }

        public void ReadAndSavePetData()
        {
            ReadName();
            ReadAge();
            ReadGender();
        }

        private void ReadName()
        {
            Console.Write("What's the name of your pet? ");
            name = Console.ReadLine();

        }
        
        private void ReadAge()
        {
            Console.Write($"What's {name}'s age? ");
            age = int.Parse(Console.ReadLine());
        }

        private void ReadGender()
        {
            Console.Write("Is your pet a female? (y/n)? ");

            string strGender = Console.ReadLine();
            strGender = strGender.Trim();
            char response = strGender[0];

            if (response == 'y' || response == 'Y')
            {
                isFemale = true;
            }
            else
            {
                isFemale = false;
            }
        }

        public void DisplayPetInfo()
        {
            string petInfo = $"Name: {name} Age: {age}";
            string gender;

            if (isFemale) 
            {
                gender = "girl";
            } else
            {
                gender = "boy";
            }


            Console.WriteLine();
            Console.WriteLine(petInfo);
            Console.WriteLine($"{name} is a good {gender}!");
            Console.WriteLine();
        }
    }
}