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
                    for (int i = 1; i < n; i++) 
                    {
                        int key = myArray[i]; 
                        int j = i - 1;

                        
                        while (j >= 0 && myArray[j] > key)
                        {
                            myCompare++; 
                            myArray[j + 1] = myArray[j];
                            j--;
                            myChange++;
                        }

                        myArray[j + 1] = key;
                    }
                    myStopwatch.Stop();
                    break;
                
                //Shaker sort
                case 3:
                    myStopwatch.Start();
                    for(int i =0; i < n/2; i++) {

                        //tam
                        for(int j = 0; j < n-i-1; j++) {
                            myCompare++;
                            if(myArray[j] > myArray[j+1]) {
                                int tmp = myArray[j+1];
                                myArray[j+1] = myArray[j];
                                myArray[j] = tmp;
                                myChange++;
                            }
                        }

                        //zpět
                        for(int j = n-1-i; j > 0; j--) {
                            myCompare++;
                            if(myArray[j] < myArray[j-1]) {
                                int tmp = myArray[j];
                                myArray[j] = myArray[j-1];
                                myArray[j-1] = tmp;
                                myChange++;
                            }
                        }
                    }
                    myStopwatch.Stop();

                    break;

                //Comb sort 
                case 4:
                    myStopwatch.Start();
                    int gap = n;
                    const double shrinkFactor = 1.3;
                    bool swapped = true;

                    while (gap > 1 || swapped)
                    {
                        if (gap > 1)
                        {
                            gap = (int)(gap / shrinkFactor);
                        }

                        swapped = false;

                        for (int i = 0; i + gap < n; i++)
                        {
                            myCompare++;
                            if (myArray[i] > myArray[i + gap])
                            {
                                int temp = myArray[i];
                                myArray[i] = myArray[i + gap];
                                myArray[i + gap] = temp;
                                myChange++;
                                swapped = true;
                            }
                        }
                    }
                    myStopwatch.Stop();
                    

                    break;

                //Shell sort
                case 5:
                    myStopwatch.Start();
                    int interval = n / 2; 

                    while (interval > 0)
                    {
                        for (int i = interval; i < n; i++)
                        {
                            int temp = myArray[i];
                            int j = i;

                            
                            while (j >= interval && myArray[j - interval] > temp)
                            {
                                myCompare++;
                                myArray[j] = myArray[j - interval];
                                j -= interval;
                                myChange++;
                            }

                            myArray[j] = temp;
                        }

                        interval /= 2; 
                    }
                    myStopwatch.Stop();

                    

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
            Console.WriteLine("\n\n");
            Console.WriteLine("====================================================");
            Console.WriteLine("Čas potřebný na seřazení pole: {0}", myStopwatch.Elapsed);
            Console.WriteLine("\nPočet porovnání: {0}", myCompare);
            Console.WriteLine("\nPočet výměn: {0}", myChange);
            Console.WriteLine("====================================================");
            Console.WriteLine("\n\n");
            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine();

        } 
    }
}

