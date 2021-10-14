using System;

namespace objects
{
    //You can also create an object of a class and access it in another class. This is often used for better organization of classes (one class has all the fields and methods, while the other class holds the Main() method (code to be executed)).
    class Car
    {
        //Did you notice the public keyword? It is called an access modifier, which specifies that the color variable/field of Car is accessible for other classes as well, such as Program.
        // Class members
        public string color = "red"; // field
        public int maxSpeed;          // field
        public void fullThrottle()   // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.color = "blue";
            myObj.maxSpeed = 200;
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
            myObj.fullThrottle();
        }
    }
}
