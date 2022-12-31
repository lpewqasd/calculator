using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Class1
    {

    }
    public abstract class Cal
    {
        public double X { get; set; }
        public double Y { get; set; }
        public abstract double Answer();
    }
    public class CalAdd : Cal
    {
        public override double Answer()
        {
            return X + Y;
        }
    }
    public class CalSub : Cal
    {
        public override double Answer()
        {
            return X - Y;
        }
    }
    public class CalMul : Cal
    {
        public override double Answer()
        {
            return X * Y;
        }
    }
    public class CalDiv : Cal
    {
        public override double Answer()
        {
            return X / Y;
        }
    }
}
