       using System;
using System.Collections.Specialized;

class Program {

    static void Main() {

       
       
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("******* ukol003 *************");
            Console.WriteLine("******************************");
            Console.WriteLine("******** Vojtěch Devátý*******");
            Console.WriteLine("******************************\n\n");
            Console.WriteLine();

            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte šířku obrazce (celé číslo): ");
            int width;
            while(!int.TryParse(Console.ReadLine(), out width)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu šířku obrazce (celé číslo): ");
            }

            Console.Write("Zadejte výšku obrazce (celé číslo): ");
            int height;
            while(!int.TryParse(Console.ReadLine(), out height)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu výšku obrazce (celé číslo): ");
            }
            

            Console.WriteLine();
            
            
            
            
            for (int i = 0; i <= height/2; i++) {
            for (int j = 0; j <= width; j++) {
                if (j > width / 2) {
                    Console.Write("*");
                } else {
                    Console.Write(" "); 
                }
            }
            Console.WriteLine(); 
        }
            
                    for (int i = 0; i <= height/2; i++) {
            for (int j = 0; j <= width; j++) {
                if (j > width / 2) {
                    Console.Write("");
                } else {
                    Console.Write("*"); 
                }
            }
            Console.WriteLine(); 
        }
            
            
            
            
            
            

            
             // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}