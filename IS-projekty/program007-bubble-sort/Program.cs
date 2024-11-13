using System;
using System.Diagnostics;
class Program {
    static void Main() {

        string again = "a";
        while (again=="a") {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("***********Bubble sort***************");
            Console.WriteLine("  **********Tomáš Pacák***********");
            Console.WriteLine("            **********");
            Console.WriteLine();

            //input
            Console.WriteLine();
            Console.Write("Zadejte počet generovaných čísel v celém čísle: ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write ("Nezadali jste celé číslo");
            }
            Console.WriteLine();
            Console.Write("Zadejte dolní mez v celém čísle: ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write ("Nezadali jste celé číslo");
            }
            Console.WriteLine();
            Console.Write("Zadejte horní mez v celém čísle: ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write ("Nezadali jste celé číslo");
            }
            Console.WriteLine();
            Console.WriteLine("============================================================");
            Console.WriteLine("Zadané hodnoty:");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("============================================================");

        
            //deklerace pole
            int [] myArray = new int[n]; // určení velikosti pole dle n
            Random randomNumber = new Random();
            Console.WriteLine();
            Console.WriteLine("Náhodná čísla:");
            for(int i=0; i <n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1); //ulozeni cisel do pole a nastaveni rozpětí
                Console.Write("{0}; ", myArray[i]); //vypsani hodnot do pole
            }

            //sort
            Stopwatch myStopwatch = new Stopwatch();
            int myCompare = 0;
            int myChange = 0;
            
            myStopwatch.Start();
            for(int i =0; i < n-1; i++) {

                for(int j = 0; j < n-i-1; j++) {
                    myCompare++;
                    if(myArray[j] > myArray[j+1]) {
                        int tmp = myArray[j+1];
                        myArray[j+1] = myArray[j];
                        myArray[j] = tmp;
                        myChange++;
                    }
                }
            }
            myStopwatch.Stop();

            //output
            Console.WriteLine("\n\n\nSeřazené pole");
            for(int i=0; i<n; i++) {
                Console.Write("{0}; ", myArray[i]); 
            }
            Console.WriteLine("\n\nČas potřebný na seřazení pole pomocí algoritmu Bubble sort: {0}", myStopwatch.Elapsed);
            Console.WriteLine("\n\nPočet porovnání: {0}", myCompare);
            Console.WriteLine("\nPočet výměn: {0}", myChange);
            Console.WriteLine();
            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine();

        } 
    }
}

