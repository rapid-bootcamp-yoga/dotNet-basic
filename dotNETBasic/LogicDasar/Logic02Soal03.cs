using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    public class Logic02Soal03
    {
        public Logic02Soal03() 
        { 
        }

        public static void CetakData(int n)
        {
            for (int i = 0; i < n; i++ )
            {
                int number = 0;
                for (int j = 0; j < n; j++)
                {
                    if (i < n  && j == 0 )
                    {
                        Console.Write(number + "\t");
                    }
                    else if (i < n  && j == n-1)
                    {
                        Console.Write(number + "\t");
                    }
                    else if (i == 0 && j == j)
                    {
                        Console.Write(number + "\t");
                    }
                    else if (i == n-1 && j == j)
                    {
                        Console.Write(number + "\t");
                    }
                    else if (i == j || i + j == n - 1)
                    {
                        Console.Write(number + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                    number +=2;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
