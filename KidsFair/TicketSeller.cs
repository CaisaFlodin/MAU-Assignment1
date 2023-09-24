using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsFair
{
    public class TicketSeller
    {
        private string name = string.Empty;
        private double price = 99;
        private int numOfAdults;
        private int numOfChildren;
        private double amountToPay;
        private string formattedAmount = string.Empty;

        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to KIDS' FAIR!");
            Console.WriteLine("Children always get a 75% discount!");
            Console.WriteLine();
            ReadAndSaveTicketData();
            CalculateAmountToPay();
            DisplayReceipt();

        }
        public void ReadAndSaveTicketData()
        {
            ReadName();
            ReadAdults();
            ReadChildren();
        }

        private void ReadName() 
        {
            Console.WriteLine("Your name please:");
            name = Console.ReadLine();
        }

        private void ReadAdults() 
        {
            Console.WriteLine("Number of adults:");
            numOfAdults = int.Parse(Console.ReadLine());
        }

        private void ReadChildren()
        {
            Console.WriteLine("Number of children:");
            numOfChildren = int.Parse(Console.ReadLine());
        }

        private void CalculateAmountToPay()
        {
            double childrenPrice = (numOfChildren * (price * 0.25));
            double adultPrice = (numOfAdults * price);
            amountToPay = childrenPrice + adultPrice;
            //Convert the total amount to a formatted string with two decimal places
            formattedAmount = amountToPay.ToString("0.00");
        }

        private void DisplayReceipt()
        {
            Console.WriteLine();
            Console.WriteLine(" +++ Your receipt +++");
            Console.WriteLine($" +++ Amount to pay = {formattedAmount}");
            Console.WriteLine();
            Console.WriteLine($" +++ Thank you {name} and please come back! +++");
        }
        
    }
}
