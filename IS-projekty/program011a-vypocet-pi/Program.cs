using System;

class Program {
    static void Main() {

        string again = "a";
        while (again=="a") {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("***konvergentní řady***");
            Console.WriteLine("  **********Tomáš Pacák***********");
            Console.WriteLine("            **********");
            Console.WriteLine();

            //input
            Console.WriteLine();
            Console.Write("Zadejte přesnost (menší hodnota větší přesnost): ");
            double presnost;
            while(!double.TryParse(Console.ReadLine(), out presnost)) {
                Console.Write ("Nezadali jste reálné číslo, zadejte: ");
            }
            Console.WriteLine();

            double i = 1;
            double znamenko = 1;
            double piCtvrt = 1;

            while(1/i >= presnost) {

                i += 2;
                znamenko = znamenko * (-1);
                piCtvrt = piCtvrt + znamenko * (1/i);

                if(znamenko == 1) {
                    Console.WriteLine("Zlomek: +1/{0} ; aktualní hodnota pi = {1}", i, 4 * piCtvrt);
                } else {
                    Console.WriteLine("Zlomek: -1/{0} ; aktualní hodnota pi = {1}", i, 4 * piCtvrt);
                }
            }

            double pi = 4*piCtvrt;



            //konec programu/pokracovani/output
            Console.WriteLine();
            Console.WriteLine("Hodnota pi = {0}", pi);
            Console.WriteLine();
            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine();

        } 
    }
}
