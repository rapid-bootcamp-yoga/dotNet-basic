using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    public class Logic01Soal01
    {
        public Logic01Soal01()
        {

        }

        public static void CetakData(int n)
        {
            int number = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(number + "\t");
                number++;
            }
            Console.WriteLine("\n");
        }
    }
}
