using FactoryDesignPattern.Models;

namespace FactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductFactory factory = new ProductFactory(); 
            Product TVObj = factory.CreateProductObject("electronics", "Hisense 43'", 200);

            Clothing shoeObj = new Clothing("Nike", 60);

            Console.WriteLine("Hello, World!");
        }
    }
}
