//static class

//We can not  make object of static class.
//we can not inherited of static class.
//if we use static keyword before the class name  that is consist of the static member and methods



using System;
namespace ConsoleAPP
{
    static class Product
    {
        public static int ProductId;
        public static string ProductName;
        public static int ProductPrice;

        static Product()
        {
            ProductId = 111;        // static Constructor
            ProductName = "Mobile";
            ProductPrice = 18000;
        }
        public static void GetProductDetails()
        {
            Console.WriteLine("ProductId={0}", ProductId);
            Console.WriteLine("ProductName={0}", ProductName);
            Console.WriteLine("ProductPrice={0}", ProductPrice);

        }
        public static void GetDiscount()
        {
            int D_Amount = ProductPrice / 10;
            Console.WriteLine("Your discount amount is: {0}", D_Amount);
            Console.WriteLine("Total Product Cost is:{0}", ProductPrice - D_Amount);
        }
        class Program
        {
            static void Main(string[] args)
            {
                Product.GetProductDetails();// Calling by Class of the methods
                Product.GetDiscount();
                Console.ReadLine();
            }
        }
    }
}
