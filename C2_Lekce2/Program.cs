namespace C2_Lekce2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Trida Rytir - 2 vlastnosti a 1 metodu
            //Jmeno, pocetZivotu

            Rytir albrecht = new Rytir("Albrecht", 3);

            albrecht.VypisJmenoAZivoty();

            //albrecht.datumNarozeni=DateTime.Now; //toto je okamžitý čas v PC
            albrecht.datumNarozeni = new DateTime(1972, 1, 6);

            // Console.WriteLine($"Narodil jsem se {albrecht.datumNarozeni}");
            Console.WriteLine($"Narodil jsem se {albrecht.datumNarozeni.Day}.{albrecht.datumNarozeni.Month}.{albrecht.datumNarozeni.Year}");

            TimeSpan vek = DateTime.Now - albrecht.datumNarozeni;
            Console.Write($"Muj vek je {vek.Days/365}");
        }
    }
}