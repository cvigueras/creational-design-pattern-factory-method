namespace Factory.Method.App
{
    class CandyClient
    {
        public void Main()
        {
            Console.WriteLine("Calling to Coke Candy.");
            Console.WriteLine(Client(new CokeCandyCreator()));
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Calling to Strawberry Candy.");
            Console.WriteLine(Client(new StrawberryCandyCreator()));
            Console.WriteLine("-------------------------------------------");
        }

        public string Client(Creator creator)
        {
            return creator.Produce();
        }
    }
}