using System;
using System.Diagnostics;
class Program {
    static void Main() {

        string again = "a";
        while (again=="a") {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("***********Řadící metody***************");
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
            Console.WriteLine();

        
            //deklerace pole
            int [] myArray = new int[n]; // určení velikosti pole dle n
            Random randomNumber = new Random();
            Console.WriteLine();
            Console.WriteLine("Náhodná čísla:");
            for(int i=0; i <n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1); //ulozeni cisel do pole a nastaveni rozpětí
                Console.Write("{0}; ", myArray[i]); //vypsani hodnot do pole
            }

            //výběr řadící metody
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Možné řadící metody:");
            Console.WriteLine("   1 - Selection sort");
            Console.WriteLine("   2 - Insertion sort");
            Console.WriteLine("   3 - Shaker sort");
            Console.WriteLine("   4 - Comb sort");
            Console.WriteLine("   5 - Shell sort");
            Console.WriteLine("   6 - Bubble sort");
            Console.WriteLine();
            Console.Write("Vyberte metodu k řazení, stisknutím 1, 2, 3, 4, 5 nebo 6: ");
            Console.WriteLine();
            int metoda;
            while(!int.TryParse(Console.ReadLine(), out metoda)) {
                Console.Write ("Nezadali jste celé číslo, zadejte číslo: ");
            }
            if(metoda < 1 || metoda > 7) {
                Console.Write ("Zadejte číslo zvolené metody: ");
                while(!int.TryParse(Console.ReadLine(), out metoda)) {
                    Console.Write ("Nezadali jste celé číslo, zadejte číslo: ");
                }
            }
            Console.WriteLine();

            
            //proměnné GL
            Stopwatch myStopwatch = new Stopwatch();
            int myCompare = 0;
            int myChange = 0;
            /*n = velikost pole*/

            //algoritmus
            switch (metoda) {

                //selection sort
                case 1:
                    myStopwatch.Start();
                    for(int i =0; i < n-1; i++) {
                        int minNumber = i;
                        for(int j = i+1; j < n; j++) {
                            myCompare++;
                            if(myArray[minNumber] > myArray[j]) {
                                int temp = myArray[minNumber];
                                myArray[minNumber] = myArray[j];
                                myArray[j] = temp;

                                myChange++;
                            }
                            
                        }
                    }
                    myStopwatch.Stop();

                    break;

                //Insertion sort
                case 2:
                    myStopwatch.Start();
                    for(int i =0; i < n-1; i++) {
                        int minNumber = i;
                        for(int j = i+1; j < n; j++) {
                            //myCompare++;
                            if(myArray[j-1] > myArray[j]) {
                                int temp = myArray[j-1];
                                myArray[j-1] = myArray[j];
                                myArray[j] = temp;

                                myChange++;
                            }
                            
                        }
                    }
                    myStopwatch.Stop();
                    

                    break;
                
                //Shaker sort
                case 3:
                    

                    break;

                //Comb sort 
                case 4:
                    

                    break;

                //Shell sort
                case 5:
                    

                    break;

                //Bubble sort
                case 6:
                    myStopwatch.Start();
                    for(int i =0; i < n-1; i++) {

                        for(int j = 0; j < n-i-1; j++) {
                            myCompare++;
                            if(myArray[j] > myArray[j+1]) {
                                int tmp = myArray[j+1];
                                myArray[j+1] = myArray[j];
                                myArray[j] = tmp;
                                myChange++;
                            }
                        }
                    }
                    myStopwatch.Stop();
                    
                    break;

                default:
                    Console.WriteLine("Neplatná volba.");
                    break;
            }

           

            //output
            Console.WriteLine("\n\n\nSeřazené pole");
            for(int i=0; i<n; i++) {
                Console.Write("{0}; ", myArray[i]); 
            }
            Console.WriteLine("\n\nČas potřebný na seřazení pole: {0}", myStopwatch.Elapsed);
            Console.WriteLine("\n\nPočet porovnání: {0}", myCompare);
            Console.WriteLine("\nPočet výměn: {0}", myChange);
            Console.WriteLine();
            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine();

        } 
    }
}

