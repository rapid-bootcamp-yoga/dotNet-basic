using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    public class Logic02Soal09
    {
        public Logic02Soal09() 
        { 
        }

        public static void CetakData(int n)
        {
            int meanValue = n / 2;
            for (int i = 0; i < n; i++ )
            {
                int number = 1;
                for (int j = 0; j < n; j++)
                {
                    if (i + j >= meanValue
                        && j - i <= meanValue
                        && i - j <= meanValue
                        && i + j <= meanValue + n - 1)
                    {
                        Console.Write(number + "\t");
                    }
                   
                    else
                    {
 
                        Console.Write("\t");
                    }
                    number += 2;

                }
                Console.WriteLine("\n");
            }
        }
    }
}
