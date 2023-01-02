using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    public class Logic02Soal01
    {
        public Logic02Soal01() 
        { 
        }

        public static void CetakData(int n)
        {
            for (int i = 0; i < n; i++ )
            {
                int number = 1;
                for (int j = 0; j < n; j++ )
                {
                    if( i == j || i + j == n - 1)
                    {
                        Console.Write(number + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                    number +=1;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
