namespace HW_NB3_DateTime_List;



internal class Program

{
    static void Main(string[] args)

    {
        // 1. Vypiš aktuální datum a čas, nemusíš řešit, v kterém je to časovém pásmu.

        DateTime today = DateTime.Now;
        Console.WriteLine(today);

        // 2. Vytvoř proměnnou typu DateTime a ulož do ní svoje datum narození. Potom vypiš, kolik dnů od té doby uteklo.

        DateTime dayOfBirth = new DateTime(1988, 2, 18);
        TimeSpan daysFromBirth = DateTime.Now - dayOfBirth;
        Console.WriteLine($"Od mého narození uběhlo {daysFromBirth.Days} dní.");
        Console.WriteLine(".............................");

        // 3. Vytvoř list stringů a vlož do něj 5 různých hodnot.

        List<string> list = new List<string>() { "dog", "cat", "bat", "dad", "vet" };

        // 4. Smaž z tohoto listu libovolnou hodnotu.

        list.Remove("vet");

        // 5. Zjisti, jestli tento list obsahuje nějakou hodnotu pomocí list metody Contains

        bool inList = list.Contains("set");

        if (inList)
        {
            Console.WriteLine($"Hodnota je v seznamu");
        }
        Console.WriteLine($"Hodnota není v seznamu");
        Console.WriteLine(".............................");

        // 6. Vypiš do konzole, kolik je v tom listu prvků a připoj k tomu všechny ty hodnoty (např: "2: modra, zelena").

        int numberOfItem = list.Count();
        string result = numberOfItem.ToString() + ":";
        foreach (string item in list)
        {
            result += item;

            if (item != list.Last())
            {
                result = result + ", ";
            }

        }
        Console.WriteLine($"{result}");
        Console.WriteLine(".............................");

        // 7. Vytvoř slovník, kde klíčem bude položka nákupu (string) a hodnotou cena té položky, a vlož nějaké hodnoty (např: <"chleba", 20>).

        Dictionary<string, int> shopping = new Dictionary<string, int>()
        {

            { "butter", 20},
            {"bread", 30},
            {"roll", 2}

        };

        // 8. Zjisti, jestli slovník obsahuje nějakou konkrétní potravinu a pokud ano, vypiš její cenu, pokud ne, vypiš, že není.

        string key = "butter";
        bool inShoppingList = shopping.ContainsKey(key);
        if (inShoppingList)
        {
            Console.WriteLine($"Cena {key} je {shopping[key]}");
        }
        else
        {
            Console.WriteLine($"{key} není v seznamu.");
        }

        Console.WriteLine(".............................");

        // 9. Řekněme, že už jsi do slovníku přidala např. chleba a zjistila, že máš v nákupní tašce ještě jeden -> uprav hodnotu k tomu klíči tak, aby obsahovala hromadnou cenu za všechny stejné položky.

        shopping["butter"] = 100;

        foreach (KeyValuePair<string, int> record in shopping)
        {
            Console.WriteLine($"{record.Key}:{record.Value}");
        }

    }

}


















