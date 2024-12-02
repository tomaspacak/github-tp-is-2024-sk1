using System;
using System.Threading.Tasks.Dataflow;

class Program {
    static void Main() {

        string again = "a";
        while (again=="a") {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("***Testova uloha 1***");
            Console.WriteLine("  **********Tomáš Pacák***********");
            Console.WriteLine("            **********");
            Console.WriteLine();

            //input
            Console.WriteLine();
            Console.Write("Zadejte počet generovaných čísel v celém čísle: ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write ("Nezadali jste celé číslo");
            }
            Console.WriteLine();
            Console.Write("Zadejte dolní mez v celém čísle: ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write ("Nezadali jste celé číslo");
            }
            Console.WriteLine();
            Console.Write("Zadejte horní mez v celém čísle: ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write ("Nezadali jste celé číslo");
            }
            Console.WriteLine();
            Console.WriteLine("============================================================");
            Console.WriteLine("Zadané hodnoty:");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("============================================================");

        
            //deklerace pole
            int[] myArray = new int[n];
            Random randomNumber = new Random();
            Console.WriteLine();
            Console.WriteLine("Náhodná čísla:");
            for(int i=0; i <n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);
            }
            //start

            //1 MAX, MIN + POZICE
            //max
            int maximum = myArray[0];
            List<int> maxPozice = new List<int>();
            int maxPocet = 0;
            //min
            int min = myArray[0];
            List<int> minPozice = new List<int>();
            int minPocet = 0;                                //musi byt nula ne 1

            int poziceCounter = 0;

            for(int i=0; i < n; i++) {                          // ne <=
                //max
                if(myArray[i] > maximum) {
                    maxPocet = 0;
                    maximum = myArray[i];
                    maxPocet++;
                    maxPozice.Clear();
                    maxPozice.Add(i+1);
                } else if(myArray[i] == maximum) {
                    maxPocet++;
                    maxPozice.Add(i+1);
                }

                //min
                if(myArray[i] < min) {
                    minPocet = 0;
                    min = myArray[i];
                    minPocet++;
                    minPozice.Clear();
                    minPozice.Add(i+1);
                } else if(myArray[i] == min) {
                    minPocet++;
                    minPozice.Add(i+1);
                    
                }
                



                
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Maximum: {0}, počet: {1}, pozice: {2}", maximum, maxPocet, string.Join(", ", maxPozice));
            Console.WriteLine("Minimum: {0}, počet: {1}, pozice: {2}", min, minPocet, string.Join(", ", minPozice));
            

            //2 Shaker sort
            for(int i = 0; i < myArray.Length / 2; i++) {
                bool swapped = false;

                for (int j = i; j < myArray.Length - i - 1; j++) {

                    if(myArray[j] < myArray[j+1]) {
                        int tmp = myArray[j];
                        myArray[j] = myArray[j+1];
                        myArray[j+1] = tmp;
                        swapped = true;
                    }
                    
                }

                for (int j = myArray.Length - 2 - i; j > i; j--) {
                    if(myArray[j] > myArray[j-1]) {
                        int tmp = myArray[j];
                        myArray[j] = myArray[j-1];
                        myArray[j-1] = tmp;
                        swapped = true;
                    }
                }

                if (!swapped) break;
            }

            Console.WriteLine("");
            Console.Write("Seřazené pole: ");
            for(int i = 0; i < myArray.Length; i++) {
                Console.Write(" {0},", myArray[i]);
            }
            
            //3 top2, top3, down4
            //NEJVETŠÍ ČÍSLA
            int top2C =0;
            int top2 = myArray[0];
            int top3 = myArray[0];
            int top3C = 0;
            for(int i = 0; i < myArray.Length-1; i++) {
                bool top2F = false;
                bool top3F = false;
                //druhy nejvetsi
                if(myArray[i] != myArray[i+1]) {
                    top2C++;
                }
                if(top2C == 1) {
                    top2 = myArray[i+1];
                    top2F = true;
                }

                //treti nejvetsi
                if(myArray[i] != myArray[i+1]) {
                    top3C++;
                }
                if(top3C == 2) {
                    top3 = myArray[i+1];
                    top3F = true;
                }

                if(top2F && top3F == true) {
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Druhé největší číslo: {0}, třetí největší číslo: {1}", top2, top3);

            //čtvrtý nejmenší číslo
            int down4 = myArray[0];
            int down4C = 0;
            for(int i = myArray.Length-1; i > 1; i-- ) {
                if(myArray[i] != myArray[i-1]) {
                    down4C++;
                }
                if(down4C == 3) {
                    down4 = myArray[i-1];
                    break;
                }
            }
            Console.WriteLine("Čtvrté nejmenší číslo: {0}", down4);
            Console.WriteLine();


            //4 MEDIAN - cislo uprostřed
            double arLenght = myArray.Length;
            double median = myArray[0];
            if(arLenght % 2 != 0) {
                median = myArray[(int)arLenght/2];
            } else {
                int med1 = (int)arLenght / 2;
                int med2 = (int)(arLenght / 2)-1;
                median = (myArray[med1]+myArray[med2]) / 2.0;
            }
            Console.WriteLine("Medián: {0}", median);
            

            Console.WriteLine();
            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine();

        } 
    }
}
