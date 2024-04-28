namespace Algoritm.CodeWars._6Kyu
{
    public class GoddVsEvil
    {
        public static string Run(string good, string evil)
        {
            int[] arrGood = good.Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
            int[] arrEvil = evil.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            int[] goodWorth = { 1, 2, 3, 3, 4, 10 };
            int[] evilWorth = { 1, 2, 2, 2, 3, 5, 10 };

            string goodWin = "Battle Result: Good triumphs over Evil";
            string evilWin = "Battle Result: Evil eradicates all trace of Good";
            string noVictor = "Battle Result: No victor on this battle field";

            int goodSum = 0;
            int evilSum = 0;

            for(int i = 0; i < arrGood.Length; i++)
            {
                goodSum += arrGood[i] * goodWorth[i];
            }

            for(int i = 0; i < arrEvil.Length; i++)
            {
                evilSum += arrEvil[i] * evilWorth[i];
            }

            if(goodSum > evilSum)
            {
                return goodWin;
            }
            else if(evilSum > goodSum)
            {
                return evilWin;
            }
            else
            {
                return noVictor;
            }
        }
    }
}
