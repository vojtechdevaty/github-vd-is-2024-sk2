
using System;
using System.Collections.Specialized;


        string again = "a";
        while(again == "a") {
            Console.Clear();
            razitko ();
        ulong a = ziskatCislo ("zadej přirozené číslo a :");
        ulong b = ziskatCislo ("zadej přirozené číslo b : ");
        ulong nsd = vypocitatNsd (a, b);
        ulong nsn = vypocetNsn (a, b, nsd);
        zobrazitVysledky (a, b, nsn, nsd);

            
            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
       




static void razitko() {
    Console.WriteLine("*************************");
    Console.WriteLine("******* NSD a NSN *******");
    Console.WriteLine("*************************");
    Console.WriteLine("****** Vojtěch Devátý ******");
    Console.WriteLine("*************************\n\n");
    Console.WriteLine();
}

static ulong ziskatCislo(string zprava) {

            // Vstup od uživatele - lepší varianta
            Console.Write(zprava);
            ulong cislo;
            while(!ulong.TryParse(Console.ReadLine(), out cislo)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo): ");
            }
    return cislo;

}
static ulong vypocitatNsd (ulong a, ulong b){
    while (a !=b){
        if ( a > b)
        a = a-b;
        else 
        b = b-a;

    }
    return b;
}


static ulong vypocetNsn ( ulong a, ulong b, ulong nsd){



    return (a*b)/nsd;
}

static void zobrazitVysledky(ulong a, ulong b, ulong nsd, ulong nsn){

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine ("NSN čísel {0} a {1} je {2}", a, b, nsd );
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine ($"NSD čísel {a} a {b} je {nsn}");
Console.ForegroundColor = ConsoleColor.White;

}