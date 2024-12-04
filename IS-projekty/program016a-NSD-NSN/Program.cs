using System;

class Program {
    static void Main() {

        string again = "a";
        while (again=="a") {
            Console.Clear();
            razitko();
            ulong num1 = input("zadejte cislo a: ");
            ulong num2 = input("zadejte cislo b: ");
            

            //NSD
            ulong nsd = vypocetNSD(num1, num2);
            
            //NSN
            ulong nsn = vypocetNSN(num1, num2, nsd);
            
            //output
            output(num1, num2, nsd, nsn);

            
            //konec programu/pokracovani
            Console.WriteLine();
            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine();

        } 

        //sideB
        static void razitko() {
            Console.WriteLine("*************************************");
            Console.WriteLine("************************NSD a NSN***");
            Console.WriteLine("  **********Tomáš Pacák***********");
            Console.WriteLine("            **********");
            Console.WriteLine();
        }

        static ulong input(string text) {
            Console.WriteLine();
            Console.Write(text);
            ulong num;
            while(!ulong.TryParse(Console.ReadLine(), out num)) {
                Console.Write ("Nezadali jste přirozené číslo, zadejte: ");
            }
            Console.WriteLine();
            return num;
        }

        static ulong vypocetNSD(ulong num1, ulong num2) {
            //nejvetsi spolecny delitel
            if(num1 == num2) {
                return num1;
            }

            while(num1 != num2) {

               if(num1 > num2) {
                    num1 = num1 - num2;
                } else {
                    num2 = num2 - num1;
                } 
            }
            

            return num1;
        }

        static ulong vypocetNSN(ulong num1, ulong num2, ulong nsd) {
            //nejmensi spolecny nasobek
            return (num1*num2)/nsd;
        }

        static void output(ulong num1, ulong num2, ulong nsd, ulong nsn) {
            
            Console.WriteLine($"NSD čísel {num1} a {num2}: {nsd}");
            Console.WriteLine();
            Console.WriteLine($"NSN čísel {num1} a {num2}: {nsn} ");
        }
    }
}
