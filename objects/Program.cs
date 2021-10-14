using System;

namespace objects
{
    // or create a class into another class ... seems without the word class at the start ...
    class Car
    {
        string model;
        string color;
        int year;
        // this class hasn't the word class in front of it
        static void Main(string[] args)
        {
            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
        }
    }
}
