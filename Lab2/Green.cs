using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Timers;
using System.Xml.Schema;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;
            double el = 0;
            for (int i=2; i<=n; i=i+2)
            {
                el = i / (i + 1.0);
                answer=answer + el;
            }
            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;
            double xx = 1.0;
            for (int i = 0; i <= n; i++)
            {
                answer = answer + (1.0 / xx);
                xx = x * xx;
            }
            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
            long x = 1;
            for (int i = 0; i <= n; i++)
            {
                answer = answer + x;
                x = (i+1) * x;
            }
            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;
            double el= 1;
            double xx = 1;
            for (int i=1; ; i++)
            {
                xx = xx * x;
                el = Math.Sin(i * xx);
                if (Math.Abs(el) <= E)
                {
                    break;
                }
                else
                {
                    answer = answer + el;
                }
            }    
            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;
            double xx = x;
            double oldxx = 1;
            for (int n=1; ;n++)
            {
                oldxx = xx;
                xx = oldxx / x;
                if (Math.Abs(xx - oldxx) < E)
                {
                    break;
                }
                else
                {
                    answer = answer + 1;
                }
            }
            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;
            int elem = 1;
            int i = 0;
            while (elem<limit)
            {
                 elem *= 2;
                 answer += elem;
                 i++;
            }
            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;
            while (L > Da)
            {
                L = L / 2.0;
                answer = answer + 1;
            }
            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            for (double x = a; x <= b+0.0001; x = x + h)
            {

                double el = x;
                for (double i = 0; ; i++)
                {
                    SS = SS + el;
                    if (Math.Abs(el) < E)
                    {
                        break;
                    }

                    el = (-el * x * x * (2.0 * i + 1.0)) / (2.0 * i + 3.0);
                }
                SY = SY + Math.Atan(x);
            }
            return (SS, SY);
        }
    }
}
