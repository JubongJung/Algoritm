namespace Algoritm.Programmers
{
    public class EnglishFollowUp
    {
        public int[] solution(int n, string[] words)
        {
            int[] answer = { 0, 0 };

            string prevWord = words[0];
            List<string> tmpWords = new List<string>()
            {
                prevWord
            };

            for(int i = 2; i <= words.Length; i++)
            {
                string thisWord = words[i - 1];
                int person = (i % n) > 0 ? (i % n) : n;
                int count = (i + n - 1) / n;


                if (HasWord(tmpWords, thisWord))
                {
                    answer = new int[] { person, count};
                    break;
                }

                if(IsBreacked(prevWord, thisWord))
                {
                    answer = new int[] { person, count };
                    break;
                }
                
                tmpWords.Add(thisWord);
                prevWord = thisWord;
            }

            return answer;
        }

        public bool HasWord(List<string> words, string word)
        {
            foreach(var row in words)
            {
                if(row == word) return true;
            }

            return false;
        }

        public bool IsBreacked(string prevWord, string thisWord)
        {
            return prevWord[prevWord.Length - 1] != thisWord[0];
        }
    }
}
