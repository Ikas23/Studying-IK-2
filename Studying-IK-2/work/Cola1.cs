using System;

namespace studying_c_sharp_isaac_kaz
{
    public class Cola
    {
        public int NumOfBottle { get; set; }
        public string ColaName { get; set; }
        public int DateOfExpiration { get; set; }
        public double Price { get; set; }

        public Cola(int numOfBottle, string colaName, int dateOfExpiration, double price)
        {
            this.NumOfBottle = numOfBottle;
            this.ColaName = colaName;
            this.DateOfExpiration = dateOfExpiration;
            this.Price = price;
        }

        public Cola() : this(3, "Zero", 2025, 12)
        {
        }

        public void DisplayColaInfo()
        {
            Console.WriteLine($"Cola Name: {ColaName}, Number of Bottles: {NumOfBottle}, Expiration Date: {DateOfExpiration}");
        }
    }

    public class Box
    {
        public Cola[] Colas { get; set; }
        public int BottlePerBox { get; private set; }
        public double BoxPrice { get; private set; }

        public Box(int bottlePerBox, double boxPrice)
        {
            BottlePerBox = bottlePerBox;
            BoxPrice = boxPrice;
            Colas = new Cola[4];
        }

        public void DisplayBoxPrice(int numOfBox)
        {
            Console.WriteLine("The total price is: " + numOfBox * BoxPrice);
        }
    }

    public static class RunApp
    {
        public static void Discount(Cola cola)
        {
            cola.Price *= 0.9;
        }

        public static void Demo()
        {
            Cola cola1 = new Cola(10, "CocaCola", 2025, 12);
            Cola cola2 = new Cola(5, "Pepsi", 2024, 12);

            cola1.DisplayColaInfo();
            cola2.DisplayColaInfo();

            Box box = new Box(6, 20);
            box.DisplayBoxPrice(3);

            // Apply discount
            Discount(cola1);
            Discount(cola2);

            // Display prices after discount
            Console.WriteLine($"Discounted Price of {cola1.ColaName}: {cola1.Price}");
            Console.WriteLine($"Discounted Price of {cola2.ColaName}: {cola2.Price}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RunApp.Demo();
        }
    }
}
