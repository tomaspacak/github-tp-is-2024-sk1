using System;
using System.Globalization;
using System.Net.Security;

class Program {
    static void Main() {

        string again = "a";
        while (again=="a") {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("**********decimal to other**********");
            Console.WriteLine("  **********Tomáš Pacák***********");
            Console.WriteLine("            **********");
            Console.WriteLine();

            //input
            Console.WriteLine();
            Console.Write("Zadejte celé kladne číslo v desítkové soustavě: ");
            uint cislo;
            while(!uint.TryParse(Console.ReadLine(), out cislo)) {
                Console.Write ("Nezadali jste celé číslo, zadejte celé číslo: ");
            }
            Console.WriteLine();

            Console.Write("Zadejte soustavu v celém čísle (např. 2 nebo 3,...): ");
            uint k;
            while(!uint.TryParse(Console.ReadLine(), out k) || k < 2) {
                Console.Write ("Nezadali jste celé číslo, zadejte celé číslo: ");
            }
            Console.WriteLine();

            uint[] myArray = new uint[32];
            uint zbytek = 0;
            uint zaloha = cislo;
            uint digits = 0;
            for(uint i = 0; i < cislo; i++) {
                zbytek = cislo % k;
                cislo = (cislo-zbytek)/k;
                myArray[i] = zbytek;
                digits++;

                Console.WriteLine("cela čast: {0} ; zbytek: {1}", cislo, zbytek);
            }

            Console.WriteLine();
            Console.Write("{0} do {1} soustavy = ", zaloha, k);

            for(int j = (int)digits - 1; j >= 0; j--) {
                Console.Write(" {0} ", myArray[j]);
            }

            

            

            //konec programu/pokracovani
            Console.WriteLine();
            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine();

        } 
    }
}
