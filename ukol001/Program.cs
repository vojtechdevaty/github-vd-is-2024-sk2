using System;
using System.Collections.Specialized;

class Program {

    static void Main() {

        // chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("************** ukol001 *******");
            Console.WriteLine("******************************");
            Console.WriteLine("******** Vojtěch Devátý*******");
            Console.WriteLine("******************************\n\n");
            Console.WriteLine();

            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte šířku obrazce (celé číslo): ");
            int delka;
            while(!int.TryParse(Console.ReadLine(), out delka)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo): ");
            }

            for( int i = 0; i < delka ; i++ )
            {
            Console.Write("*");
            }
            Console.WriteLine();

            for( int i = 1; i < delka - 1;i++ ){
            for ( int j=0; j < delka-i-1; j++ )
            {
                    Console.Write (" ");
            }

                    Console.WriteLine("*");
                }


                   for( int i = 0; i < delka ; i++ )
      
                                {
            Console.Write("*");
            }
            Console.WriteLine();
            
            
            
            
            
            
            

            

            
            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}
