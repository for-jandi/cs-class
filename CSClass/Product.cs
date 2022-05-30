namespace CSClass
{
    internal class Product
    {
        public string name = "No name";
        public int price = 0;

        public override string ToString()
        {
            return this.name + " : " + this.price;
        }
    }
}