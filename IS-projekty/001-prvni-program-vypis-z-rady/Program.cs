using System; //načtení knihovn

class Program {
    static void Main() {

        string again = "a";
        while (again=="a") {
            //Console.Clear();
            Console.WriteLine("     **********   ");
            Console.WriteLine("   **************   ");
            Console.WriteLine(" ****************** ");
            Console.WriteLine("*Výpis z řady čísel*");
            Console.WriteLine("********************");
            Console.WriteLine("****Tomáš Pacák*****");
            Console.WriteLine("   **************");
            Console.WriteLine("      *******");

            Console.WriteLine("Pro opakování stiskněte klávesu A");
            again = Console.ReadLine();
        } 
    }
}



// See https://aka.ms/new-console-template for more information

