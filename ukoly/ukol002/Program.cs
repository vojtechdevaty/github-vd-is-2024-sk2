using System;
using System.Collections.Specialized;

class Program {

    static void Main() {

        // chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("************** ukol002 *******");
            Console.WriteLine("******************************");
            Console.WriteLine("******** Vojtěch Devátý*******");
            Console.WriteLine("******************************\n\n");
            Console.WriteLine();


            Console.Write("Zadejte šířku obrazce (celé číslo): ");
            int delka;
            while(!int.TryParse(Console.ReadLine(), out delka)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo): ");
            }
            
            
                        Console.Write("Zadejte výšku obrazce (celé číslo): ");
            int vyska;
            while(!int.TryParse(Console.ReadLine(), out vyska)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo): ");
            }
            
            
            for (int i = 0; i < vyska; i++)
        {
            if (i % 2 == 0) 
            {

             Console.WriteLine(new string('*', delka));
             
            
            }
            else if (i % 4 == 1)
            {
                Console.WriteLine("*".PadRight(delka));
            }
            else if (i % 4 == 3) 
            {
                Console.WriteLine("".PadLeft(delka - 1) + "*");
            }
        }       
                    
            Console.WriteLine();
            
            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}
