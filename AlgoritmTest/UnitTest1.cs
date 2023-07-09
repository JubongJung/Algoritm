namespace AlgoritmTest
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow(2,10)]
        [TestMethod("두 원 사이의 정수 쌍 (단순반복)")]
        ///https://school.programmers.co.kr/learn/courses/30/lessons/181187
        public int TestMethod1(int r1, int r2)
        {
            int count = 0;

            for(int i = 0; i <= r2; i++)
            {
                for(int j = 1; j <= r2; j++)
                {
                    double distance = GetDistance(i, j);
                    bool isBetween = IsBetween(r1, r2, distance);

                    if (isBetween)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count * 4);

            return count * 4;
        }

        private bool IsBetween(int r1, int r2, double distance)
        {
            return (distance >= r1 && distance <= r2);
        }

        /// <summary>
        /// 중심에서 점까지의 거리 구하기
        /// </summary>
        private double GetDistance(int x, int y) 
        {
            double distance = (x * x) + (y * y);

            return Math.Sqrt(distance);
        }

        private double GetXdistance(int x, int r)
        {
            return Math.Sqrt((r * r) - (x * x));
        }

        private int GetIncludeDots(int r)
        {
            int count = 0;

            for (int i = -r; i <= r; i++)
            {
                double distance = GetXdistance(i, r);
                int dots = Convert.ToInt32(Math.Truncate(distance)) * 2 + 1;
                count += dots;
                Console.WriteLine($"i: {i}, distancd: {distance}, big: {dots}");
            }

            return count;
        }

        private int GetExcludeDots(int r)
        {
            int count = 0;

            for (int i = -r; i <= r; i++)
            {
                double distance = GetXdistance(i, r);
                if(distance % 1 == 0 && distance >= 1)
                {
                    distance -= 1;
                }

                int dots = Convert.ToInt32(Math.Truncate(distance)) * 2;

                if (distance >= 1)
                {
                    dots += 1;
                }
                Console.WriteLine($"i: {i}, distancd: {distance}, small: {dots}");
                count += dots;
            }

            return count;
        }

        [DataRow(2, 3)]
        [DataRow(2, 5)]
        [DataRow(2, 6)]
        [DataRow(2, 7)]
        [TestMethod("두 원 사이의 정수 쌍")]
        public void TestMethod2(int r1, int r2)
        {
            int big = GetIncludeDots(r2);
            int small = GetExcludeDots(r1);
            int count = big - small;

            Console.WriteLine($"big: {big}, small:{small}, count: {count}");

            count = big - small;
            Console.WriteLine($"{TestMethod1(r1, r2)}, {count}");
            Assert.AreEqual(TestMethod1(r1, r2), count);
        }
    }
}