using System;

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
            Console.WriteLine($"Minimum: {min}, maximum: {max}, součet {sum}, průměr celé číslo: {prumer}, průměr zbytek: {prumerZbytek}, průměr: {prumerKom}");
            
            //sorty

            //Comb Sort

            //Insertion Sort

            //obrazec
            int c = -1;
            for(int i=prumer; i >= 0; i--){

                for(int j=0; j <= prumer-i ; j++) {

                    //odsazeni
                    for(int o = prumer+1; o >= 0; o-- ) {
                        Console.Write(" ");
                    }
                    /*int o = prumer+1;
                    while(o >= prumer-j){
                        Console.Write(" ");
                    }*/
                    //troj
                    for(int h =prumer; h >= prumer; h--) {
                        Console.Write("*");
                    }
                    /*int h =prumer;
                    while(h >= prumer-i){
                        Console.Write("*");
                    }*/

                }
                Console.WriteLine();
                c--;
            }

            Console.WriteLine();
            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine();

        } 
    }
}
