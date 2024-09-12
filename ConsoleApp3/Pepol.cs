using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Pepol
    {
        string id;
        string first_name, last_name;
        int eletkor;
        List<Dogz> kuty; 

        public Pepol(string sor)
        {
            string[] tomb = sor.Split(';');
            this.id = tomb[2];
            this.first_name = tomb[0];
            this.last_name = tomb[1];
            this.eletkor = int.Parse(tomb[2].Split('-')[1]);
            this.kuty = [];
        }

        public string Id { get => id; set => id = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }

        public int Eletkor { get => eletkor; set => eletkor = value; }

        public List<Dogz> Kuty => kuty;
        public void Tolt(Dogz kutya) => kuty.Add(kutya);
    }
}
