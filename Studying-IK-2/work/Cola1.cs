using System;

namespace Studying_IK_2
{
    public class Cola
    {
        public int NumOfBottle { get; set; }
        public string ColaName { get; set; }
        public int DateOfExpiration { get; set; }

        public Cola(int numOfBottle, string colaName, int dateOfExpiration)
        {
            NumOfBottle = numOfBottle;
            ColaName = colaName;
            DateOfExpiration = dateOfExpiration;
        }

        public void DisplayColaInfo()
        {
            Console.WriteLine($"Cola Name: {ColaName}, Number of Bottles: {NumOfBottle}, Expiration Date: {DateOfExpiration}");
        }
    }

    public class Box
    {
        public Cola[] Colas { get; private set; }
        public int BottlePerBox { get; set; }
        public int BoxPrice { get; set; }

        public Box(int bottlePerBox, int boxPrice)
        {
            BottlePerBox = bottlePerBox;
            BoxPrice = boxPrice;
            Colas = new Cola[4];
        }

        public void BoxesPrice(int numOfBox)
        {
            Console.WriteLine("The price is: " + numOfBox * BoxPrice);
        }
    }

    public static class RunApp
    {
        public static void Demo()
        {
            Cola cola1 = new Cola(10, "CocaCola", 2025);
            Cola cola2 = new Cola(5, "Pepsi", 2024);

            cola1.DisplayColaInfo();
            cola2.DisplayColaInfo();

            Box box = new Box(6, 20);
            box.BoxesPrice(3);
        }
    }
}
