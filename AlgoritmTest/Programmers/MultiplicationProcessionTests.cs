using Algoritm.Programmers;

namespace AlgoritmTest.Programmers
{
    [TestClass()]
    public class MultiplicationProcessionTests
    {
        [TestMethod()]
        public void solutionTest()
        {
            int[,] arr1 = new int[3, 2] { { 1, 4 }, { 3, 2 }, { 4, 1 } };
            int[,] arr2 = new int[2, 2] { { 3, 3 }, { 3, 3 } };
            int[,] arr3 = new int[3, 3] { { 2, 3, 2 }, { 4, 2, 4 }, { 3, 1, 4 } };
            int[,] arr4 = new int[3, 3] { { 5, 4, 3 }, { 2, 4, 1 }, { 3, 1, 1 } };

            MultiplicationProcession multiplicationProcession = new MultiplicationProcession();
            multiplicationProcession.solution(arr1, arr2);
            multiplicationProcession.solution(arr3, arr4);
        }
    }
}