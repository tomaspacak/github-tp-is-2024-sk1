using System;

class Program {
    static void Main() {

        string again = "a";
        while (again=="a") {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("***Testova uloha 1***");
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
            int [] myArray = new int[n];
            Random randomNumber = new Random();
            Console.WriteLine();
            Console.WriteLine("Náhodná čísla:");
            for(int i=0; i <n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine();

        } 
    }
}
