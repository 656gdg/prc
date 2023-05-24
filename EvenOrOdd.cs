// Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.

public static string EvenOrOdd(int number)
{
    if (number % 2 == 0 || number == 0)
    {
        return "Even";
    }
    else return "Odd";
}