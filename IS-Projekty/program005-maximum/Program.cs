﻿using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

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

    Console.WriteLine("Náhodná čísla: ");
    for(int i=0; i<n; i++){
    myArray[i] = randomnumber.Next(dn, hn+1);
    Console.Write("{0}; ", myArray[i]);
}

    int max = myArray[0];
    int min = myArray[0];
    int maxIndex =0;
    int minIndex =0;


    
    for(int i=1; i < n; i++){
        if(myArray[i] > max){
            max = myArray[i];
            maxIndex = i;
            

        }
        if(myArray[i] < min){
            min = myArray[i];
            minIndex= i;

        }
    }




    Console.WriteLine("\n\n Maximum={0};na pozici {1} ", max, maxIndex);
        Console.WriteLine("\n\n Minimum{0} na pozici {1}", min, minIndex );

        Console.WriteLine();



            
            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}
