namespace Algoritm.CodeWars._6Kyu
{
    public class Tribonacci
    {
        public static double[] Run(double[] signature, int n)
        {
            List<double> result = signature.ToList();
            Queue<double> queue = new Queue<double>();

            foreach(var c in result.TakeLast(3))
            {
                queue.Enqueue(c);
            }

            for(int i = 0; i < n - 3; i++)
            {
                double sum = queue.Sum();
                queue.Enqueue(sum);
                result.Add(sum);
                queue.Dequeue();
            }

            return result.ToArray();
        }
    }
}