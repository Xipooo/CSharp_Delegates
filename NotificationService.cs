using System;

namespace CSharp_Delegates
{
    public class NotificationService : IMathPerformedService
    {
        public void OnMathPerformed(object target, MathPerformedEventArgs e){
            Console.WriteLine("Notification: Result is " + e.MathResult);
        }
    }
}