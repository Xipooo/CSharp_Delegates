using System;

namespace CSharp_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService service = new MathService();
            //service.OutboundEvent += OnOutboundEvent;
            service.MathPerformed += OnMathPerfomed;

            var result = service.AddNumbers(4.5, 5.78);
            result = service.MultiplyNumbers(5.8, 4.2);
        }
        static void OnOutboundEvent(double result){
            Console.WriteLine("Result: " + result);
        }
        static void OnMathPerfomed(object sender, MathPerformedEventArgs e){
            Console.WriteLine("Event Result: " + e.MathResult);
        }
    }
}
