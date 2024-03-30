using System;
class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            string output = (i % 3 == 0 && i % 5 == 0) ? "Hello Goodbye" :
                    (i % 3 == 0) ? "Hello" :
                    (i % 5 == 0) ? "GoodBye" :
                    i.ToString();
                    Console.WriteLine(output);
        }
    }
}