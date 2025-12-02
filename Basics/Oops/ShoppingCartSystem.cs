using System;


namespace ObjectOrientedProgramming.problems
{
    class Product
    {
        public static double discount = 10;
        public readonly string productId;
        public string productName;
        public double price;
        public int quantity;

        public Product(string productId, string productName, double price, int quantity)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
        }

        public static void UpdateDiscount(double newDiscount)
        {
            discount = newDiscount;
            Console.WriteLine("Discount updated to: " + discount + "%");
        }
        public void DisplayProductInfo()
        {
            Console.WriteLine("Product ID: " + productId);
            Console.WriteLine("Product Name: " + productName);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Quantity: " + quantity);
        }

    }
    internal class ShoppingCartSystem
    {
        public static void Main(string[] args)
        {
            Product product1 =new Product("P001", "Laptop", 1200.00, 2);
            Product product2 =new Product("P002", "Smartphone", 800.00, 1);

            Product.UpdateDiscount(15);
            

            if (product1 is Product)
            {
                product1.DisplayProductInfo();
            }
            if (product2 is Product)
            {
                product2.DisplayProductInfo();
            }

        }
    }
}
