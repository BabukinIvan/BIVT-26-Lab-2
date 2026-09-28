namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            int s = 0;
            for ( int i=1; i<=n; i++)
            {
                s = s+(i*3-1);
            }
            answer = s;
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double s = 0;
            for (int i =1; i<=n; i++)
            {
                s = s + 1.0 / i;
            }
            answer = s;
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long s = 1;
            for (int i=1; i<=n; i++)
            {
                s = s * i;
            }
            answer = s;
            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 0;

            // code here
            long s = 1;
            for (int i =1; i<=b; i++)
            {
                s = s * a;
            }
            answer = s;
            // end

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;

            // code here
            int n = 1;
            int p = 1;
            while (p <= L)
            {
                n = n + 3;
                p = p * n;
            }
            answer = n;
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            // code here
            double s = 0;
            double t = 1;
            while (t >= 0.0001)
            {
                s = s + t;
                t = t * x * x;
            }
            answer = s;
            // end

            return answer;
        }

        public int Task7(int n)
        {
            int answer = 0;

            // code here
            int sum = 0;
            while (sum < n)
            {
                answer++;
                sum += answer;
            }
            // end

            return answer;
        }
        public int Task8(double L, double v)
        {
            int answer = 0;
            const double R = 6371.0; // радиус Земли, км

            // code here
            double h = 0;
            int t = 0;
            double l = 0;
            while (l <= L)
            {
                t++;
                h = v * t;
                l =Math.Sqrt((R + h) * (R + h) - R * R);
                              
            }
            answer = t;
            // end

            return answer;
        }
    }
}