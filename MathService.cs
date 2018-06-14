using System;

namespace CSharp_Delegates
{
    public class MathService
    {
        //public delegate double ResultHandler(double value1, double value2);
        //public delegate void OutboundHandler(double result);

        //Unnecessary
        //public delegate void MathResultHandler(object sender, MathPerformedEventArgs e);
        //public event MathResultHandler MathPerformed;
        public event EventHandler<MathPerformedEventArgs> MathPerformed;
        //public ResultHandler MathDelegate;
        //public OutboundHandler OutboundDelegate;
        //public event OutboundHandler OutboundEvent;
        
        
        public MathService(){
            //MathDelegate = AddNumbers;
            //MathDelegate += MultiplyNumbers;
        }

        public double AddNumbers(double value1, double value2){
            var result = value1 + value2;
            //OutboundEvent(result);
            MathPerformed(this, new MathPerformedEventArgs(result));
            return result;
        }
        public double MultiplyNumbers(double value1, double value2){
            var result = value1 * value2;
            //OutboundEvent(result);
            MathPerformed(this, new MathPerformedEventArgs(result));
            return result;
        }
    }
}