using System;

class Program {
    static void Main() {

        string again = "a";
        while (again=="a") {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("***********maximum a minimum*********");
            Console.WriteLine("  **********Tomáš Pacák***********");
            Console.WriteLine("            **********");
            Console.WriteLine();

            //input
            Console.WriteLine();
            Console.Write("Zadejte počet generovaných čísel v celém čísle: ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write ("Nezadali jste celé číslo, zadejte celé číslo: ");
            }
            Console.WriteLine();
            Console.Write("Zadejte dolní mez v celém čísle: ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write ("Nezadali jste celé číslo, zadejte celé číslo: ");
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

            //max a min
            int max = myArray[0];
            int min =  myArray[0];
            List<int> maxPozice = new List<int> { 1 };
            List<int> minPozice = new List<int> { 1 };
            int maxPocet = 1;
            int minPocet = 1;
            for(int i = 1; i < n; i++) {
                if(myArray[i] > max) {
                    max = myArray[i];
                    maxPocet = 1;
                    maxPozice.Clear();
                    maxPozice.Add(i + 1);
                } else if (myArray[i] == max) {
                    maxPocet++;
                    maxPozice.Add(i + 1);
                }
                
                    
                if(myArray[i] < min) {
                    min = myArray[i];
                    minPocet = 1;
                    minPozice.Clear();
                    minPozice.Add(i+1);
                } else if (myArray[i] == min) {
                    minPocet++;
                    minPozice.Add(i+1);
                }
                
                
            }

            //output
            Console.WriteLine();
            Console.WriteLine("Maximum: {0}, počet: {1}, pozice: {2}", max, /*maxPozice,*/ maxPocet, string.Join(", ", maxPozice));
            Console.WriteLine("Minimum: {0}, počet: {1}, pozice: {2}", min, /*minPozice*/ minPocet, string.Join(", ", minPozice));
            Console.WriteLine();
            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine();

        } 
    }
}
