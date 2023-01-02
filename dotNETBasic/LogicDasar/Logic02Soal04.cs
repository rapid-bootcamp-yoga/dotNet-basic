using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    public class Logic02Soal04
    {
        public Logic02Soal04() 
        { 
        }

        public static void CetakData(int n)
        {
            for (int i = 0; i < n; i++ )
            {
                int number = 1;
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
                    else if (j<2)
                    {
                        number = 1;
                    }
                    else
                    {
                        number += 2;
                        //number = number[j - 2] + number[j + 1];
                        Console.Write("\t");
                    }
                   
                }
                Console.WriteLine("\n");
            }
        }
    }
}
