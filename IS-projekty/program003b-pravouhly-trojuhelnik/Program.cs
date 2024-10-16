using System;

class Program {
    static void Main() {

        string again = "a";
        while (again=="a") {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("*Vykreslení pravouhleho trojuhelniku*");
            Console.WriteLine("  **********Tomáš Pacák***********");
            Console.WriteLine("            **********");
            Console.WriteLine();

            Console.WriteLine("  * ");
            Console.WriteLine("  ** ");
            Console.WriteLine("a ****  c");
            Console.WriteLine("  ***** ");
            Console.WriteLine("  ****** ");
            Console.WriteLine("     b ");

            Console.WriteLine();
            Console.Write("Zadejte velikost odvěsny a (v celem cisle): ");
            int a;
            while(!int.TryParse(Console.ReadLine(), out a)) {
                Console.Write ("Nezadali jste celé číslo");
            }
            Console.WriteLine();
            Console.Write("Zadejte velikost odvěsny b (v celem cisle): ");
            int b;
            while(!int.TryParse(Console.ReadLine(), out b)) {
                Console.Write ("Nezadali jste celé číslo");
            }
            
            //algoritmus
            Console.WriteLine();
            
            /* vzhuru nohama, matika nesedi
            for(int i=1; i <= a; i++) {
                for(int j=1; j <= b-i; j++) {
                    Console.Write("*");
                    //System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(50)); //zpomaleni vypisu
                }
                Console.WriteLine();
            }
            */

            /*funhuje jen pro a=b*/
            for(int i=0; i <= a-1; i++) {
                for(int j=b-i; j <= b; j++) {
                    Console.Write("*");
                    
                }
                Console.WriteLine();
            }
            
        
           
            Console.WriteLine();
            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine(); // pro string
        } 
    }
}
