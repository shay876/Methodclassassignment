using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a class. In that class, create a void method that takes
//two integers as parameters. Have the method do a math operation on
//the first integer and display the second integer to the screen. 
namespace Methodclassassignment
{
    class MethodClass
    {
        public void calculateArea(int width, int height)
        {
            int result = width * height;
            Console.WriteLine("The area is " + result);
            Console.WriteLine("The width is " + width + " and the height is " + height);

        }
    }
}
