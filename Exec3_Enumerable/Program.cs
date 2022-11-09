using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Enumerable
{
    /*
     * 利用Enumerable.Range() 建立一個序列, 值介於 [1, 10]
     * 請利用迴圈列出每一個項目值,確認無誤
     * 
     * 用Enumerable.Range() 建立一個序列, 值介於 [10, 15]
     * 請利用迴圈列出每一個項目值,確認無誤
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> ints = Enumerable.Range(1, 10);
            foreach (var item in ints)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            ints = Enumerable.Range(10, 6);
            foreach (var item in ints)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
