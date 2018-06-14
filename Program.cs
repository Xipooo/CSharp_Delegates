using System;

namespace CSharp_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService service = new MathService();
            service.OutboundEvent += OnOutboundEvent;

            var result = service.MathDelegate(4.5, 5.78);
        }
        static void OnOutboundEvent(double result){
            Console.WriteLine("Result: " + result);
        }
    }
}
