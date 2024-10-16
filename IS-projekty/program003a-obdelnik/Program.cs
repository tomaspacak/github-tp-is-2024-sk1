using System;

class Program {
    static void Main() {

        string again = "a";
        while (again=="a") {
            Console.Clear();
            Console.WriteLine("*************************");
            Console.WriteLine("*Vykreslení čtverce/obdélníku*");
            Console.WriteLine("   **************");
            Console.WriteLine("****Tomáš Pacák***********");
            Console.WriteLine("**************************");
            Console.WriteLine();

            Console.Write("Zadejte sirku obrazce (v celem cisle): ");
            int width;
            while(!int.TryParse(Console.ReadLine(), out width)) {
                Console.Write ("Nezadali jste celé číslo");
            }
            Console.WriteLine();
            Console.Write("Zadejte výšku obrazce (v celem cisle): ");
            int height;
            while(!int.TryParse(Console.ReadLine(), out height)) {
                Console.Write ("Nezadali jste celé číslo");
            }
            /* zkrácená verze níže
            int = j;
            while(j <= 10) {
                Console.WriteLine(j);
                j++
            }
            
            for (int i=1; i <= 10; i++ ) {
                Console.WriteLine(i);
            }
            */
            Console.WriteLine();
            for(int i=1; i <= height; i++) {
                for(int j=1; j <= width; j++) {
                    Console.Write("* ");
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(50)); //zpomaleni vypisu
                }
                Console.WriteLine();
            }   
           
            Console.WriteLine();
            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine(); // pro string
        } 
    }
}