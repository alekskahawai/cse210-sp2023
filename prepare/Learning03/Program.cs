using System;

class Program
{
    static void Main(string[] args)
    {
        // // verify that you can create fractions using all three of these constructors. 
        // // create an instance for 1/1 (using the first constructor), 
        // Fraction f1 = new Fraction();

        // // 6/1 (using the second constructor)
        // Fraction f2 = new Fraction(6);

        // // 6/7 (using the third constructor).
        // Fraction f3 = new Fraction(6, 7);

        // // verify that you can call all of these methods and get the correct values, using setters to change the values and then getters to retrieve these new values and then display them to the console.
        // // F1
        // int f1Top = f1.GetTopNumber();
        // int f1Bott = f1.GetBottomNumber();

        // Console.WriteLine($"F1 top number: {f1Top}, bottom number: {f1Bott}");

        // f1.SetTopNumber(2);
        // f1.SetBottomNumber(2);

        // int f1SetTop = f1.GetTopNumber();
        // int f1SetBott = f1.GetBottomNumber();

        // Console.WriteLine($"F1 New top number: {f1SetTop}, bottom number: {f1SetBott}");
        // Console.WriteLine(); // Empty line

        // // F2
        // int f2Top = f2.GetTopNumber();
        // int f2Bott = f2.GetBottomNumber();

        // Console.WriteLine($"F2 top number: {f2Top}, bottom number: {f2Bott}");

        // f2.SetTopNumber(3);
        // f2.SetBottomNumber(3);

        // int f2SetTop = f2.GetTopNumber();
        // int f2SetBott = f2.GetBottomNumber();

        // Console.WriteLine($"F2 New top number: {f2SetTop}, bottom number: {f2SetBott}");
        // Console.WriteLine(); // Empty line

        // // F3
        // // int f3Top = f3.GetTopNumber();
        // // int f3Bott = f3.GetBottomNumber();

        // Console.WriteLine($"F3 top number: {f3.GetTopNumber()}, bottom number: {f3.GetBottomNumber}");

        // f3.SetTopNumber(4);
        // f3.SetBottomNumber(4);

        // // int f3SetTop = f3.GetTopNumber();
        // // int f3SetBott = f3.GetBottomNumber();

        // Console.WriteLine($"F3 New top number: {f3.GetTopNumber()}, bottom number: {f3.GetBottomNumber}");

        // Verify that you can call each constructor and that you can retrieve and display the different representations for a few different fractions. 
        //For example, you could try:
        // 1
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(); // Empty line

        // 5
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(); // Empty line

        // 3/4
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine(); // Empty line
        
        // 1/3
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
        Console.WriteLine(); // Empty line
    }
}