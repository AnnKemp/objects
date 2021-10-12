using System;

namespace objects
{
    class Flower
    {
        string color = "red";
        static void Main(string[] args)
        {
            Flower myObj1 = new Flower();
            Flower myObj2 = new Flower();
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);
        }
    }
}
