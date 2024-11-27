using System;
using System.Net.Security;

class Program {
    static void Main() {

        string again = "a";
        while (again=="a") {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("***decimal to binary***");
            Console.WriteLine("  **********Tomáš Pacák***********");
            Console.WriteLine("            **********");
            Console.WriteLine();

            //input
            Console.WriteLine();
            Console.Write("Zadejte číslo v desítkové soustavě: ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number)) {
                Console.Write ("Nezadali jste celé číslo");
            }
            Console.WriteLine();

            /*Console.Write("Zadejte dolní mez v celém čísle: ");
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
            Console.WriteLine();*/
            


            for(int=0; number > 0; int++) {
                zbytek = 0;
                number = (number - zbytek) / ;
                myArray[i] = zbytek;
            }

            //konec programu/pokracovani
            Console.WriteLine();
            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine();

        } 
    }
}
