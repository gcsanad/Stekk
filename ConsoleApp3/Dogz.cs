using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Dogz
    {
        string name, age, breed, owner_ID;

        public Dogz(string sor)
        {
            string[] tomb = sor.Split(';');
            this.name = tomb[0];
            this.age = tomb[1];
            this.breed = tomb[2];
            this.owner_ID = tomb[3];
        }

        public string Name { get => name; set => name = value; }
        public string Age { get => age; set => age = value; }
        public string Breed { get => breed; set => breed = value; }
        public string Owner_ID { get => owner_ID; set => owner_ID = value; }
    }
}
