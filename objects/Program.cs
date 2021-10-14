using System;

namespace objects
{
    // or create a class into another class ... seems without the word class at the start ...
    class Car
    {
        string model;
        string color;
        int year;
        public void fullThrottle()    // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
        // this class hasn't the word class in front of it
        static void Main(string[] args)
        {
            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;
            Ford.fullThrottle();

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
            /*
             * Why did we declare the method as public, and not static, like in the examples from the C# Methods Chapter? 
The reason is simple: a static method can be accessed without creating an object of the class, while public methods can only be accessed by objects.
             */
        }
    }
}
