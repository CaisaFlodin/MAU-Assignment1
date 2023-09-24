using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BabyApp
{
    public class Baby
    {
        private string name = string.Empty;
        private int ageInMonths;
        private DateTime dateOfBirth;
        private DateTime currentDateTime = DateTime.Now;
        private bool isSleeping;
        private double weight;

        public void Start()
        {
            Console.WriteLine($"{currentDateTime:yyyy-MM-dd HH:mm:ss}");
            ReadAndSaveBabyData();
            CalculateDateOfBirth();
            DisplayDateOfBirth();
        }
        
        public void ReadAndSaveBabyData()
        {
            ReadName();
            ReadAge();
            ReadWeight();
        }

        public void ReadName()
        {
            Console.Write("What is the baby's name? ");
            name = Console.ReadLine();
        }

        public void ReadAge()
        {
            Console.Write("How many months old is the baby? ");
            ageInMonths = int.Parse(Console.ReadLine());
        }

        private void CalculateDateOfBirth()
        {
            dateOfBirth = DateTime.Now.AddMonths(-ageInMonths);
        }

        public void DisplayDateOfBirth()
        {
            Console.WriteLine($"{name} was born {dateOfBirth:yyyy-MM-dd}.");
        }

        public void ReadWeight()
        {
            Console.Write("Enter the baby's weight in kg: ");
            weight = double.Parse(Console.ReadLine());
        }

        public void Feed()
        {
            Console.WriteLine($"{name} is being fed.");
        }

        public void ChangeDiapers()
        {
            Console.WriteLine($"{name}'s diaper has been changed.");
        }

        public void Sleep()
        {
            if (!isSleeping)
            {
                Console.WriteLine($"{name} is now sleeping.");
                isSleeping = true;
            }
            else
            {
                Console.WriteLine($"{name} is already sleeping.");
            }
        }

        public void WakeUp()
        {
            if (isSleeping)
            {
                Console.WriteLine($"{name} has woken up.");
                isSleeping = false;
            }
            else
            {
                Console.WriteLine($"{name} is already awake.");
            }
        }

        public void DisplayWeight()
        {
            Console.WriteLine($"{name}'s current weight is {weight} kg.");
        }
    }
}
