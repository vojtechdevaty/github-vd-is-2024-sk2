using System;

class Program
{
    static void Main()
    {
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("*****************************************");
            Console.WriteLine("******* Generátor Intervalů ************");
            Console.WriteLine("*****************************************");
            Console.WriteLine("******** Vojtěch Devátý *****************");
            Console.WriteLine("*****************************************\n\n");

            // Vstup od uživatele
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu počet generovaných čísel: ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dn;
            while (!int.TryParse(Console.ReadLine(), out dn))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hn;
            while (!int.TryParse(Console.ReadLine(), out hn) || hn <= dn)
            {
                Console.Write("Horní mez musí být větší než dolní mez. Zadejte znovu horní mez: ");
            }

            Console.Write("Zadejte počet intervalů (celé číslo): ");
            int intervalCount;
            while (!int.TryParse(Console.ReadLine(), out intervalCount) || intervalCount <= 0)
            {
                Console.Write("Počet intervalů musí být kladné celé číslo. Zadejte znovu počet intervalů: ");
            }

            Console.WriteLine("\n\n====================");
            Console.WriteLine("Uživatelský vstup:");
            Console.WriteLine($"Počet čísel: {n}; Dolní mez: {dn}; Horní mez: {hn}; Počet intervalů: {intervalCount}");
            Console.WriteLine("====================\n\n");

            // Deklarace pole a příprava pro generování náhodných čísel
            int[] myArray = new int[n];
            Random randomNumber = new Random();

            // Výpočet šířky jednoho intervalu
            double intervalWidth = (double)(hn - dn) / intervalCount;
            int[] intervalCounts = new int[intervalCount];

            // Generování čísel a jejich zařazení do intervalů
            Console.WriteLine("Náhodná čísla: ");
            for (int i = 0; i < n; i++)
            {
                myArray[i] = randomNumber.Next(dn, hn + 1);
                Console.Write($"{myArray[i]}; ");

                // Určení, do kterého intervalu číslo spadá
                int intervalIndex = Math.Min((int)((myArray[i] - dn) / intervalWidth), intervalCount - 1);
                intervalCounts[intervalIndex]++;
            }

            // Výpis výsledků pro jednotlivé intervaly
            Console.WriteLine("\n\nIntervaly:");
            for (int i = 0; i < intervalCount; i++)
            {
                double lowerBound = dn + i * intervalWidth;
                double upperBound = lowerBound + intervalWidth;
                Console.WriteLine($"Interval <{lowerBound:F2}, {upperBound:F2}>: {intervalCounts[i]} čísel");
            }

            // Opakování programu
            Console.WriteLine("\nPro opakování programu stiskněte klávesu a, jinak libovolnou jinou klávesu.");
            again = Console.ReadLine();
        }
    }
}
