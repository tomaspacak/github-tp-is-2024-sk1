using System; //načtení knihovn

class Program {
    static void Main() {

        string again = "a";
        while (again=="a") {
            Console.Clear();
            Console.WriteLine("     **********   ");
            Console.WriteLine("   **************   ");
            Console.WriteLine(" ****************** ");
            Console.WriteLine("*Výpis z řady čísel*");
            Console.WriteLine("********************");
            Console.WriteLine("****Tomáš Pacák*****");
            Console.WriteLine("   **************");
            Console.WriteLine("      *******");

            //vstup hodnot do programu
            /*
            Console.WriteLine("Zadejte první písmeno řady: ");
            int first = int.Parse(Console.ReadLine());  //převedení string na čislo
            Console.WriteLine("Zadali jste tyto hodnoty: ");
            Console.WriteLine("První číslo řady: {0}", first); //číslo nahrazeno proměnou
            */

            //input
            Console.Write("Zadejte první (celé) číslo řady: ");
            int first;
            while(!int.TryParse(Console.ReadLine(), out first)) {
                Console.Write ("Nezadali jste celé číslo, zadejte první číslo řady znovu");
            }

            Console.Write("Zadejte poslední (celé) číslo řady: ");
            int last;
            while(!int.TryParse(Console.ReadLine(), out last)) {
                Console.Write ("Nezadali jste celé číslo, zadejte poslední číslo řady znovu");
            }

            Console.Write("Zadejte diferenc řady: ");
            int step;
            while(!int.TryParse(Console.ReadLine(), out step)) {
                Console.Write ("Nezadali jste celé číslo, zadejte diference řady znovu");
            }

            // Výpis zadaných hodnot
            Console.WriteLine();
            Console.WriteLine("Zadali jste tyto hodnoty");
            Console.WriteLine("První číslo řady: {0}", first);
            Console.WriteLine("Poslední číslo řady: {0}", last);
            Console.WriteLine("Diferenc: {0}", step);

            //výpis z řady
            Console.WriteLine();
            Console.WriteLine("********************");
            Console.WriteLine("    Výpis z řady");
            Console.WriteLine("********************");
            int current = first;
            while(current < last) {
                Console.WriteLine(current);
                current = current + step; //přičtení diference
            }

            

            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine(); // pro string
        } 
    }
}



// See https://aka.ms/new-console-template for more information

