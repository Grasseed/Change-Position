using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tAry = new string[] { "紅", "黑", "白", "黃", "綠" };
            for (int k = tAry.Length - 1; k >= 0; k--)
            {
                Console.Write("tAry[{0}]={1} ", k, tAry[k]);
            }
            Console.Read();
        }
    }
}
