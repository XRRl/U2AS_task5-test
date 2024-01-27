namespace U2AS_task5
{//XiangLin(Lester) CPS3330W01 Lab2
    public class Class1
    {
        public static double FindMaximum(double num1, double num2, double num3)
        {
            if (num1 == Math.Max(num1, Math.Max(num2, num3)))
            {
                return num1;
            }
            else if (num2 == Math.Max(num1, Math.Max(num2, num3)))
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
        public static double FindMaximum(double num1, double num2)
            {
            return Math.Max(num1, num2);
                }
    }
}
