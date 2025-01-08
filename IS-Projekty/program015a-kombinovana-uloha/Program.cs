using System;
using System.Collections.Specialized;
using System.Diagnostics;

class Program {

    static void Main() {

        // chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("*******kombinovaná uloha *******");
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
  
            for(int j=0;j<n; j++){
            if(myArray[j] > max){
            max = myArray[j];
            }
            if(myArray[j] < min){
            min = myArray[j];
            }
            }



            int[] maxPositions = new int[n];
            int maxCount = 0;
            for (int i = 0; i < n; i++) {
                if (myArray[i] == max) {
                    maxPositions[maxCount] = i;
                    maxCount++;
                }
            }

            
            
              Console.Write("\n\nMaximum je {0} na pozicich:", max);
             for (int i = 0; i < maxCount; i++) {
                Console.Write("{0} ", maxPositions[i]);
            }


        
        
             Console.Write("\n\nMinimum je {0} na pozici:");

 

      



            
            for(int i=0; i<n-1; i++) {
                for(int j=0 ; j<n-i-1; j++) {
                    
                    if(myArray[j] < myArray[j+1]) {
                        int tmp = myArray[j];
                        myArray[j] = myArray[j+1];
                        myArray[j+1] = tmp;
                    
                    }
                }
            }


            Console.WriteLine("\n\nSeřazené pole: ");
            for(int i=0; i<n; i++) {
                Console.Write("{0}; ", myArray[i]);
            }




            Array.Sort(myArray);
            double median;
            if (n%2 ==0){
                median = (myArray[n/2-1]+ myArray[ n/2])/ 2.0;
            }
            else{
                median = myArray[ n/ 2];
            }
            
            Console.WriteLine("\nMedian je {0}", median);



            Array.Reverse(myArray);

            List<int> cisla = new List<int>();
        foreach (int num in myArray) {
            if (!cisla.Contains(num)) {
                cisla.Add(num);
            }
        }
            Console.WriteLine("Druhé největší číslo: {0}", cisla[1]);
            Console.WriteLine("Třetí největší číslo: {0}", cisla[2]);
            Console.WriteLine("Čtvrté největší číslo: {0}", cisla[3]);

             int nsd = NSD(cisla[1], cisla[2]);
            int nsn = NSN(cisla[1], cisla[2]);

            Console.WriteLine("NSD druhého a třetího největšího čísla: {0}", nsd);
            Console.WriteLine("NSN druhého a třetího největšího čísla: {0}", nsn);


         static int NSD(int a, int b) {
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    static int NSN(int a, int b) {
        return (a * b) / NSD(a, b);
    }






        Console.WriteLine("\nObrazec (výška = medián, šířka = třetí největší číslo):");
            int vyska = (int)Math.Round(median);
            int sirka = myArray[2];

           
            for (int i = 0; i <= vyska; i++) {
                for (int j = 0; j <= sirka; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


                     int h, f, k ;  
         for (h = 1; h <= sirka; h++)  
         {  
            for (f = 1; f <= h; f++)  
            {  
               Console.Write("");  
            }  
            for (k = 1; k <= h; k++)  
            {  
               Console.Write("*");  
            }  
            Console.WriteLine("");  
         }  
         
           
           
    


 














            
            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}