namespace NepovinnyUkolc1_C2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadání č. 1
            Console.WriteLine("Zadej první číslo");
            string prvniCislo = Console.ReadLine();
            int prvniCislo1 = int.Parse(prvniCislo);

            Console.WriteLine("Zadej druhé číslo");
            string druheCislo = Console.ReadLine();
            int druheCislo2 = int.Parse(druheCislo);

            int vysledek = prvniCislo1 + druheCislo2;
            Console.WriteLine($"Součet tvých čísel je:{vysledek}.");

            //Zadání č. 2
            Console.WriteLine("Zadej počet hvězdiček");
            string pocetHvezdicek = Console.ReadLine();
            int pocetHvezdicekResult = int.Parse(pocetHvezdicek);
            for (int i = 0; i < pocetHvezdicekResult; i++)
            {
                Console.WriteLine("*");
            }

            //Zadání č. 3
            Lucistnik jan = new Lucistnik(10);

            while (jan.PocetSipu > 0)
            {
                jan.Vystrel();
            }
            Console.WriteLine("Nemám šípy.");

            //Zadání č. 4

            int nahodneCislo = 10;
            Console.WriteLine("Hádej, co si myslím.");
            string cisloUzivatele = Console.ReadLine();
            int typUzivatele = int.Parse(cisloUzivatele);
            while (typUzivatele != nahodneCislo)
            {

                if (typUzivatele > nahodneCislo)

                {
                    Console.WriteLine("Moje číslo je menší, hádej znovu.");

                }
                else if (typUzivatele < nahodneCislo)
                {

                    Console.WriteLine("Moje číslo je větší, hádej znovu");
                }
                cisloUzivatele = Console.ReadLine();
                typUzivatele = int.Parse(cisloUzivatele);
            }
            Console.WriteLine("To je správně!");
        }


    }
}