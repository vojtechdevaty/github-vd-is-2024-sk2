using System;
using System.Collections.Specialized;

class Program {

    static void Main() {

        // chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("******* Analýza textu *******");
            Console.WriteLine("******************************");
            Console.WriteLine("******** Vojtěch Devátý*******");
            Console.WriteLine("******************************\n\n");
            Console.WriteLine();


            Console.WriteLine("zadejte text pro analýzu:");
            string myText = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine(myText);
            Console.WriteLine(myText[0]);
            Console.WriteLine(myText.Length);
            Console.WriteLine(myText[myText.Length-1]);



            string samohlasky= "aáeéiíyýoóuůúěAÁEÉIÍYÝOÓUŮÚĚ";
            string cislice= "1234567890";
            string souhlasky = "hckrdtnžščřjďťňbflmpsvzHCKRDTNŽŠČŘJDŤŇBFLMPSVZ";
           

            int pocetSamohlasek = 0;
            int pocetsouhlasek = 0;
            int pocetcislic = 0;
            int pocetostatnich =0;


            foreach ( char znak in myText)
        {
            if (samohlasky.Contains(znak))
            {
                pocetSamohlasek++;
            }
            else if(cislice.Contains(znak)){

            pocetcislic++;
            }
            else if (souhlasky.Contains(znak))
            {
                pocetsouhlasek++;
            }
            else {
                pocetostatnich++;
            }


        }

            Console.WriteLine("Počet číslic {0}",pocetcislic);
             Console.WriteLine("Počet samohlasek {0}",pocetSamohlasek);
             Console.WriteLine("Počet souhlasek {0}",pocetsouhlasek);
             Console.WriteLine("Počet ostatních {0}",pocetostatnich);












            
            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}