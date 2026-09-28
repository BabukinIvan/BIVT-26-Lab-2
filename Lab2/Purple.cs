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

            // code here
            // code here
int s = 0;

for (int i = 0; i < n; i++)
{
    s += (p + i * h) * (p + i * h);
}

return s;
// end
            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
    while(a >= b)
    {
        a = a - b;
        quotient++;
    }
    remainder = a;
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
int a = 1, b = 2;
int c = 1, d = 1;

double p = (double)a / c;
double q = (double)b / d;

while (Math.Abs(q - p) >= 0.0001)
{
    a = a + b;
    c = c + d;

    p = q;
    q = (double)a / c;

    int t = b;
    b = a;
    a = t;

    t = d;
    d = c;
    c = t;
}

return q;
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
             int answer = 1;
 double x = b;

 while (Math.Abs(x) >= 0.0001)
 {
     x = x * q;
     answer++;
 }   

 return answer;    
        }
        public int Task5(int a, int b)
        {
            int answer = 0;
            long number = a;
            // code here
while(b>0)
{
    number *= b;
    b--;
}
while (number >= 10)
{
    number /= 10;
    answer++;
}
            // end

            return answer;
        }
        public long Task6()
        {
            
            long answer = 0;
            decimal s = 0;
            decimal z = 1;
            // code here
            for(int i = 1;i <=64 ;i++)
            {
                
                s += z;
                z *= 2;
            }
            return (long)(s / 15 / 1000000);
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
           int answer = 0;
double s = S;
double p = S * d / 100;

// code here
while (s < 2 * S)
{
    s += p / 12;
    answer++;

    if (answer % 12 == 0)
        p = s * d / 100;
}

// end

return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            double E = 0.0001;

            int n = (int)((b - a) / h);

            for (int j = 0; j <= n; j++)
            {
                double x = a + j * h;

                double s = 0;
                double t = 1;
                int i = 0;

                while (Math.Abs(t) >= E)
                {
                    s += t;
                    i++;
                    t = -t * x * x / ((2 * i - 1) * (2 * i));
                }

                SS += s;
                SY += Math.Cos(x);
            }

            return (SS, SY);
        }
    }
}
