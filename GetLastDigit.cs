// Define a function that takes in two non-negative integers aaa and bbb and returns the last decimal digit of a^b

public static int GetLastDigit(BigInteger n1, BigInteger n2)
{
    return (int)BigInteger.ModPow(n1, n2, 10);
}