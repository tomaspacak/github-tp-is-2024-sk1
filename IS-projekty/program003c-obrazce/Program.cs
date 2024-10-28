using System;

class Program {
    static void Main() {

        string again = "a";
        while (again=="a") {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("******** Generátor obrazců **********");
            Console.WriteLine("************ Tomáš Pacák ************");
            Console.WriteLine("*************************************");
            Console.WriteLine();
            Console.WriteLine("===========================");

            //input
            Console.WriteLine("****      *****         ***");
            Console.WriteLine(" *            *         ***");
            Console.WriteLine("  *       *****      ***");
            Console.WriteLine("****      *          ***");
            Console.WriteLine("  1         2            3");
            Console.WriteLine();
            Console.WriteLine("===========================");
            Console.WriteLine();

            Console.Write("Vyberte obrazec k tisku, stisknutím 1 nebo 2 nebo 3: ");
            int obrazec;
            while(!int.TryParse(Console.ReadLine(), out obrazec)) {
                Console.Write ("Nezadali jste celé číslo, zadejte číslo: ");
            }
            if(obrazec < 1 || obrazec > 3) {
                Console.Write ("Zadejte 1 nebo 2 nebo 3: ");
                while(!int.TryParse(Console.ReadLine(), out obrazec)) {
                    Console.Write ("Nezadali jste celé číslo, zadejte číslo: ");
                }
            }
            Console.WriteLine();

            Console.Write("Zadejte šířku v celém čísle: ");
            int widht;
            while(!int.TryParse(Console.ReadLine(), out widht)) {
                Console.Write ("Nezadali jste celé číslo, zadejte číslo: ");
            }
            Console.WriteLine();

            Console.Write("Zadejte výšku v celém čísle: ");
            int height;
            while(!int.TryParse(Console.ReadLine(), out height)) {
                Console.Write ("Nezadali jste celé číslo, zadejte číslo: ");
            }
            Console.WriteLine();

            //algoritmus
            float widhtFl = (float)widht;
            float heightFl = (float)height;
            float pomer = widhtFl / heightFl;
            Console.WriteLine();
            switch (obrazec) {

                // obrazec 1 - učebnice vzor 5
                case 1:
                    for(int i=0; i < widht; i++) {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    for(int i=0; i < heightFl-2; i++) {
                        float prepona = (i+1) * pomer;
                        for(int j=0; j < prepona; j++) {
                            Console.Write(" ");
                        }
                        Console.Write("*");
                        Console.WriteLine();
                    }
                    for(int i=0; i < widht; i++) {
                        Console.Write("*");
                    }

                    break;

                // obrazec 2 - učebnice vzor 10
                case 2:
                    int widhtM = widht - 1;
                    int b = 0;
                    for(int a = 0; a <= height; a+= 4) {
                        for(int i=0; i < widht; i++) {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                        if(a > 1) {b+=4;}
                        
                        if(height >= 2+b) {
                            for(int j=0; j < widhtM; j++) {
                                Console.Write(" ");
                            }
                            Console.Write("*");
                            Console.WriteLine();
                        }
                        if(height >= 3+b) {
                            for(int k=0; k < widht; k++) {
                                Console.Write("*");
                            }
                        }
                        if(height >= 4+b) {
                            Console.WriteLine();
                            Console.WriteLine("*");
                        }
                    }
                    break;

                // obrazec 3 - učebnice vzor 14
                case 3:
                    for (int i = 0; i < height; i++) {

                        for (int j = 0; j < widht; j++) {

                            if (i < height / 2) {
                                if (j < widht / 2) {
                                    Console.Write(' ');
                                }
                                else {
                                    Console.Write('*');
                                }
                            }
                            else {
                                if (j >= widht / 2) {
                                    Console.Write(' ');
                                }
                                else {
                                    Console.Write('*');
                                }
                            }
                        }
                        Console.WriteLine();
                    }
                    break;
                default:
                    Console.Write(":(");
                    again = "a";
                    Console.Clear();
                     Console.Write("Zadali jste na začátku špatný vstup :)");
                    break;

            }

            

            //konec programu/pokracovani
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine();

        } 
    }
}
