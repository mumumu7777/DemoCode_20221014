using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// 靜態類別Bmw
    /// </summary>
    public static class Bmw
    {
        /// <summary>
        /// Bmw車牌
        /// </summary>
        public static string name { get; set; }
    }

    /// <summary>
    /// 非靜態類別 Benz
    /// </summary>
    public class Benz
    {
        /// <summary>
        /// 名字
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 建構式
        /// </summary>
        public Benz()
        {
            name = "賓士外殼";
        }
        /// <summary>
        /// 發動
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"{name} 出發囉!!!!");
        }

    }
}
