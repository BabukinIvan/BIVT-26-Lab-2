namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            for(int a = 2;a <= (3 * n) - 1; a += 3)
            {
                answer += a;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            for(int a = 1;a <= n; a++)
            {
                answer += 1.0 / a;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            answer = 1;
            for(int a = 1; a <= n; a++)
            {
                answer *= a;
            }
            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 0;

            // code here
            answer = 1;
            for (int i = 1; i <= b; i++)
                answer *= a;
            // end

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;

            // code here
            answer = 1;
            int i = 1;
            while (i <= L)
            {
                answer += 3;
                i *= answer;
            }
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            // code here
            double i = 1;
            while(i >=E)
            {
                answer += i;
                i *= x * x;
            }
            // end

            return answer;
        }

        public int Task7(int n)
        {
            int answer = 0;

            // code here
            int sum = 0;
            while(sum <n)
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
            double i = 0;
            double h = 0;
            while(h<=L)
            {
                answer++;
                i+= v;

                h= System.Math.Sqrt(
                    (R + i)* (R +i)- R * R
                );
            }
            // end

            return answer;
        }
    }
}
