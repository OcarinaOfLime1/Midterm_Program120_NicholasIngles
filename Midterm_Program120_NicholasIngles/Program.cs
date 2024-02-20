// See https://aka.ms/new-console-template for more information

using System;
using System.IO.Pipes;
using System.Linq.Expressions;
using static System.Collections.Specialized.BitVector32;

bool calculatoractive = true;
Console.Write("Nicholas Ingles - 2/19/2024");
while (calculatoractive)
{
    Console.WriteLine("\nProgramming 120 - F22 - Midterm Menu");
    Console.WriteLine("1 - Personal Calculator");
    Console.WriteLine("2 - Finance Calculator");
    Console.WriteLine("3 - Geometry Calculator");
    Console.WriteLine("4 - Cartesian Plane");
    Console.WriteLine("e - Exit");
    Console.Write("Select mode: ");
    string select = Console.ReadLine();

    try
    {
        if (select == "1")
        {
            Console.WriteLine("\nPersonal Calculator");
            Console.Write("Enter first number: ");
            double first = double.Parse(Console.ReadLine());

            Console.WriteLine("\n+ - Add");
            Console.WriteLine("- - Subtract");
            Console.WriteLine("* - Multiply");
            Console.WriteLine("/ - Divide");
            Console.WriteLine("e - Exit");
            Console.Write("Select operation: ");
            string operation = Console.ReadLine();

            if (operation == "+")
            {
                Console.Write("\n" + first + " " + operation + " ");
                double second = double.Parse(Console.ReadLine());
                double result = first + second;
                Console.WriteLine("Result: " + result);
            }
            else if (operation == "-")
            {
                Console.Write("\n" + first + " " + operation + " ");
                double second = double.Parse(Console.ReadLine());
                double result = first - second;
                Console.WriteLine("Result: " + result);
            }
            else if (operation == "*")
            {
                Console.Write("\n" + first + " " + operation + " ");
                double second = double.Parse(Console.ReadLine());
                double result = first * second;
                Console.WriteLine("Result: " + result);
            }
            else if (operation == "*")
            {
                Console.Write("\n" + first + " " + operation + " ");
                double second = double.Parse(Console.ReadLine());
                double result = first * second;
                Console.WriteLine("Result: " + result);
            }
            else if (operation == "e")
            {
                Console.WriteLine("\nExited.");
            }
            else
            {
                Console.WriteLine("\nInvalid selection. Try again.");
            }
        }
        else if (select == "2")
        {
            Console.WriteLine("\nFinance Calculator");
            Console.WriteLine("1 - Net Income");
            Console.WriteLine("2 - Rule of 72");
            Console.WriteLine("3 - Net Worth");
            Console.WriteLine("e - Exit");
            Console.Write("Select calculator: ");
            string finselect = Console.ReadLine();

            if (finselect == "1")
            {
                Console.WriteLine("\nNet Income");
                Console.Write("Enter total revenue: ");
                double revenue = double.Parse(Console.ReadLine());
                Console.Write("Enter total costs: ");
                double costs = double.Parse(Console.ReadLine());
                double netincome = revenue - costs;
                Console.WriteLine("Net income: " + netincome);
            }
            else if (finselect == "2")
            {
                Console.WriteLine("\nRule of 72");
                Console.Write("Enter interest rate %: ");
                double interest = double.Parse(Console.ReadLine());
                double years = Math.Round(72 / interest, 1);
                Console.WriteLine("With an interest of " + interest + "% your money will double in " + years + " years.");
            }
            else if (finselect == "3")
            {
                Console.WriteLine("\nNet Worth");
                Console.Write("Enter your total assets: ");
                double assets = double.Parse(Console.ReadLine());
                Console.Write("Enter your total liabilities: ");
                double liabilities = double.Parse(Console.ReadLine());
                double networth = assets - liabilities;
                Console.WriteLine("Net worth: " + networth);
            }
            else if (finselect == "e")
            {
                Console.WriteLine("\nExited.");
            }
            else
            {
                Console.WriteLine("\nInvalid selection. Try again.");
            }
        }
        else if (select == "3")
        {
            Console.WriteLine("\nGeometry Calculator");
            Console.WriteLine("1 - Square");
            Console.WriteLine("2 - Rectangle");
            Console.WriteLine("3 - Circle");
            Console.WriteLine("4 - Right Circular Cone");
            Console.WriteLine("e - Exit");
            Console.Write("Select shape: ");
            string geoselect = Console.ReadLine();

            if (geoselect == "1")
            {
                Console.WriteLine("\nSquare");
                Console.Write("\nEnter side length: ");
                double squarelength = double.Parse(Console.ReadLine());
                double square = squarelength * squarelength;
                Console.WriteLine("Area: " + square);
            }
            else if (geoselect == "2")
            {
                Console.WriteLine("\nRectangle");
                Console.Write("Enter length: ");
                double rectanglelength = double.Parse(Console.ReadLine());
                Console.Write("Enter width: ");
                double rectanglewidth = double.Parse(Console.ReadLine());
                double rectangle = rectanglelength * rectanglewidth;
                Console.WriteLine("Area: " + rectangle);
            }
            else if (geoselect == "3")
            {
                Console.WriteLine("\nCircle");
                Console.Write("Enter radius: ");
                double circleradius = double.Parse(Console.ReadLine());
                double circle = double.Pi * (circleradius * circleradius);
                Console.WriteLine("Area: " + circle);
            }
            else if (geoselect == "4")
            {
                Console.WriteLine("\nRight Circular Cone");
                Console.Write("Enter height: ");
                double coneheight = double.Parse(Console.ReadLine());
                Console.Write("Enter radius: ");
                double coneradius = double.Parse(Console.ReadLine());
                double cone = (double.Pi * (coneradius * coneradius) * coneheight) / 3;
                Console.WriteLine("Area: " + cone);
            }
            else if (geoselect == "e")
            {
                Console.WriteLine("\nExited.");
            }
            else
            {
                Console.WriteLine("\nInvalid selection. Try again.");
            }
        }
        else if (select == "4")
        {
            Console.WriteLine("\nCartesian Plane");
            Console.Write("Enter X coordinate: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter Y coordinate: ");
            double y = double.Parse(Console.ReadLine());
            string coordinates = "(" + x + "," + y + ")";
            bool xzero = x == 0;
            bool yzero = y == 0;
            bool xpositive = x > 0;
            bool ypositive = y > 0;

            if (xzero && yzero)
            {
                Console.WriteLine("Your coordinates " + coordinates + " fall on the point of origin.");
            }
            else if (xzero && !yzero)
            {
                Console.WriteLine("Your coordinates " + coordinates + " fall on the Y axis.");
            }
            else if (!xzero && yzero)
            {
                Console.WriteLine("Your coordinates " + coordinates + " fall on the X axis.");
            }
            else if (xpositive && ypositive)
            {
                Console.WriteLine("Your coordinates " + coordinates + " fall in quadrant I.");
            }
            else if (!xpositive && ypositive)
            {
                Console.WriteLine("Your coordinates " + coordinates + " fall in quadrant II.");
            }
            else if (!xpositive && !ypositive)
            {
                Console.WriteLine("Your coordinates " + coordinates + " fall in quadrant III.");
            }
            else if (xpositive && !ypositive)
            {
                Console.WriteLine("Your coordinates " + coordinates + " fall in quadrant IV.");
            }
            else
            {
                Console.WriteLine("\nAn unexpected error has occurred. Please try again.");
            }
        }
        else if (select == "e")
        {
            Console.WriteLine("\nExited");
            calculatoractive = false;
        }
        else
        {
            Console.WriteLine("\nInvalid selection. Try again.");
        }
    }
    catch
    {
        Console.WriteLine("\nAn error occurred. Please try again.");
    }
}
return;