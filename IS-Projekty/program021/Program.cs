using System;
using System.Collections.Specialized;

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

     for(int i=0; i<n; i++){
        if(myArray[i]>max){
            max = myArray[i];
        }

     }       

     int[] maxPoz= new int[n];
     int maxSou=0;


     for (int i=0; i<n; i++){
        if(myArray[i]==max){
            maxPoz[maxSou]=i;
            maxSou++;
        }

     }



     for(int i=0; i<n; i++){
        if(myArray[i]<min){
            min = myArray[i];
        }

     } 

        int[] minPoz= new int[n];
     int minSou=0;


     for (int i=0; i<n; i++){
        if(myArray[i]==min){
            minPoz[minSou]=i;
            minSou++;
        }

     }




    Console.Write("\n\nMaximum je {0} na pozicích:",max);
    for(int i=0;i<maxSou;i++){Console.Write("{0} ",maxPoz[i]);
    }





     Console.Write("\n\nMinimum je {0} na pozicích:", min);
        for(int i=0;i<minSou;i++){Console.Write("{0} ;",minPoz[i]);
    }


    for(int i=0; i<n-1; i++){
        for (int j=0; j <n-1; j++){
            if(myArray[j+1]>myArray[j]){
             int tmp= myArray[j];
             myArray[j]=myArray[j+1];
             myArray[j+1]= tmp;   

            }
        }
    }



        Console.Write("\n\nSeřazené pole:");
        for ( int i=0;i<n; i++){Console.Write("{0} ", myArray[i]);}


        List<int>cisla = new List<int>();
        foreach(int num in myArray){
            if(!cisla.Contains(num)){
                cisla.Add(num);
            }
        }


      Console.WriteLine("\n\nDruhé největší číslo je : {0}",cisla[1]);





            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}
