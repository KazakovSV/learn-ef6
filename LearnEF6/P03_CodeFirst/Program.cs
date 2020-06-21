using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonInfoModel db = new PersonInfoModel();

            db.PersonInfos.Add(
                new PersonInfo
                {
                    FirstName = "Stanislav",
                    LastName = "Kazakov",
                    Age = 32
                });

            db.SaveChanges();

            var persons = db.PersonInfos.ToList();

            foreach (var person in persons)
            {
                Console.WriteLine($"{person.Id}: {person.FirstName} {person.LastName}");
            }
        }
    }
}
