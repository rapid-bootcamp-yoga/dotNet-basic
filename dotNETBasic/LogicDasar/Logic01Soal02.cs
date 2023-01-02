using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    public class Logic01Soal02
    {
        public Logic01Soal02()
        {

        }

        public static void CetakData(int n)
        {
            int number = 1;
            for (int i = 0; i < n; i++)
            {
                if(i == 0)
                {
                    number = 1;
                }
                else if (i == 1)
                {
                    number = 3;
                } else
                {
                    if (i % 2 == 0)
                    {
                        number += 1;
                    }else
                    {
                        number += 3;
                    }
                }
                Console.Write(number + "\t");
                number++;
            }
            Console.WriteLine("\n");
        }
    }
}
