using System;

namespace Dom_20._10._23
{
    class Program
    {
        static void Main(string[] args)
        {
            //S=V*t+a*t*t/2
            sbyte V = 0;
            Console.Write("Enter the time-t{0}");
            sbyte t = sbyte.Parse(Console.ReadLine());
            Console.Write("Enter a{0}");
            uint a = uint.Parse(Console.ReadLine());
            ulong S = (ulong)(V * t + a * t * t / 2);
            Console.WriteLine("Ranoto uskoritalno dvijenie e = {f2:0}"+S);
        }
    }
}
