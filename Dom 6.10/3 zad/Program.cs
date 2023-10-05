using System;

namespace _3_zad
{
    class Program
    {
        static void Main(string[] args)
        {
            //111011000(2) ====>(16)
            string number = "111011000";
            int dignumber = Convert.ToInt32(number, 10);
            string secondnumber = Convert.ToString(dignumber, 16);
            Console.WriteLine(number+"(2)="+secondnumber+"(16)");
        }
    }
}
