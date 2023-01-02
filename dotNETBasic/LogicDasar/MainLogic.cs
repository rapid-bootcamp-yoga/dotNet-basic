using LogicDasar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class MainLogic
    {
        public static void Main()
        {
            Console.WriteLine("Input angka : ");
            string? input = Console.ReadLine();
            int n = input == null ? 0 : int.Parse(input);

            Logic02Soal01.CetakData(n);
        }
    }

