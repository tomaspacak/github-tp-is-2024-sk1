using System;

class Program {
    static void Main() {

        string again = "a";
        while (again=="a") {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("***Aritmetická posloupnost***");
            Console.WriteLine("  **********Tomáš Pacák***********");
            Console.WriteLine("            **********");
            Console.WriteLine();

            //input
            Console.WriteLine();
            Console.Write("Zadejte počet generovaných členů v posloupnosti v celém čísle: ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write ("Nezadali jste celé číslo, zadejte celé číslo: ");
            }
            Console.WriteLine();

            Console.Write("Zadejte diferenci (reálné číslo): ");
            double dif;
            while(!double.TryParse(Console.ReadLine(), out dif)) {
                Console.Write ("Nezadali jste reálné číslo, zadejte reálné číslo: ");
            }
            Console.WriteLine();

            Console.Write("Zadejte první člen posloupnosti (reálné číslo): ");
            double a1;
            while(!double.TryParse(Console.ReadLine(), out a1)) {
                Console.Write ("Nezadali jste reálné číslo, zadejte reálné číslo: ");
            }
            Console.WriteLine();
            Console.WriteLine("==================================================================");
            Console.WriteLine("Aritmetická posloupnost");
            Console.WriteLine();
            Console.WriteLine("Diference: {0}, první člen: {1}, Počet členů: {2}", dif, a1, n);
            Console.WriteLine("==================================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Posloupnost:");
            

            //alg
            double a = a1;
            double sum = 0;

            for(int i = 0; i <= n; i++) {
                a = a1;
                a = a + i*dif;
                Console.Write("{0};  ", a);
                sum +=a; 

            }
            
            
            //output
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Součet posloupnosti: {0}", sum);
            Console.WriteLine();
            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine();

        } 
    }
}

