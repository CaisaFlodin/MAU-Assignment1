namespace KidsFair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrepareConsoleLook();

            //Create a pet object
            Pet petObj = new Pet();
            //Call a method of the object to start
            petObj.Start();

            Console.WriteLine("Press Enter to start the next part!");
            Console.ReadLine();

            //Start Album
            Album album = new Album();
            album.Start();

            Console.WriteLine("Press Enter to start the next part!");
            Console.ReadLine();

            //Start TicketSeller
            TicketSeller ticketSeller = new TicketSeller();
            ticketSeller.Start();

            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }

        static void PrepareConsoleLook()
        {
            //Arrange the Console Window
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear(); //Paint the background with above color
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "KIDS' FAIR";
        }
    }
}