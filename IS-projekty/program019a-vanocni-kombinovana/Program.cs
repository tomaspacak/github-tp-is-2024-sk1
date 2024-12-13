using System;
using System.Diagnostics;

class Program {
    static void Main() {

        string again = "a";
        while (again=="a") {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("***vanoce komb***");
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
            int [] myArray = new int[n];
            Random randomNumber = new Random();
            Console.WriteLine();
            Console.WriteLine("Náhodná čísla:");
            for(int i=0; i <n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);
            }

            //min max
            int min=myArray[0];

            int max=myArray[0];

            int sum =0;
            int prumer = 0;
            for(int i=0; i < n; i++) {
                //min
                if(myArray[i] < min) {

                    min=myArray[i];
                }

                //max
                if(myArray[i] > max) {

                    max=myArray[i];
                }
                sum+= myArray[i];

            }
            prumer = sum / n;
            float prumerKom = (float) sum / n;
            float prumerZbytek= (float) sum % n;
            Console.WriteLine();
            Console.WriteLine($"Minimum: {min}, maximum: {max}, součet {sum}, průměr celé číslo: {prumer}, průměr zbytek: {prumerZbytek}");
            
            //sorty
            int[] array2 = new int[n];
            for(int i = 0; i<n; i++) {
                array2[i] = myArray[i];
            }
            //Comb Sort
            bool swapped = false;
            int gap = myArray.Length;
            int changeC = 0;
            Stopwatch timeC = Stopwatch.StartNew();
            while(gap!=1 || swapped) {
                gap = (int)(gap / 1.33);
                swapped = false;
                if(gap < 1) {
                    gap=1;
                }
                for(int i = 0; i + gap < myArray.Length; i++) {
                    if(myArray[i] < myArray[i+gap]) {
                        int tmp = myArray[i];
                        myArray[i] = myArray[i + gap];
                        myArray[i + gap] = tmp;
                        changeC++;
                        swapped = true;
                    }
                }
            }
            timeC.Stop();

            //Insertion Sort
            int changeI = 0;
            Stopwatch timeI = Stopwatch.StartNew();
            for (int i = 0; i < array2.Length - 1; i++) {
                int j = i + 1;
                int tmp = array2[j];

                while (j > 0 && tmp > array2[j - 1]) {
                    array2[j] = array2[j - 1];
                    changeI++;
                    j--;
                }
                array2[j] = tmp;
            }
            timeI.Stop();
            Console.WriteLine();
            Console.WriteLine($"Comb sort - počet výměn: {changeC}, čas: {timeI.Elapsed}");
            Console.WriteLine($"Insertion sort - počet výměn: {changeI}, čas: {timeC.Elapsed}");
            Console.WriteLine();
            //shell
            /*int gap = myArray.Length / 2;
            while (gap > 0)
            {
                for (int i = 0; i < myArray.Length - gap; i++) {
                    int j = i + gap;
                    int tmp = myArray[j];

                    while (j >= gap && tmp > myArray[j - gap]) {
                        myArray[j] = myArray[j - gap];
                        j -= gap;
                    }
                    myArray[j] = tmp;
                }
                if (gap == 2) {
                    gap = 1;
                } else {
                    gap = (int)(gap / 2.2);
                }
            }*/

            //shaker
           /* for (int i = 0; i < myArray.Length / 2; i++) {
                bool swapped = false;
                for (int j = i; j < myArray.Length - i - 1; j++) {
                    if (myArray[j] < myArray[j + 1]) {
                        int tmp = myArray[j];
                        myArray[j] = myArray[j + 1];
                        myArray[j + 1] = tmp;
                        swapped = true;
                    }
                }

                for (int j = myArray.Length - 2 - i; j > i; j--) {
                    if (myArray[j] > myArray[j - 1]) {
                        int tmp = myArray[j];
                        myArray[j] = myArray[j - 1];
                        myArray[j - 1] = tmp;
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }*/
            //selection
           /* for (int i = 0; i < myArray.Length - 1; i++) {
                int maxIndex = i;
                for (int j = i + 1; j < myArray.Length; j++) {
                    if (myArray[j] > myArray[maxIndex]) maxIndex = j;
                }
                int tmp = myArray[i];
                myArray[i] =myArray[maxIndex];
                myArray[maxIndex] = tmp;
            }*/


            Console.WriteLine();
            Console.WriteLine("serazene pole: ");
            for(int i = 0; i < n; i++) {
                Console.Write($"{myArray[i]}, ");
            }
            Console.WriteLine();

            //obrazec
            
            for(int i=prumer; i >= 0; i--){

                for(int j=0; j <= prumer-i ; j++) {

                    //odsazeni
                    for(int o = prumer+1-j; o >= 0; o-- ) {
                        Console.Write(" ");
                    }

                    for(int h =0; h < j+1; h++) {
                        Console.Write("* ");
                    }
                    Console.WriteLine();

                }
            }
            
            for(int i=0; i<prumer; i++){
                for(int o =0; o<prumer-1;o++){
                    Console.Write(" ");
                }
                for(int j =0; j<prumer-1;j++){
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine();

        } 
    }
}
