using IteratorPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a collection
            // Collection collection = new Collection();
            Collection owce = new Collection();
            owce[0] = new Item("Owca czerwona");
            owce[1] = new Item("Owca pomaranczowa");
            owce[2] = new Item("Owca zolta");
            owce[3] = new Item("Owca zielona");
            owce[4] = new Item("Owca niebieska");
            owce[5] = new Item("Owca granatowa");
            owce[6] = new Item("Owca fioletowa");

            // Create iterator
            //Iterator iterator = collection.CreateIterator();
            Iterator liczowce = owce.CreateIterator();

            // Skip every other item
            liczowce.Step = 1;
            Console.WriteLine("Iterating over sheeps:");
            for (Item item = liczowce.First(); !liczowce.IsDone; item = liczowce.Next())
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("--------------------------back------------------------------------------------------");
            for (Item item = liczowce.Last(); !liczowce.IsDone2; item = liczowce.Back())
            {
                Console.WriteLine(item.Name);
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
