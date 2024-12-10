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
            ulong a0 = 0;
            ulong a1 = 1;
            ulong aa = 0;
            ulong suma = 1;
            ulong[] array = new ulong[n-2];
            for(int i=0; i < n-2; i++) {
                aa = a1 + a0;
                array[i] = aa;
                a0 = a1;
                a1 = aa;
                suma += aa;
                Console.Write($" {aa}");
            }
            Console.WriteLine();
            Console.WriteLine($"{n}. člen posloupnosti: {array[n-3]}");
            Console.WriteLine($"součet posloupnosti do {n}. prvku: {suma}");

            
            Console.WriteLine();
            

            //konec programu/pokracovani
            Console.WriteLine();
            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine();

        } 
    }
}
