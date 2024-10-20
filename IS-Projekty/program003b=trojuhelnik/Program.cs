using System;
using System.Collections.Specialized;

class Program {

    static void Main() {

        // chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("**************************");
            Console.WriteLine("******* trojůhelník *******");
            Console.WriteLine("**************************");
            Console.WriteLine("****** Vojtěch Devátý *******");
            Console.WriteLine("**************************\n\n");
            Console.WriteLine();
          
          
           Console.Write("Zadejte šířku trojůhelníku (celé číslo): ");
            int val;
            while(!int.TryParse(Console.ReadLine(), out val)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu šířku trojůhelníku (celé číslo): ");
            }

          
          
          Console.WriteLine();
          
          
         int i, j, k ;  
         for (i = 1; i <= val; i++)  
         {  
            for (j = 1; j <= i; j++)  
            {  
               Console.Write("");  
            }  
            for (k = 1; k <= i; k++)  
            {  
               Console.Write("*");  
            }  
            Console.WriteLine("");  
         }  
         


            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}