namespace Algoritm.Programmers
{
    public class ParkingFee
    {
        public int[] solution(int[] fees, string[] records)
        {
            

            Dictionary<int, Record> recordsList = new Dictionary<int, Record>();

            foreach (var item in records)
            {
                var splitedItem = item.Split(' ');

                int Number = Convert.ToInt32(splitedItem[1]);
                string time = splitedItem[0];
                string InOut = splitedItem[2];

                if(!recordsList.ContainsKey(Number))
                {
                    Record record = new Record(fees);
                    recordsList.Add(Number, record);
                }

                if (InOut == "IN")
                {
                    recordsList[Number].InMinute = GetMinute(time);
                }
                else
                {
                    recordsList[Number].OutMinute = GetMinute(time);
                    recordsList[Number].Minute += recordsList[Number].OutMinute - recordsList[Number].InMinute;
                }
            }

            foreach(var item in recordsList)
            {
                if(item.Value.OutMinute < item.Value.InMinute)
                {
                    item.Value.Minute += 1439 - item.Value.InMinute;
                }
            }

            int[] answer = new int[recordsList.Count];
            int idx = 0;
            foreach (var row in recordsList.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{row.Key}, {row.Value.Fee}");
                answer[idx] = row.Value.Fee;
                idx++;
            }

            return answer;
        }

        public int GetMinute(string time)
        {
            string[] splitedTime = time.Split(':');

            int minute = Convert.ToInt32(splitedTime[0]) * 60 + Convert.ToInt32(splitedTime[1]);
            return minute;
        }
    }

   

    public class Record
    {
        public int BasicTime { get; set; }
        public int BasicFee { get; set; }
        public int UnitTime { get; set; }
        public int UnitFee { get; set; }
        public Record(int[] fees)
        {
            BasicTime = fees[0];
            BasicFee = fees[1];
            UnitTime = fees[2];
            UnitFee = fees[3];
        }
        public int InMinute { get; set; }
        public int OutMinute { get; set; }
        public int Minute { get; set; }
        public int Fee { get
            {
                if(Minute < BasicTime) return BasicFee;

                decimal times = Convert.ToDecimal((Minute - BasicTime));
                decimal result = Math.Ceiling( times / UnitTime) * UnitFee;

                return Convert.ToInt32(result) + BasicFee;
            } 
        }
    }
    
}
