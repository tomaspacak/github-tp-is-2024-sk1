using System;

class Program {
    static void Main() {

        string again = "a";
        while (again=="a") {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("***Generátor pseudonáhodných čísel***");
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

            int kladny = 0;
            int zaporny = 0;
            int nulovy = 0;
            int suda = 0;
            int licha = 0;
            
            for(int i=0; i <n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1); //ulozeni cisel do pole a nastaveni rozpětí
                Console.Write("{0}; ", myArray[i]); //vypsani hodnot do pole
                
                //+,-,0 poČet
                if(myArray[i] > 0) {
                    kladny++;
                } else if(myArray[i] < 0) {
                    zaporny++;
                } else {
                    nulovy++;
                }

                //suda licha
                if(myArray[i] % 2 == 0) { // % modulus, zbytek po deleni
                    suda++;
                } else {
                    licha++;
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Přehled:");
            Console.WriteLine("kladny: {0}; záporný: {1}; nulový:{2}", kladny, zaporny, nulovy);
            Console.WriteLine("sudá: {0}; lichá: {1}", suda, licha);
            Console.WriteLine("Pro opakování stiskněte klávesu a");
            
            again = Console.ReadLine();

        } 
    }
}
