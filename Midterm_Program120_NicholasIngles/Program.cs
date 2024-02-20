// See https://aka.ms/new-console-template for more information

using System;
using System.IO.Pipes;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using static System.Collections.Specialized.BitVector32;

bool calculatoractive = true;//Condition to keep program active and looping
Console.Write("Nicholas Ingles - 2/19/2024");
while (calculatoractive)//Loops program when it reaches the end
{           //Selection menu
    Console.WriteLine("\nProgramming 120 - F22 - Midterm Menu");
    Console.WriteLine("1 - Personal Calculator");
    Console.WriteLine("2 - Finance Calculator");
    Console.WriteLine("3 - Geometry Calculator");
    Console.WriteLine("4 - Cartesian Plane");
    Console.WriteLine("e - Exit");
    Console.Write("Select mode: ");
    string select = Console.ReadLine();//User selects mode

    try//Try block containing all code to catch all errors
    {
        if (select == "1")//User selects mode 1
        {           //Personal calculator mode
            Console.WriteLine("\nPersonal Calculator");
            Console.Write("Enter first number: ");
            double first = double.Parse(Console.ReadLine());//User input
                    
            Console.WriteLine("+ - Add");
            Console.WriteLine("- - Subtract");
            Console.WriteLine("* - Multiply");
            Console.WriteLine("/ - Divide");
            Console.WriteLine("e - Exit");
            Console.Write("Select operation: ");
            string operation = Console.ReadLine();//User selects operation

            if (operation == "+")//User selects addition
            {
                Console.Write("\n" + first + " " + operation + " ");
                double second = double.Parse(Console.ReadLine());
                double result = first + second;//Addition calculation
                Console.WriteLine("Result: " + result);//Math output
            }
            else if (operation == "-")//User selects subtraction
            {
                Console.Write("\n" + first + " " + operation + " ");
                double second = double.Parse(Console.ReadLine());
                double result = first - second;//Subtraction calculation
                Console.WriteLine("Result: " + result);//Math output
            }
            else if (operation == "*")//User selects multiplication
            {
                Console.Write("\n" + first + " " + operation + " ");
                double second = double.Parse(Console.ReadLine());
                double result = first * second;//Multiplication calculation
                Console.WriteLine("Result: " + result);//Math output
            }
            else if (operation == "/")//User selects division
            {
                Console.Write("\n" + first + " " + operation + " ");
                double second = double.Parse(Console.ReadLine());
                double result = first / second;//Division calculation
                Console.WriteLine("Result: " + result);//Math output
            }
            else if (operation == "e")//User selects Exit
            {
                //Loops back to main menu
            }
            else
            {
                Console.WriteLine("\nInvalid selection. Try again.");//For when user does not choose an available selection
            }
        }
        else if (select == "2")//User selects mode 2
        {
            Console.WriteLine("\nFinance Calculator");
            Console.WriteLine("1 - Net Income");
            Console.WriteLine("2 - Rule of 72");
            Console.WriteLine("3 - Net Worth");
            Console.WriteLine("e - Exit");
            Console.Write("Select option: ");
            string finselect = Console.ReadLine();//User selects finance option

            if (finselect == "1")//User selects option 1
            {
                Console.WriteLine("\nNet Income");
                Console.Write("Enter total revenue: ");
                double revenue = double.Parse(Console.ReadLine());//User input
                Console.Write("Enter total costs: ");
                double costs = double.Parse(Console.ReadLine());//User input
                double netincome = revenue - costs;//Net income equation and calculation
                Console.WriteLine("Net income: " + netincome);//Math output
            }
            else if (finselect == "2")//User selects option 2
            {
                Console.WriteLine("\nRule of 72");
                Console.Write("Enter interest rate %: ");
                double interest = double.Parse(Console.ReadLine());//User input
                double years = Math.Round(72 / interest, 1);//Rule of 72 equation and calulation, then rounds number to one decimal
                Console.WriteLine("With an interest of " + interest + "% your money will double in " + years + " years.");//Math output in statement
            }
            else if (finselect == "3")//User selects option 3
            {
                Console.WriteLine("\nNet Worth");
                Console.Write("Enter your total assets: ");
                double assets = double.Parse(Console.ReadLine());//User input
                Console.Write("Enter your total liabilities: ");
                double liabilities = double.Parse(Console.ReadLine());//User input
                double networth = assets - liabilities;//Net worth equation and calculation
                Console.WriteLine("Net worth: " + networth);//Math output
            }
            else if (finselect == "e")//User selects Exit
            {
                //Loops back to main menu
            }
            else
            {
                Console.WriteLine("\nInvalid selection. Try again.");//For when user does not choose an available selection
            }
        }
        else if (select == "3")//User selects mode 3
        {
            Console.WriteLine("\nGeometry Calculator");
            Console.WriteLine("1 - Square");
            Console.WriteLine("2 - Rectangle");
            Console.WriteLine("3 - Circle");
            Console.WriteLine("4 - Right Circular Cone");
            Console.WriteLine("e - Exit");
            Console.Write("Select shape: ");
            string geoselect = Console.ReadLine();//User selects shape

            if (geoselect == "1")//User selects square
            {
                Console.WriteLine("\nSquare");
                Console.Write("\nEnter side length: ");
                double squarelength = double.Parse(Console.ReadLine());//User input
                double square = squarelength * squarelength;//Area calculation
                Console.WriteLine("Area: " + square);//Math output
            }
            else if (geoselect == "2")//User selects rectangle
            {
                Console.WriteLine("\nRectangle");
                Console.Write("Enter length: ");
                double rectanglelength = double.Parse(Console.ReadLine());//User input
                Console.Write("Enter width: ");
                double rectanglewidth = double.Parse(Console.ReadLine());//User input
                double rectangle = rectanglelength * rectanglewidth;//Area calculation
                Console.WriteLine("Area: " + rectangle);//Math output
            }
            else if (geoselect == "3")//User selects circle
            {
                Console.WriteLine("\nCircle");
                Console.Write("Enter radius: ");
                double circleradius = double.Parse(Console.ReadLine());//User input
                double circle = double.Pi * (circleradius * circleradius);//Area calculation
                Console.WriteLine("Area: " + circle);//Math output
            }
            else if (geoselect == "4")//User selects cone
            {
                Console.WriteLine("\nRight Circular Cone");
                Console.Write("Enter height: ");
                double coneheight = double.Parse(Console.ReadLine());//User input
                Console.Write("Enter radius: ");
                double coneradius = double.Parse(Console.ReadLine());//User input
                double cone = (double.Pi * (coneradius * coneradius) * coneheight) / 3;//Volume calculation
                Console.WriteLine("Volume: " + cone);//Math output
            }
            else if (geoselect == "e")//User selects Exit
            {
                //Loops back to main menu
            }
            else
            {
                Console.WriteLine("\nInvalid selection. Try again.");//For when user does not choose an available selection
            }
        }
        else if (select == "4")//User selects mode 4
        {
            Console.WriteLine("\nCartesian Plane");
            Console.Write("Enter X coordinate: ");
            double x = double.Parse(Console.ReadLine());//User input
            Console.Write("Enter Y coordinate: ");
            double y = double.Parse(Console.ReadLine());//User input
            string coordinates = "(" + x + "," + y + ")";//More convenient when typing the user inputed coordinates
            bool xzero = x == 0;
            bool yzero = y == 0;
            bool xpositive = x > 0;
            bool ypositive = y > 0;

            if (xzero && yzero)//Coordinates (0,0)
            {
                Console.WriteLine("Your coordinates " + coordinates + " fall on the point of origin.");
            }
            else if (xzero && !yzero)//X == 0
            {
                Console.WriteLine("Your coordinates " + coordinates + " fall on the Y axis.");
            }
            else if (!xzero && yzero)//Y == 0
            {
                Console.WriteLine("Your coordinates " + coordinates + " fall on the X axis.");
            }
            else if (xpositive && ypositive)//Positive X and positive Y
            {
                Console.WriteLine("Your coordinates " + coordinates + " fall in quadrant I.");
            }
            else if (!xpositive && ypositive)//Negative X and positive Y
            {
                Console.WriteLine("Your coordinates " + coordinates + " fall in quadrant II.");
            }
            else if (!xpositive && !ypositive)//Negative X and negative Y
            {
                Console.WriteLine("Your coordinates " + coordinates + " fall in quadrant III.");
            }
            else if (xpositive && !ypositive)//Positive X and negative Y
            {
                Console.WriteLine("Your coordinates " + coordinates + " fall in quadrant IV.");
            }
            else
            {
                Console.WriteLine("\nAn unexpected error has occurred. Please try again.");//Just in case something goes wrong, though all possible combinations of booleans are covered here
            }
        }
        else if (select == "e")//User selects Exit
        {
            Console.WriteLine("\nExited.");
            calculatoractive = false;//Turns off condition to keep program active
        }
        else
        {
            Console.WriteLine("\nInvalid selection. Try again.");//For when user does not choose an available selection
        }
    }
    catch
    {
        Console.WriteLine("\nAn error occurred. Please try again.");//Error catch for entirety of code;for when user inputs the wrong format
    }
}
return;//Ends program when Exit is selected from main menu