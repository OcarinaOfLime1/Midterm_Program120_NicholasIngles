// See https://aka.ms/new-console-template for more information

using System;
using System.Linq.Expressions;
using static System.Collections.Specialized.BitVector32;

Console.WriteLine("Nicholas Ingles - 2/19/2024\nProgramming 120 - F22 - Midterm Menu\n");
Console.WriteLine("1 - Personal Calculator");
Console.WriteLine("2 - Finance Calculator");
Console.WriteLine("3 - Geometry Calculator");
Console.WriteLine("4 - Cartesian Plane");
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
        Console.WriteLine("e - exit");
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

    }
    else if (select == "3")
    {
        Console.WriteLine("Geometry Calculator");
        Console.WriteLine("1 - Square");
        Console.WriteLine("2 - Rectangle");
        Console.WriteLine("3 - Circle");
        Console.WriteLine("4 - Right Circular Cone");
        Console.WriteLine("e - Exit");
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
            Console.WriteLine("Enter length: ");
            double rectanglelength = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            double rectanglewidth = double.Parse(Console.ReadLine());
            double rectangle = rectanglelength * rectanglewidth;
            Console.WriteLine("Area: " + rectangle);
        }
        else if (geoselect == "3")
        {
            Console.WriteLine("\nCircle");
            Console.WriteLine("Enter radius: ");
            double circleradius = double.Parse(Console.ReadLine());
            double circle = double.Pi * (circleradius * circleradius);
            Console.WriteLine("Area: " + circle);
        }
        else if (geoselect == "4")
        {
            Console.WriteLine("\nRight Circular Cone");
            Console.WriteLine("Enter height: ");
            double coneheight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter radius: ");
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
        Console.WriteLine("Enter X coordinate: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y coordinate: ");
        double y = double.Parse(Console.ReadLine());

    }
    else
    {
        Console.WriteLine("\nInvalid selection. Try again.");
    }
}
catch
{
    Console.WriteLine("\nAn error occured. Please try again.");
}