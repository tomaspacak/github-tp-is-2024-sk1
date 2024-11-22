using System;

class Program {
    static void Main() {

        string again = "a";
        while (again=="a") {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("************************Intervaly***");
            Console.WriteLine("  **********Tomáš Pacák***********");
            Console.WriteLine("            **********");
            Console.WriteLine();

            //input
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet generovaných čísel znovu: ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
            }

            Console.Write("Zadejte počet intervalů (celé číslo): ");
            int intPocet;
            while(!int.TryParse(Console.ReadLine(), out intPocet)) {
                Console.Write("Nezadali jste celé číslo. Zadejte celé číslo: ");
            }

            Console.WriteLine();
            Console.WriteLine("====================================================");
            Console.WriteLine("Zadané hodnoty:");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("====================================================");
            Console.WriteLine();

            //alg
            int[] myArray = new int[n];
            Random randomNumber = new Random();

            double[] arrayInt = new double[intPocet];
            
            Console.WriteLine("Náhodná čísla:");
            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);
            }

            double krok = (double)(hm - dm) / intPocet;
            double krokProc = krok / 100;
            //krok = Math.Ceiling(krok);
            
            for(int j=0; j<intPocet; j++) {
                for(int i=0; i<n; i++) {

                    int c = 0;
                    if((double)(hm - dm) % intPocet == 0) {
                        if(j != 0) {
                            c=1;
                        }
                    }
                    
                    if(myArray[i] <= dm+krok*(j+1) && myArray[i] >= (dm+krok*(j))+c) {
                        arrayInt[j]++;
                    }
                }
            }
            

           //výstup
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===================================================");
            Console.WriteLine("Počet čísel v intervalech:");
            Console.WriteLine();
            for (int i = 0; i < intPocet; i++) {
                int c = 0;
                if((double)(hm - dm) % intPocet == 0) {
                    if(i != 0) {
                        c=1;
                    }
                }
                Console.WriteLine("Interval <{0};{1}> : {2}",(dm+krok*i)+c, dm+krok*(i+1), arrayInt[i]);
            }
            Console.WriteLine("===================================================");
            
            /*
            Console.WriteLine("\nInterval <{0}, {1}>: {2}", dm, 0.25 * hm, int1);
            Console.WriteLine("Interval <{0}, {1}>: {2}", 0.25 * hm + 1, 0.5 * hm, int2);
            Console.WriteLine("Interval <{0}, {1}>: {2}", 0.5 * hm + 1, 0.75 * hm, int3);
            Console.WriteLine("Interval <{0}, {1}>: {2}", 0.75 * hm  + 1, hm, int4);*/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();

        } 
    }
}

