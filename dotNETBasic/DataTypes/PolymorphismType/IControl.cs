using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.PolymorphismType
{
    public interface IControl
    {
        void Paint();
        void Create();
    }
    public interface ISurface
    {
        void Paint();
        void Draw();
    }
    public class SampleClassImplement : IControl, ISurface
    {
        public void Create()
        {
            Console.WriteLine("Create method in SampleClass");
        }

        public void Draw()
        {
            Console.WriteLine("Draw method in SampleClass");
        }

        // Both ISurface.Paint and IControl.Paint call this method.
        public void Paint()
        {
            Console.WriteLine("Paint method in SampleClass");
        }
    }
}
