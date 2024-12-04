using System;

class Program {
    static void Main() {

        string again = "a";
        while (again=="a") {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("***fibo***");
            Console.WriteLine("  **********Tomáš Pacák***********");
            Console.WriteLine("            **********");
            Console.WriteLine();

            //input
            Console.WriteLine();
            Console.Write("Zadejte počet členů: ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write ("Nezadali jste celé číslo");
            }
            Console.WriteLine();

            Console.Write("0 1");
            //psl
            int a0 = 0;
            int a1 = 1;
            int aa = 0;
            int suma = 0;
            for(int i=0; i <= n+1; i++) {
                aa = a1 + a0;
                a0 = a1;
                a1 = aa;
                suma += aa;
                Console.Write($" {aa}");
            }

            Console.Write($"suma: {suma}");

            
            Console.WriteLine();
            

            //konec programu/pokracovani
            Console.WriteLine();
            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine();

        } 
    }
}
