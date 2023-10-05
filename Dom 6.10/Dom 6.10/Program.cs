using System;

namespace Dom_6._10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 384(10) ====>(2)
            int number = 384;
            string dignumber = Convert.ToString(number, 2);
            Console.WriteLine(number+"(10)="+dignumber+"(2)");
        }
    }
}
