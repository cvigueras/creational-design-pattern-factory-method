namespace Factory.Method.App
{
    abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string Produce()
        {
            var product = FactoryMethod();
            return product.ProduceCandy();
        }
    }
}