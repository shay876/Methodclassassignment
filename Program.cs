using System;



namespace Methodclassassignment
{
    class Program
    {
        static void Main(string[] args)
        {   //In the Main() method of the console app, instantiate the class
            MethodClass newObject = new MethodClass();

            //Call the method in the class, passing in two numbers.
            Console.WriteLine("Enter a number");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            //Call the method in the class, specifying the parameters
            //by name.
            newObject.calculateArea(numOne, numTwo);
            //Call the method in the class, specifying the parameters
            //by name.
            newObject.calculateArea(width: 5, height: 7);

        }


    }

}
