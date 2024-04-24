namespace C2_Lekce_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cislo1 = 10;
            double cislo2 = 0;

            //Console.WriteLine($"Vysledek deleni je {cislo1/cislo2}");

            Beypecnedeleni podel = new Beypecnedeleni();
            try 
            {
                podel.PodelCisla(cislo1, cislo2);
            }
            catch (Exception vyjimka) 
            
            {
                Console.WriteLine(vyjimka);
                Console.ReadLine();
            
            }
            
        }
    }
}