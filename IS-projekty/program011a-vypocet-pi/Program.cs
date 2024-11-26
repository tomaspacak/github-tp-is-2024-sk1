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
            Console.WriteLine("Konstanty:");
            Console.WriteLine("  1 - PI");
            Console.WriteLine("  2 - e");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Zvolte konstantu: ");
            int konstanta;
            while(!int.TryParse(Console.ReadLine(), out konstanta)) {
                Console.Write ("Nezadali jste reálné číslo, zadejte: ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Zadejte přesnost (menší hodnota větší přesnost): ");
            double presnost;
            while(!double.TryParse(Console.ReadLine(), out presnost)) {
                Console.Write ("Nezadali jste reálné číslo, zadejte: ");
            }
            Console.WriteLine();

            switch (konstanta) {
                case 1: // PI
                    double i = 1;
                    double znamenko = 1;
                    double piCtvrt = 1;

                    while (1 / i >= presnost) {
                        i += 2;
                        znamenko = znamenko * (-1);
                        piCtvrt = piCtvrt + znamenko * (1 / i);

                        if (znamenko == 1) {
                            Console.WriteLine("Zlomek: +1/{0} ; aktualní hodnota pi = {1}", i, 4 * piCtvrt);
                        } else {
                            Console.WriteLine("Zlomek: -1/{0} ; aktualní hodnota pi = {1}", i, 4 * piCtvrt);
                        }
                    }

                    double pi = 4 * piCtvrt;
                    Console.WriteLine();
                    Console.WriteLine("Hodnota pi = {0}", pi);
                    break;

                case 2: //e
                    double e = 1.0;
                    double faktorial = 1.0;
                    int n = 1;

                    while (1.0 / faktorial >= presnost) {
                        faktorial *= n;
                        e += 1.0 / faktorial;
                        n++;
                    }

                    Console.WriteLine();
                    Console.WriteLine("Hodnota e = {0}", e);
                    break;

                default:
                    Console.WriteLine("Neplatná volba.");
                    break;
            }

            // konec programu/pokracovani/output
            Console.WriteLine();
            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine();

        } 
    }
}
