using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial
{
    public class IntroLinq
    {
        public IntroLinq()
        {
        }

        public static void Introduction()
        {
            // Specify the data source.
            int[] scores = { 97, 92, 81,75, 60, 86, 90, 94, 96, 97, 99 };

            //tanpa linq
            List<int> scoreList = new List<int>();
            for (int i = 0; i< scores.Length; i++)
            {
                if (scores[i] > 60)
                {
                    scoreList.Add(scores[i]);
                }
            }

            //eksekusi query
            foreach (int i in scoreList)
            {
                Console.Write(i + " ");
            }
        }

        public static void IntroductionWithLinq()
        {
            // Specify the data source.
            int[] scores = { 97, 92, 81, 75, 60, 86, 90, 94, 96, 97, 99 };

            // Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 60
                select score;

            // Execute the query.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }

            // Output: 97 92 81 75 86 90 94 96 97 99
        }

    }

}
