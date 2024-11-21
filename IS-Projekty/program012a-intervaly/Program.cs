using System;
using System.Collections.Specialized;
using System.Security.Cryptography;

class Program {

    static void Main() {

        // chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("*****************************************");
            Console.WriteLine("******* generátor intervalů*******");
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
    int interval_01 =0;
    int interval_02 =0;
    int interval_03 =0;
    int interval_04 =0;

    for(int i=0; i<n; i++){
    myArray[i] = randomnumber.Next(dn, hn+1);
    Console.Write("{0}; ", myArray[i]);


    if (myArray[i]<= 0.25*hn){
        interval_01++;
    }
    else  if (myArray[i]<= 0.5*hn){
        interval_02++;
    }
        else  if (myArray[i]<= 0.75*hn){
        interval_03++;
    }
    else 
    interval_04++;

}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("inetrval <{0}, {1}>: {2}", dn, 0.25 * hn, interval_01);
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("inetrval <{0}, {1}>: {2}",0.5 * hn, 0.5 * hn+1, interval_02);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("inetrval <{0}, {1}>: {2}", 0.75 * hn, 0.75 * hn+1, interval_03);
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("inetrval <{0}, {1}>: {2}", 0.75 * hn+1,  hn, interval_04);

            
            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}
