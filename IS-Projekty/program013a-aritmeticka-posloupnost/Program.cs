using System;
using System.Collections.Specialized;

class Program {

    static void Main() {

        // chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("*** arimetrická posloupnost **");
            Console.WriteLine("******************************");
            Console.WriteLine("******** Vojtěch Devátý*******");
            Console.WriteLine("******************************\n\n");
            Console.WriteLine();

        


            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte počet čísel (celé číslo): ");
            int cislo;
            while(!int.TryParse(Console.ReadLine(), out cislo)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel (celé číslo): ");
            }

                        Console.Write("Zadejte diferenci(celé číslo): ");
            int dif;
            while(!int.TryParse(Console.ReadLine(), out dif)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu diferenci (celé číslo): ");
            }

                        Console.Write("Zadejte první číslo řady (celé číslo): ");
            int first;
            while(!int.TryParse(Console.ReadLine(), out first)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo): ");
                
            }


       

            Console.WriteLine("\n\nZadali jste : číslo {0}, diferenci {1}, a počáteční číslo {2}",cislo, dif, first);

            Console.WriteLine("vygenerovaná čísla:" );

            int suma = 0;

        for (int i = 0; i < cislo; i++ ){

            int prvky = first + (i * dif);

            Console.Write(prvky);
            if (i < cislo - 1) Console.Write("; ");

            suma += prvky;

            }
            
            
           Console.WriteLine(";");
            Console.WriteLine("Součet zobrazených hodnot: {0}", suma);












            Console.WriteLine();

            
            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}



