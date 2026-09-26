using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            for (int i = 0; i < n; i++)
            {
                answer += (p + h * i) * (p + h * i);
            }
            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            while (a >= b)
            {
                a -= b;
                quotient += 1;
            }
            remainder = a;

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;
            double s = b;
            answer += 1;
            for (int i = 0;; i++)
            {
                if (Math.Abs(s) < E)
                {
                    break;
                }
                s *= q;
                answer += 1; 
            }

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;
            long number = a;
            while (b > 0)
            {
                number *= b;
                b--;
            }
            while (number >= 10)
            {
                number /= 10;
                answer++;
            }
            
            return answer;
        }
        public long Task6()
        {
            long answer = 0;
            double a = 0;
            double p = 1;
            
            for (int i = 0; i < 64; i++)
            {
                a += p;
                p *= 2;
            }
            double grams = a / 15.0;
            answer = (long)Math.Floor(grams / 1000000);
            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            // end

            return (SS, SY);
        }
    }
}
