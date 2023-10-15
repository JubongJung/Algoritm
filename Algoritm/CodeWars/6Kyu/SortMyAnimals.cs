using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.CodeWars._6Kyu
{
    public class Animal
    {
        public string Name { get; set; } = "";
        public int NumberOfLegs { get; set; }
    }

    /// <summary>
    /// https://www.codewars.com/kata/58ff1c8b13b001a5a50005b4/train/csharp
    /// </summary>
    public class AnimalSorter
    {
        public List<Animal> Sort(List<Animal> input)
        {
            return input.OrderBy(x=>x.NumberOfLegs).ThenBy(x=>x.Name).ToList();
        }
    }
}
