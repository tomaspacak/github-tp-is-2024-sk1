using System;
using System.Net.Security;

class Program {
    static void Main() {

        string again = "a";
        while (again=="a") {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("**********decimal to binary**********");
            Console.WriteLine("  **********Tomáš Pacák***********");
            Console.WriteLine("            **********");
            Console.WriteLine();

            //input
            Console.WriteLine();
            Console.Write("Zadejte celé číslo v desítkové soustavě: ");
            uint cislo;
            while(!uint.TryParse(Console.ReadLine(), out cislo)) {
                Console.Write ("Nezadali jste celé číslo, zadejte celé číslo: ");
            }
            Console.WriteLine();

            uint[] myArray = new uint[32];
            uint zaloha = cislo;
            uint zbytek;

            uint i;
            for(i=0; cislo > 0; i++) {
                zbytek = cislo % 2;
                cislo = (cislo - zbytek)/2;
                myArray[i] = zbytek;

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Celá část = {0}; Zbytek = {1}", cislo, zbytek);
            }


            Console.WriteLine("\n\nPoslední využitá buňka pole: {0}", i-1);

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\n\nVýsledek:");
            for(int j=(int)(i-1); j>=0; j--) {
                Console.Write("{0}",myArray[j]);
            }

            

            //konec programu/pokracovani
            Console.WriteLine();
            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine();

        } 
    }
}
