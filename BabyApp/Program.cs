namespace BabyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Baby myBaby = new Baby();

            // Read baby's information from the console
            myBaby.Start();
            myBaby.Feed();
            myBaby.ChangeDiapers();
            myBaby.Sleep();
            myBaby.WakeUp();
            myBaby.DisplayWeight();
        }
    }
}