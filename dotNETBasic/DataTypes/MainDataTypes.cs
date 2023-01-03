using DataTypes.CustomeType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public struct Coords
    {
        public int x, y;

        public Coords(int p1, int p2)
        {
            x = p1;
            y = p2;
        }

        public override string ToString()
        {
            return "Coord (" + x + ", " + y + ")";
        }
    }

    public class MainDataTypes
    {
        public static void Main()
        {
            SampleClass();

        }

        #region Sample Class
        public static void SampleClass()
        {
            SampleClass sampleClass;

            sampleClass = new SampleClass();
            Console.WriteLine("Setelah panggil construktor");
            Console.WriteLine("Sample class value: {0}", sampleClass.ToString());

            sampleClass = new SampleClass(3, 6);
            Console.WriteLine("Setelah panggil construktor dengan params");
            Console.WriteLine("Sample class value: {0}", sampleClass.ToString());


        }
        #endregion

        #region Sample Enum
        public static void SampleEnum()
        {
            Type weekDays = typeof(EnumDays);
            foreach (var item in Enum.GetNames(weekDays))
            {
                Console.WriteLine("Hari : {0}", item);
            }

            Type fieldMode = typeof(EnumFileMode);
            foreach (var mode in Enum.GetNames(fieldMode))
            {
                Console.WriteLine("FieldMode {0}: ", mode);
            }

            Colors myColors = Colors.Red | Colors.Yellow | Colors.Green;
            Console.WriteLine();
            Console.WriteLine("myColors holds a combination of colors. Namely: {0}", myColors);
            Console.WriteLine("Coloer Red: {0}, GetName:{1}", Colors.Red, Enum.GetName(Colors.Red));
            Console.WriteLine("Status Approved: {0}, Names: {1}", ApprovalStep.Approved, Enum.GetName(ApprovalStep.Approved));
        }
        #endregion

        #region Sample Coord
        public static void SampleCoord()
        {
            Coords point1 = new Coords(2, 5);
            Console.WriteLine("Point 1: " + point1);

            Coords point2 = new Coords(7, 7);
            Console.WriteLine("Point 2: " + point2);
        }
        #endregion

        #region Sample DataTypes
        public static void SampleDataTypes()
        {
            // Declaration with initializers (4 examples):
            char firstLetter = 'C';
            var limit = 3;
            int[] source = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, };
            //ini merupakan linQ
            var query = from item in source
                        where item <= limit
                        select item;
            Console.WriteLine("Hasil query : " + query);
            foreach (var item in query)
            {
                Console.WriteLine("item value 1: " + item);
            }
            var query2 = from item in source
                         where item % 2 == 1
                         select item;
            Console.WriteLine("Hasil query2 bil ganjil");
            foreach (var item in query2)
            {
                Console.WriteLine("item value query2: " + item);
            }
        }
        #endregion

    }
}
