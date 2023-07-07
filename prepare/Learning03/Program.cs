using System;

class Program
{
    static void Main(string[] args)
    {
        // verify that you can create fractions using all three of these constructors. 
        // create an instance for 1/1 (using the first constructor), 
        Fraction f1 = new Fraction();
        // 6/1 (using the second constructor)
        Fraction f2 = new Fraction(6);
        // 6/7 (using the third constructor).
        Fraction f3 = new Fraction(6, 7);

        // verify that you can call all of these methods and get the correct values, using setters to change the values and then getters to retrieve these new values and then display them to the console.
    }
}