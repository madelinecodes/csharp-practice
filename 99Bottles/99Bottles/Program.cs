using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var x = 99; x > 0; x--)
            {
                if (x < 100 && x > 1)
                {
                    Console.WriteLine("{0} bottles of beer on the wall, {0} bottles of beer. Take one down, pass it around, {1} bottles of beer on the wall.", x, (x - 1));
                }
                if (x == 1)
                {
                    Console.Write(@"{0} bottle of beer on the wall {0} bottle of beer.Take one down, pass it around, no more bottles of beer on the wall. 
                     No more bottles of beer on the wall, no more bottles of beer. 
                     Go to the store and buy some more, 99 bottles of beer on the wall.", x);
                }
            }
        }
    }
}
