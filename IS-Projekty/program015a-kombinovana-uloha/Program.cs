using System;
using System.Collections.Specialized;

class Program {

    static void Main() {

        // chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("******* Název programu *******");
            Console.WriteLine("******************************");
            Console.WriteLine("******** Vojtěch Devátý*******");
            Console.WriteLine("******************************\n\n");
            Console.WriteLine();

            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu počet generovaných čísel (celé číslo): ");
            }

            Console.Write("Zadejte dolní mez řady (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez řady (celé číslo): ");
            }
            
            Console.Write("Zadejte horní mez řady (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez řady(celé číslo): ");
            }



            int[] myArray =  new int [n];
            Random randomnumber = new Random();
            Console.WriteLine ("Náhodná čísla :");
            for (int i=0;i<n;i++ ){
                myArray[i] = randomnumber.Next(dm, hm+1);
    Console.Write("{0}; ", myArray[i]);
            }
            

            int max = myArray[0];
            int min = myArray[0];
            int pozmax;
            int pozmin;

            for(int j=0;j<n; j++){
            if(myArray[j] > max){
            max = myArray[j];
            pozmax = j;
            }
            if(myArray[j] < min){
            min = myArray[j];
            pozmin = j;
            }
            }

            int pocetMax = 0;
            int pocetMin = 0;
            


            Console.WriteLine("Maximum je {0} na pozici {1}", max, pozmax);


















            
            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}