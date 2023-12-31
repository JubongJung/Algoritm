using System.Text;

namespace Algoritm.CodeWars._6Kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/59df2f8f08c6cec835000012/csharp
    /// </summary>
    public class Meeting
    {
        public static string Meeting_(string s)
        {
            string[] names = s.Split(';');

            List<Name> nameList = new List<Name>();

            foreach(var name in names)
            {
                nameList.Add(new Name()
                {
                    LastName = name.Split(":")[0].ToUpper(),
                    FirstName = name.Split(":")[1].ToUpper()
                });
            }

            StringBuilder sb = new StringBuilder();
            var sortedNames = nameList
                .OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
            foreach (var name in sortedNames)
            {
                sb.Append($"({name.FirstName}, {name.LastName})");
            }

            return sb.ToString();
        }

        
    }

    public class Name
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
