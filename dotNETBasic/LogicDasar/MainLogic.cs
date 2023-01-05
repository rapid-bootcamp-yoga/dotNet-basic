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

        var daftar = new List<int> { 1, 2, 3, 4, 5, 6, 7 };


        Console.WriteLine(simpleArraySum(daftar));

        Console.WriteLine("Input angka : ");
            string? input = Console.ReadLine();
            int n = input == null ? 0 : int.Parse(input);

           
            Logic02Soal01.CetakData(n);
            Logic02Soal02.CetakData(n);
            Logic02Soal03.CetakData(n);
            Logic02Soal04.CetakData(n);
            Logic02Soal09.CetakData(n);
        }

        #region sum hackerRank
        public static int simpleArraySum(List<int> ar)
        {
            var value = ar;
            var n = value.Count;
            int sum = 0;
            foreach (var item in value)
            {
            sum += item;
            }
            return sum;
        }
    #endregion

    #region compare hackerRank
    public static List<int> compareTriples(List<int> a, List<int> b)
    {
       List<int> alice = a;
       List<int> bob = b;

        var n = alice.Count;
        var alicePoint = 0;
        var bobPoint = 0;
         
       
        for (int i=0; i < n; i++)
        {
            if (alice[i] > bob[i])
            {
                alicePoint += 1;
            }
            else if (alice[i] < bob[i])
            {
                bobPoint += 1;
            }
        }

        var result = new List<int>();
        result.Add(alicePoint);
        result.Add(bobPoint);
        return result;

    }
    #endregion

    #region very big sum hackerRank

    #endregion

}

