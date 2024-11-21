using System;
using System.Collections.Specialized;
using System.Net.NetworkInformation;

class Program {

    static void Main() {

        // chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("******* výpočet PI *******");
            Console.WriteLine("******************************");
            Console.WriteLine("******** Vojtěch Devátý*******");
            Console.WriteLine("******************************\n\n");
            Console.WriteLine();

            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte přesnost(realne číslo - čím menší, tím přesnější výpočet bude): ");
            double presnost;
            while(!double.TryParse(Console.ReadLine(), out presnost)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo): ");
            }

            double i=1;
            double znamenko =1;
            double pictvrt=1;


            while( (1/i) >= presnost ){
            i = i+2;
            znamenko = - znamenko;
            pictvrt = pictvrt + znamenko *1/i;  
            if (znamenko==1){
            Console.WriteLine("Zlomek +1/{0}; aktualní hodnota PI ={1}",i, pictvrt*4);

            }  
            else{
            Console.WriteLine("Zlomek -1/{0}; aktualní hodnota PI ={1}",i, pictvrt*4);

            }         
       

            }

            






            Console.WriteLine(" hodnota čísla PI {0}",4*pictvrt);


            
            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}

