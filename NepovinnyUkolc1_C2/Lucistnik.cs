namespace NepovinnyUkolc1_C2
{
    internal class Lucistnik
    {
        public int PocetSipu { get; set; }

        public Lucistnik(int pocetSipu)
        {
            PocetSipu = pocetSipu;

        }
        public void Vystrel()
        {
            if (PocetSipu > 0)

            {
                Console.WriteLine($"Vzdy se strefim primo do prostred!");
                PocetSipu--;
            }



        }
    }
}
