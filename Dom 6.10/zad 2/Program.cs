using System;

namespace zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //FB4(16) ====>(10)
            string number = "FB4";
            int dignumber = Convert.ToInt32(number, 2);
            Console.WriteLine(number+"(16)="+dignumber+"(10)");
        }
    }
}
