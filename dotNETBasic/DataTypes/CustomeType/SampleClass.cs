using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.CustomeType
{
    //nama class
    public class SampleClass
    {
        public int dataX;
        public int dataY;

        //constructor
        public SampleClass()
        {

        }

        //constructor
        public SampleClass(int x, int y) 
        { 
            dataX = x;
            dataY = y;
        }

        public override string ToString()
        {
            return "Sample Class [ x :" + dataX + ", y : " + dataY + "]";
        }
    }
}
