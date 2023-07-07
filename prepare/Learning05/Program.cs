using System;

class Program
{
    static void Main(string[] args)
    {
        // // Test the Square class
        // // Create a Square instance, 
        // Square sqr = new Square("Blue", 5);

        // // Test other classes
        // Rectangle rect = new Rectangle("Red", 3, 4);
        // Circle crcl = new Circle("Yellow", 3);

        // //call the GetColor() and GetArea() methods and make sure they return the values you expect.
        // string color = sqr.GetColor();
        // double area = sqr.GetArea();

        // string colorRect = rect.GetColor();
        // double areaRect = rect.GetArea();

        // string colorCrcl = crcl.GetColor();
        // double areaCrcl = crcl.GetArea();

        // Console.WriteLine($"Square: {color} {area}; Rectangle: {colorRect} {areaRect}; Circle: {colorCrcl} {areaCrcl}");

        // create a list to hold shapes (Hint: The data type should be List<Shape>)
        List<Shape> list = new List<Shape>();

        // Add a square, rectangle, and circle to this list.
        Square sqr = new Square("Blue", 5);
        list.Add(sqr);

        Rectangle rect = new Rectangle("Red", 3, 4);
        list.Add(rect);

        Circle crcl = new Circle("Yellow", 3);
        list.Add(crcl);

        // Iterate through the list of shapes. For each one, call and display the GetColor() and GetArea() methods.
        foreach (Shape item in list)
        {
            string color = item.GetColor();
            double area = item.GetArea();

            Console.WriteLine($"Color: {color}. Area: {area}.");
        }
    }
}