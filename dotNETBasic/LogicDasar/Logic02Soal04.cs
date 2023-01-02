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
                    if ( j == 0 )
                    {
                        Console.Write(number + "\t");
                    }
                    else if ( j == n-1)
                    {
                        Console.Write(number + "\t");
                    }
                    else if (i == 0)
                    {
                        Console.Write(number + "\t");
                    }
                    else if (i == n-1 )
                    {
                        Console.Write(number + "\t");
                    }
            
                    else if (j == n/2 || i == n/2)
                    {
                        Console.Write(number + "\t");
                    }
                    else
                    {
                     
                        Console.Write("\t");
                    }
                    number += number;

                }
                Console.WriteLine("\n");
            }
        }
    }
}
