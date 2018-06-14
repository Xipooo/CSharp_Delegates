using System;

namespace CSharp_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService service = new MathService();
            var result = service.MathDelegate(4.5, 5.78);
            
            Console.WriteLine("Result: " + result);
        }
    }
}
