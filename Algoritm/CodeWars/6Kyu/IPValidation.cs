namespace Algoritm.CodeWars._6Kyu
{
    public class IPValidation
    {
        /// <summary>
        /// https://www.codewars.com/kata/515decfd9dcfc23bb6000006/solutions/csharp
        /// </summary>
        public static bool IsValidIp(string ipAddres)
        {
            string[] ipElements = ipAddres.Split('.');
            if (ipElements.Length != 4)
            {
                return false;
            }

            foreach (string ipElement in ipElements)
            {
                bool isInt = Int32.TryParse(ipElement, out int ipNumber);
                
                if (!isInt)
                {
                    return false;
                };

                if(ipElement.ToString() != ipNumber.ToString())
                {
                    return false;
                }

                if (ipNumber > 255 || ipNumber < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
