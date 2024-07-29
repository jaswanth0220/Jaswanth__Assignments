using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkAssignment
{
    class Participant
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }

    internal class TwoHalves
    {

        static void Main()
        {
            var participants = new List<Participant>
{
            new Participant { Name = "Alice", Country = "USA" },
            new Participant { Name = "Bob", Country = "USA" },
            new Participant { Name = "Charlie", Country = "UK" },
            new Participant { Name = "David", Country = "UK" },
            new Participant { Name = "Eve", Country = "Canada" },
            new Participant { Name = "Frank", Country = "Canada" }
};

            var half = participants.Count / 2;
            var list1 = participants.Take(half).ToList();
            var list2 = participants.Skip(half).ToList();

            var matches = from p1 in list1
                          from p2 in list2
                          where p1.Country != p2.Country
                          select new { Player1 = p1.Name, Player2 = p2.Name };

            foreach (var match in matches)
            {
                Console.WriteLine($"{match.Player1} vs {match.Player2}");
            }

        }
    }
}
