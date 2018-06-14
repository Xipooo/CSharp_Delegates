using System;

namespace CSharp_Delegates
{
    public class MathPerformedEventArgs : EventArgs
    {
        public double MathResult { get; set; }
        public MathPerformedEventArgs(double result)
        {
            MathResult = result;
        }
    }
}