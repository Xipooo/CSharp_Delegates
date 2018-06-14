using System;

namespace CSharp_Delegates
{
    public class LoggingService : IMathPerformedService
    {
         public void OnMathPerformed(object target, MathPerformedEventArgs e){
             Console.WriteLine("Logging result " + e.MathResult);
         }
    }
}