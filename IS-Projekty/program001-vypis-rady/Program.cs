using System;

class Program { 

static void Main(){

    //chci, aby se program opakoval po stisku "a"
    string again =  "a";
    while(again == "a"){
        Console.Clear();
        Console.WriteLine("************************");
        Console.WriteLine("******Výpis řady********");
        Console.WriteLine("************************");
        Console.WriteLine("*****Vojtěch Devátý*****");
        Console.WriteLine("************************\n\n");
        Console.WriteLine();


        // Vstup od uživatele - TO-DO


        //Logika pro výpis řady - TO-DO

        //Opakování programu
        Console.WriteLine("Pro opakování programu stisktňete hodnotu a");
        again = Console.ReadLine();
 }



}

}