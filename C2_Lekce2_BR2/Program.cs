namespace C2_Lekce2_BR2
{
    using System;

    //Upravte tridu Clovek tak, aby konstruktor vyhodil vyjimku, pokud jmeno neni platne (null nebo prazdny string)
    //nebo pokud tel cislo neni validni (zkontrolujte pocet cislic). Tip: Delku cisla zjistite zavolanim telCislo.ToString().Length.
    //Do metody Main doplnte blok try-catch, ktery uzivatele upozorni, pokud udela chybu
    //Muzete pouzit obecnou tridu Exception, nebo lepe specifickou ArgumentException

    public class Clovek
    {
        public string Jmeno;
        public int TelCislo;

        public Clovek(string jmeno, int telCislo)
        {
            bool jeNullNeboPrazdny=string.IsNullOrEmpty(jmeno);
            if (jeNullNeboPrazdny)
            {
                throw new ArgumentException($"{nameof(Jmeno)}Jmeno je spatny parametr."); //name of mi napíše, jak se jmenuje na proměnná
            }
            Jmeno = jmeno;

            int delkaCisla = telCislo.ToString().Length;
            if (delkaCisla != 9)
            { 
            
            throw new ArgumentException($"{(telCislo)}Jmeno je spatny parametr.");
            }
            TelCislo = telCislo;
        }

        public string VypisJmenoACislo()
        {
            return $"{Jmeno}: {TelCislo}";
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Program na vytvareni telefonniho seznamu");
            Console.WriteLine("========================================");
            Console.Write("Zadejte jmeno: ");
            string jmeno = Console.ReadLine();
            Console.Write("Zadejte telefonni cislo: ");
            string cislo = Console.ReadLine();
            Clovek prvniClovek = new Clovek();
            try
            { 
                prvniClovek = new Clovek(jmeno, int.Parse(cislo)); 
            }

            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            
            prvniClovek.VypisJmenoACislo();

            Console.ReadLine();

        }
    }