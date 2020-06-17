using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new TestModelContainer())
            {
                db.PersonCards.Add(new PersonCard
                {
                    FirstName = "Stanislav",
                    LastName = "Kazakov",
                    Age = 32
                });

                db.PersonCards.Add(new PersonCard
                {
                    FirstName = "Bob",
                    LastName = "Martin",
                    Age = 45
                });

                db.SaveChanges();
            }

            using(var db = new TestModelContainer())
            {
                var cards = db.PersonCards.ToList();

                foreach (var card in cards)
                {
                    Console.WriteLine($"{card.Id}: {card.FirstName} {card.LastName}");
                }
            }
        }
    }
}
