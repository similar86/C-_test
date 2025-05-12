//using Internal;
// See https://aka.ms/new-console-template for more information
using System;
class program
{
    public static void Main()
    {
        int count = 0;
        for (int i = 0; i < 100; i++){
            if(i % 3 == 0 || i % 5 ==0)
            {
                count += i;
            }
            else if(i % 15 == 0)
            {
                count -= i;
            }
        }
        Console.WriteLine(count);
    }
}