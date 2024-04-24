namespace C2_Lekce2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //uzivatel zada 2 integery a necha si je vydelit
            Console.Write("Zadej první číslo");
            //int cislo = Int32.Parse(Console.ReadLine()); - taky dobrý zápis

            string vstup = Console.ReadLine();
            int cislo1 = 0;
            try
            {
                cislo1 = int.Parse(vstup);
            }
            catch (OverflowException vyjimka)
            {
                // Console.WriteLine("Nezadal jsi spravny vstup");
                Console.WriteLine(vyjimka.Message);
                return;
            }
            catch (FormatException vyjimka)
            {

                Console.WriteLine("Nezadal jsi spravny format cisla vstup");
                Console.ReadLine();

                return;

            }
            catch(Exception vyjimka) 
            
            {

                Console.WriteLine("Nezadal jsi spravny format cisla vstup");
                Console.ReadLine();

                return;

            }
           // int cislo1 = int.Parse(vstup);

            vstup = Console.ReadLine();
            int cislo2 = int.Parse(vstup);

            Console.Write($"Vysledek je {cislo1 / cislo2}");
        }
    }
}