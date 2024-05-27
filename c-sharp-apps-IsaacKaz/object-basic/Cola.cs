using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.object_basic
{
    public class Cola
    {
        public string ColaName { get; set; }
        public string DateOfExpiration { get; set; }
        public int Price { get; set; }

        public Cola(int price, string colaName, string dateOfExpiration)
        {
            this.ColaName = colaName;
            this.DateOfExpiration = dateOfExpiration;
            this.Price = price;
        }

        public void Display()
        {
            Console.WriteLine($"Price = {Price}, Name = {ColaName}, DateOfExpiration = {DateOfExpiration}");
        }
    }

    public class Box
    {
        Cola[] C = new Cola[6];

        public int BottlePerBox { get; set; }
        public int BoxPrice { get; set; }
        public int NumOfBox { get; set; }

        public Box(int bottlePerBox, int boxPrice)
        {
            this.BottlePerBox = bottlePerBox;
            this.BoxPrice = boxPrice;

            
            for (int i = 0; i < C.Length; i++)
            {
                C[i] = new Cola(10, "coca cola", "23.4.25");
            }
        }

        public void BoxesPrice(int numOfBox)
        {
            Console.WriteLine("The price is: " + numOfBox * BoxPrice);
        }
    }

    public class RunApp
    {
        public static void Demo()
        {
            Cola cola = new Cola(10, "coca cola", "23.4.25");
            cola.Display();

            Box box = new Box(6, 60);
            box.BoxesPrice(5);
        }
    }


}

