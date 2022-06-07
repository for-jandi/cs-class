namespace CSClass
{
    internal class Product
    {
        internal static int counter = 0;
        public string name = "No name";
        public int price = 0;
        private int id = -1;

        public Product(string name, int price)
        {
            this.id = counter++;
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return "[" + this.id + "] " + this.name + " : " + this.price;
        }
    }
}