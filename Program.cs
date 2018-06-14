using System;
using System.Collections.Generic;

namespace CSharp_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService service = new MathService();
            new List<IMathPerformedService> {
                new LoggingService(), new NotificationService()
            }
            .ForEach(serv => service.MathPerformed += serv.OnMathPerformed);
            
            var result = service.AddNumbers(4.5, 5.78);
            result = service.MultiplyNumbers(5.8, 4.2);
        }
    }
}
