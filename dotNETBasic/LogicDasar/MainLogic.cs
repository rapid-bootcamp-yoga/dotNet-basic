using LogicDasar;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class MainLogic
    {
        public static void Main()
        {

        var daftar = new List<int> { 1, 2, 5, 4, 5};

        List<List<int>> my2DList = new List<List<int>>
        {
            new List<int> {11,2,4},
            new List<int> {4,5,6},
            new List<int> {10,8,-12},
        };

        //Console.WriteLine(simpleArraySum(daftar));
        //Console.WriteLine("daftar main");
        //Console.WriteLine("daftar angka : " + daftar);
        //Console.WriteLine("daftar matrix : " + my2DList);
        //Console.WriteLine("input nilai n:");
        //string? input = Console.ReadLine();
        //int n = input == null ? 0 : int.Parse(input);

        //staircase(n);
        //tesPrima(n);
        //miniMaxSum(daftar);

        Console.WriteLine(MaxListBirthdayCandless(daftar));


        //Logic02Soal01.CetakData(n);
        //Logic02Soal02.CetakData(n);
        //Logic02Soal03.CetakData(n);
        //Logic02Soal04.CetakData(n);
        //Logic02Soal09.CetakData(n);
        
        //var result = diagonalDifference(my2DList);
        //Console.WriteLine("hasil diagonal difference : "+ result);


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

    #region diagonalDefference hackerRank
    public static int diagonalDifference(List<List<int>> arr)
    {
        var diagonalRight = 0;
        var diagonalLeft = 0;


        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = 0; j < arr[0].Count; j++)
            {
                if (i == j)
                {
                    diagonalRight += arr[i][j];
                }
                if (i + j == arr.Count-1)
                {
                    diagonalLeft += arr[i][j];
                }
            }
        }
        return Math.Abs(diagonalLeft - diagonalRight);
    }
    #endregion

    #region tesPrimaOrNot
    public static void tesPrima(int n)
    {
        //Console.WriteLine("masukkan nilai n :");
        //int n = Convert.ToInt32(Console.ReadLine());
        if (n < 2)
        {
            Console.WriteLine("Bukan Prima!");
            Console.ReadKey();

        }
        int cek = 0;
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                cek = 1;
                break;
            }
        }
        if (cek == 1)
        {
            Console.WriteLine($"{n} Bukan bilangan Prima");
        }
        else
        {
            Console.WriteLine($"{n} bilagan prima");
        }
        Console.ReadKey();
    }
    #endregion

    #region sampleStaircase
    public static void staircase(int n)
    {

        for (int i = 0; i < n; i++)
        {

            for (int j = n - 1; j > i; j--)
            {
                Console.Write("*");
            }
            for (int k = 0; k <= i; k++)
            { 
                Console.Write("#");
            }
            Console.WriteLine();
        }
        
    }
    #endregion

    #region testminMaxSum
    public static void miniMaxSum(List<int> arr)
    {
        arr.Sort();

        long minSum = 0;
        long maxSum = 0;

        for (int i = 0; i < arr.Count - 1; i++)
        {
            minSum = minSum + arr[i];
        }

        for (int j = 1; j < arr.Count; j++)
        {
            maxSum = maxSum + arr[j];
        }

        //var min = Convert.ToInt64(minSum);
        //var max = Convert.ToInt64(maxSum);

        Console.WriteLine(minSum + " " + maxSum);
    }
    #endregion

    #region testMaxListBirthdayCandless
    public static int MaxListBirthdayCandless(List<int> candles) 
    {
        List<int> listMax = new List<int>();

        int maxCandles = int.MinValue;
        foreach (int candle in candles)
        {
            
            if (candle == maxCandles)
            {
                listMax.Add(candle);
            }
            if (candle > maxCandles)
            {
                maxCandles = candle;
            }
        }

        listMax.Add(maxCandles);
        Console.WriteLine("Jumlah Max = ");
        int countMax = listMax.Count();
        return countMax;
    }
    #endregion

    #region timeConversion
    public static string timeConversion(string s)
    {

        return "a";
    }
    #endregion
}

