using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Pipes;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.Arm;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;

            // code here
            double s = 0;
            for (double i = 2;i <= n; i=i+2)     
            {
                s += i / (i + 1);
            }
            answer = s;
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double s = 1;
            double add = 1;

            for (double i = 0; i < n; i++)
            {
                add = add * x;
                s += 1 / add;
            }
            answer = s;
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long s = 0;
            long add = 1;
            for (int i = 0; i < n; i++)
            {
                add = add * (i + 1);
                s += add;
            }
            answer = s + 1;
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double s = 0;
            double add = x;
            double e = 0.0001;
            int i = 1;
            double ch = 1;
            while (true)
            {
                ch = Math.Sin(i * add);
                if (Math.Abs(ch) < e) break;
                s += ch;
                add = add * x;
                i += 1;
            }
            answer = s;
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int n = 1;
            double add1 = 1;
            double add2 = 1/x;
            double ch1;
            double ch2;
            do
            {
                add1 = add1 * x;
                add2 = add2 * x;
                ch1 = 1 / add1;
                ch2 = 1 / add2;
                if (Math.Abs(ch1 - ch2) < 0.0001) break;
                n += 1;
            } while (true);
            answer = n;
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1;
            int i = 0;
            while (elem < limit)
            {
                elem *= 2;
                answer += elem;
                i++;
                
            }

            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            int i = 0;
            double ch = L;
            while (true)
            {
                if (ch <= Da) break;
                ch = ch / 2;
                i++;
            }
            answer = i;
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
       
            // code here
            for (double x = a; x<=b+h/1000; x += h)
            {
                double s = 0;
                double ch1 = 1, ch2 = x, zn = 1;
                while (true)
                {
                    double add = ch1 * ch2 / zn;
                    s += add;
                    if (Math.Abs(add) <= 0.0001) break;
                    ch1 *= -1;
                    ch2 *= x * x;
                    zn += 2;
                }
                SS += s;
                SY+=Math.Atan(x);
            }
            // end

            return (SS, SY);
        }
    }
}
