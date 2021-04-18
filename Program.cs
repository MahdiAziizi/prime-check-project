using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n,i, m = 0, flag = 0;
            Console.Write("adad mored nazar ra vared konid:");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++) 
            {
                if (n % i == 0)
                {
                    Console.Write("adad mored nazar prime nist.");
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            Console.Write("adad mored nazar prime mibashad");
            Console.ReadLine();
        }
    }
}
