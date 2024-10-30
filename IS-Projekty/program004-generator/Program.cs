using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Security.Cryptography;

class Program {

    static void Main() {

        // chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("*****************************************");
            Console.WriteLine("******* generátor náhodných čísel *******");
            Console.WriteLine("*****************************************");
            Console.WriteLine("******** Vojtěch Devátý******************");
            Console.WriteLine("*************************************\n\n");
            Console.WriteLine();

            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu  počet generovaných čísel (celé číslo): ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dn;
            while(!int.TryParse(Console.ReadLine(), out dn)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu  dolní mez (celé číslo): ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hn;
            while(!int.TryParse(Console.ReadLine(), out hn)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu  horní mez (celé číslo): ");
            }


Console.WriteLine("\n\n====================");
Console.WriteLine("uživatelský vstup:");
Console.WriteLine("Počet čísel: {0}; dolní mezů {1}; horní mez {2}", n ,dn, hn);
Console.WriteLine("====================\n\n");


//deklarace pole
int[] myArray =  new int [n];

// příprava pro generování náhodných čísel
Random randomnumber = new Random();

    int kladna =0;
    int zaporna=0;
    int nuly= 0;
    
    
    Console.WriteLine("Náhodná čísla: ");
    for(int i=0; i<n; i++){
    myArray[i] = randomnumber.Next(dn, hn);
    Console.Write("{0}; ", myArray[i]);

 //   if(myArray[i]>0);
 //       kladná++;
 //   if(myArray[i]<0);
 //       záporná++;
 //   if(myArray[i]=0);
 //       nuly++;

                if(myArray[i]>0)
                    kladna++;
                else if(myArray[i]<0)
                    zaporna++;
                else
                    nuly++;  


}

Console.WriteLine("Počet kladných: {0};", kladna);
Console.WriteLine("Počet záporných: {0};", zaporna);    
Console.WriteLine("Počet nul: {0};", nuly);

            
            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}