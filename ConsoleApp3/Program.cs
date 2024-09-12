namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> zarojelek = [.. File.ReadAllLines("input.txt")];
            int nyito = 0;
            int zaro = 0;
            int ossz = 0;
            foreach (var item in zarojelek)
            {
                nyito = 0;
                zaro = 0;
                if (!item.StartsWith(')') && !item.EndsWith('('))
                {
                    zaro = item.Count(x=> x == ')');
                    nyito = item.Count(x => x == '(');
                    if(nyito == zaro)
                    {
                        ossz++;
                    }
                }
                
            }
            Console.WriteLine("1.Feldat: "+ossz);
            int nem = 0;


            Console.WriteLine("2.feladat: "+"(())()()()".IsValid());

            List<Pepol> nberek = [.. File.ReadAllLines("people.csv").Select(x => new Pepol(x))];

            Console.WriteLine($"Legfiatalabb személy: \n{nberek.MinBy(x => x.Eletkor).First_name} {nberek.MinBy(x => x.Eletkor).Last_name}, {nberek.MinBy(x => x.Eletkor).Eletkor} éves");
            Console.WriteLine();
            Console.WriteLine($"Legidősebb személy: \n{nberek.MaxBy(x => x.Eletkor).First_name} {nberek.MaxBy(x => x.Eletkor).Last_name}, {nberek.MaxBy(x => x.Eletkor).Eletkor} éves");
            Console.WriteLine();
            Console.WriteLine($"A fájlban szereplő személyek átlagos életkora: {nberek.Average(x => x.Eletkor)} év");


            List<Dogz> kutyak = [.. File.ReadAllLines("Dogs.csv").Select(x => new Dogz(x))];

            nberek.ForEach(x =>
            {
                kutyak.Where(kutya => kutya.Owner_ID == x.Id).ToList().ForEach(m => x.Tolt(m));
            });

            Console.WriteLine($"4. feladat: {nberek.MaxBy(x => x.Kuty.Count).First_name} {nberek.MaxBy(x => x.Kuty.Count).Last_name} has " +
                $"{nberek.MaxBy(x => x.Kuty.Count).Kuty.Count} dogs");







        }
    }
}
