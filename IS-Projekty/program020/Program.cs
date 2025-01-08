using System;
using System.Collections.Specialized;
using System.ComponentModel;

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

int[] myArray =  new int [n];
Random randomnumber = new Random();

    Console.WriteLine("Náhodná čísla: ");
    for(int i=0; i<n; i++){
    myArray[i] = randomnumber.Next(dn, hn+1);
    Console.Write("{0}; ", myArray[i]);
    
}

 int max =myArray[0];
 int min = myArray[0];

 for(int i=0; i<n; i++){
if (myArray[i]>max){
    max = myArray[i];
}
if (myArray[i]<min){
    min = myArray[i];
}

 }


int[] maxPoz = new int [n];
int maxSou = 0;
for (int i =0; i < n; i++){
    if(myArray[i]==max){
    maxPoz[maxSou]= i;
    maxSou++;
    }
}

 Console.Write("\nMAximum je {0} na pozicích:", max);
 for (int i =0; i<maxSou;i++){
    Console.Write("{0} ", maxPoz[i]);
 }

int[] minPoz = new int [n];
int minSou = 0;
for (int i =0; i < n; i++){
    if(myArray[i]==min){
    minPoz[minSou]= i;
    minSou++;
    }
}

 Console.Write("\nMinimum je {0} na pozicích:", min);
 for (int i =0; i<minSou;i++){
    Console.Write("{0} ", minPoz[i]);
 }

 for(int i=0; i <n-1; i++){
    for(int j=0; j<n-i-1;j++){

        if (myArray[j]< myArray[j+1]){
            int tmp = myArray[j];
            myArray[j] = myArray[j+1];
            myArray[j+1]= tmp;
        }
    }
 }

    Console.WriteLine("\n\nSeřazené pole je :");
    for (int i=0; i <n; i++)
    {Console.Write("{0}; ",myArray[i]);}


        List<int> cisla = new List<int>();
        foreach (int num in myArray){
            if(!cisla.Contains(num)){
                cisla.Add(num);
            }
        }

            Console.WriteLine("\nDruhé největší číslo: {0}", cisla[1]);
            Console.WriteLine("Třetí největší číslo: {0}", cisla[2]);
            Console.WriteLine("Čtvrté největší číslo: {0}", cisla[3]);


Array.Sort(myArray);
double median;
if (n%2 ==0){
    median = (myArray[n/2-1]+ myArray[ n/2])/2.0;
}
else {
    median = myArray [ n/2];
}

Console.WriteLine("\nMedian je {0}", median);




string binar = Convert.ToString( cisla[3], 2);
Console.WriteLine("číslo {0} je v binární soustavě {1}", cisla[3], binar);



 Console.WriteLine("\nObrazec (výška = medián, šířka = třetí největší číslo):");
            int vyska = (int)Math.Round(median);
            int sirka = cisla[2];

           
                int co = sirka/3;
                int pro = vyska/3;


    for (int i = 0; i < pro; i++) // Smyčka pro řádky
        {
            // Vytiskneme mezery na začátku každého řádku
            for (int j = 0; j < co; j++)
            {
                Console.Write(" ");
            }

            // Vytiskneme hvězdičky pro zbytek řádku
            for (int j = co; j <= 2*co; j++)
            {
                Console.Write("*");
            }

            // Přechod na nový řádek
            Console.WriteLine();
        }
    







            for (int i = 0 ; i < vyska/3; i++){
             for (int j = 0 ; j < sirka; j++){
   
              Console.Write("*");

            }
               Console.WriteLine();
             }





    for (int i = 0; i < pro; i++) // Smyčka pro řádky
        {
            // Vytiskneme mezery na začátku každého řádku
            for (int j = 0; j < co; j++)
            {
                Console.Write(" ");
            }

            // Vytiskneme hvězdičky pro zbytek řádku
            for (int j = co; j <= 2*co; j++)
            {
                Console.Write("*");
            }

            // Přechod na nový řádek
            Console.WriteLine();
        }
    





            
            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}