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
                int arphnosqrt = (p + (i * h));
                double s =  arphnosqrt*arphnosqrt;
                answer += Convert.ToInt32(s);
                
            }
            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;
            if (a < b)
            {
                quotient = 0;
                remainder = a;
            }
            else
            {
                while (a >= b)
                {
                    quotient++;
                    remainder = a - b;
                    a -= b;
                }
            }
            

            return (quotient, remainder);
        }
        public double Task3()
        {
            

            double perv1 = 1.0 , perv2  = 1.0;
            double vtor1 = 2.0 , vtor2 = 1.0;
            double pervchl = perv1/perv2;
            double answer = vtor1/vtor2;
            double diapz = 0.0001;
            while (Math.Abs((answer - pervchl)) >= diapz)
            {
                double prosh1 = vtor1 +perv1;
                double prosh2 = perv2 +vtor2;
                pervchl = answer;
                answer = prosh1 / prosh2;
                perv1 = vtor1;
                perv2 = vtor2;
                vtor1 = prosh1;
                vtor2 = prosh2;

            }
            return answer;
        }

        public int Task4(double b, double q)
        {
            int answer = 0;
            double summa = b;
         
            while (Math.Abs(summa) >=0.0001)
            {
                
                
                answer++;
                summa *= q;

            }


            return answer+1;
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
            double a = 2;
            double b = 2;
            for (int i = 0; i < 63; i++)
            {
                a *= b;
            }
            
            a /= 15;
            a /= 1000000;
            answer = Convert.ToInt64(a);
            
            

            return answer;
        }

        public int Task7(double S, double d)
        {
            S *= 1000;
            d /= 100;
            int answer = 0;
            double S0 = S;
            int count = 1;
            double proc = (S0*d)*(1.0/12.0);
            while (S / S0 < 2)
            {
                if (count % 12 == 0)
                {
                    proc = (S * d)*(1.0/12.0);
                    count++;
                    S += proc;
                    
                }
                else
                {
                    count++;
                    S += proc;
                    
                }
                

            }

            
            answer = count-1;
           
            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            for (double x = a; x <= b + 0.000000001; x += h)
            {
                double y = Math.Cos(x);
                double term = 1;
                int count = 1;
                double s = 1;
                
                
              
                while (Math.Abs(term) >= 0.0001)
                {
                    term = ((-x * x) / ((2.0 * count)*(2.0 * count - 1.0))) * term;
                    s += term;
                    
                    count += 1; 
                    

                }

                SS += s;
                SY += y;
            }


            return (SS, SY);
        }
    }
}
