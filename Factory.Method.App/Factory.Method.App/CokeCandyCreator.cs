namespace Factory.Method.App
{
    class CokeCandyCreator : Creator
    {
        public override IProduct FactoryMethod()
        {
            Console.WriteLine("Creating Coke Candy.");
            return new CokeCandyProduct();
        }
    }
}