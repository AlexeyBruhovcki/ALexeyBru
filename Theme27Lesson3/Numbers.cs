using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme27Lesson3
{
    internal class Numbers
    {
        public double CalculateAverage(double[] mas)
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
        public bool IsPrime(int n)
        {
            if (n == 1) return false;
            if (n==2) return true;
            int k = 0;
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0) k++;
            }
            if (k == 1) return true;
            else return false;
        }
        public bool IsEven(int n)
        {
            if (n == 0) return false;
            if (n % 2 == 0) return true;
            else return false;
        }
        public bool IsOdd(int n)
        {
            if (n == 0) return false;
            if (n % 2 != 0) return true;
            else return false;
        }
    }
}
