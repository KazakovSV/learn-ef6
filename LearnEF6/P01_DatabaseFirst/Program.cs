using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new TestDbEntities();
            var entities = context.PersonCards.ToList();

            foreach (var entity in entities)
            {
                Console.WriteLine($"{entity.Id}: {entity.FirstName} {entity.SecondName}");
            }
        }
    }
}
