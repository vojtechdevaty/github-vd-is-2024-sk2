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
            int pozmax = 0;
            int pozmin= 0;

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
            for (int j=0;j<n;j++){
            if ( myArray[j] ==min ){

                    pocetMin++;
            }
            else if ( myArray[j] ==max ){

                    pocetMax++;
            }



            }
            


            Console.WriteLine("\n\nMaximum je {0} na pozici {1}  a je jich {2} ", max, pozmax+1, pocetMax);
             Console.WriteLine("Minimum je {0} na pozici {1} a jejich je {2}", min, pozmin+1, pocetMin);


















            
            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}