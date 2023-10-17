namespace Task1
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public override bool Equals(object newProduct)
        {
            // Equals was not working as it should since references are not the same, so I had to 
            // overwrite Equals method.
            var product = newProduct as Product;
            if (product == null) return false;
            return this.Name == product.Name && this.Price == product.Price;
        }
    }
}
