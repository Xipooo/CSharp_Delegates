namespace CSharp_Delegates
{
    public class MathService
    {
        public delegate double ResultHandler(double value1, double value2);

        public ResultHandler MathDelegate;
        public MathService(){
            MathDelegate = AddNumbers;
            MathDelegate += MultiplyNumbers;
        }
        private double AddNumbers(double value1, double value2){
            return value1 + value2;
        }
        private double MultiplyNumbers(double value1, double value2){
            return value1 * value2;
        }
    }
}