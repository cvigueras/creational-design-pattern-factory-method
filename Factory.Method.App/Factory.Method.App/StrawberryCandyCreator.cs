namespace Factory.Method.App
{
    class StrawberryCandyCreator : Creator
    {
        public override IProduct FactoryMethod()
        {
            Console.WriteLine("Creating Strawberry Candy.");
            return new StrawberryCandyProduct();
        }
    }
}