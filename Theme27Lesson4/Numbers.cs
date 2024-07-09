using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Theme27Lesson4
{
    internal class Numbers
    {
        public static double CalculateAverage(double[] mas)
        {
            double sum = 0;
            int count = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
                count++;
            }
            return sum / count;
        }
        public static bool IsPrime(int n)
        {
            if (n == 1) return false;
            if (n == 2) return true;
            int k = 0;
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0) k++;
            }
            if (k == 1) return true;
            else return false;
        }
        public static bool IsEven(int n)
        {
            if (n == 0) return false;
            if (n % 2 == 0) return true;
            else return false;
        }
        public static bool IsOdd(int n)
        {
            if (n == 0) return false;
            if (n % 2 != 0) return true;
            else return false;
        }
        public static int CalculateFactorial(int n)
        {
            int res;
            if (n == 0) return 1;
            return n * CalculateFactorial(n - 1);
        }
        public static string ConvertToBinary(int n) => Convert.ToString(n,2);
        public static string ConvertToHex(int n) => Convert.ToString(n,16);
        public static double CalculatePower(double n,int m)
        {
            if (m == 0) return 1;
            return n * CalculatePower(n, m - 1);
        }
        

    }
}
