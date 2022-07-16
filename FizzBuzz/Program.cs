//FizzBuzz - Print integers 1 to 100,
//but print “Fizz” if an integer is divisible by 3,
//“Buzz” if an integer is divisible by 5,
//and “FizzBuzz” if an integer is divisible by both 3 and 5.

for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0 && !(i % 5 == 0))
    {
        Console.WriteLine("Fizz");
    } 
    else if (i % 5 == 0 && !(i % 3 == 0)) 
    {
        Console.WriteLine("Buzz");
    }
    else if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}
Console.ReadLine();