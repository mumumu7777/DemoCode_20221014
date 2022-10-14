using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ac = 55;
            int a = 11111;
            string b = "222";

            int c = ac + Convert.ToInt32(b);
            int e = ac + a;

            string f = Aee(); // ctrl + 左鍵
            Acc("aaa");

            Console.WriteLine(Bmw.name);

            // 實作化
            Benz benz = new Benz();
            Benz benz2 = new Benz();
            benz2.name = "AMG";
            benz2.Start();

            Console.WriteLine(benz.name);
            Console.WriteLine(benz2.name);



            Console.WriteLine(c);
            Console.WriteLine(e);
            Console.ReadKey();
        }

        /// <summary>
        /// Acc Function
        /// </summary>
        /// <param name="a">a參數</param>
        public static void Acc(string a)
        {
            Console.WriteLine($"ACC執行了 - {a}");
            Console.WriteLine(string.Format("哈哈:{0}  {1}  {2}", 123, 456, 789));
        }

        public static string Aee()
        {
            Console.WriteLine("Aee執行了");
            return "Aee";
        }

    }
}
