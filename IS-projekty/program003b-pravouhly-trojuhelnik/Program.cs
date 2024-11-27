using System;

class Program {
    static void Main() {

        string again = "a";
        while (again=="a") {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("*Vykreslení pravouhleho trojuhelniku*");
            Console.WriteLine("  **********Tomáš Pacák***********");
            Console.WriteLine("            **********");
            Console.WriteLine();
            Console.WriteLine("  * ");
            Console.WriteLine("  ** ");
            Console.WriteLine("  *** ");
            Console.WriteLine("a ****  c");
            Console.WriteLine("  ***** ");
            Console.WriteLine("  ****** ");
            Console.WriteLine("     b ");

            //input
            Console.WriteLine();
            Console.Write("Zadejte velikost odvěsny a v celém čísle: ");
            int a;
            while(!int.TryParse(Console.ReadLine(), out a)) {
                Console.Write ("Nezadali jste celé číslo");
            }
            Console.WriteLine();
            Console.Write("Zadejte velikost odvěsny b v celém čísle: ");
            int b;
            while(!int.TryParse(Console.ReadLine(), out b)) {
                Console.Write ("Nezadali jste celé číslo");
            }
            Console.WriteLine();

            //algoritmus
            int ab = a - b;
            bool ABeven = Convert.ToBoolean(ab);
            if(!ABeven) {
                for(int i=0; i <= a-1; i++) {
                    for(int j=b-i; j <= b; j++) {
                        Console.Write("*");
                        
                    }
                    Console.WriteLine();
                }  
            } /*else if(a < b ) {
                for(int i=0; i <= a-2; i++) {
                    for(int j=b-i; j <= b; j++) {
                        Console.Write("*");
                        
                    }
                    Console.WriteLine();
                }
                for(int c=1; c <= b; c++) {
                    Console.Write("*");
                        
                }
            }*/ else {
                float aFl = (float)a;
                float bFl = (float)b;
                //2D POLE
                string[][] grid = new string[(int)aFl][];
                for (int r = 0; r < grid.Length; r++) {
                    string[] col = new string[(int)bFl];
                    for (int c = 0; c < col.Length; c++) {
                         col[c]=" "; 
                    }
                    grid[r] = col;
                }

                //STRANY
                //přepona (c)
                float pomer = bFl / aFl;
                for (int i = 0; i < aFl; i++) {
                    float prepona = pomer * i;
                    double hvezdy = Math.Round(prepona);
                    if (hvezdy > b - 1) {
                        hvezdy = b - 1;
                    }
                    
                    while (hvezdy != 0) {
                        grid[i][(int)hvezdy] = "*";
                        hvezdy--;
                    }
                }
                //odvěsna (b)
                for (int c = 0; c < bFl; c++) {
                    grid[(int)aFl - 1][c] = "*";
                }
                //odvěsna (a)
                for (int r = 0; r < aFl; r++) {
                    grid[r][0] = "*";
                }

                //VÝPLŇ
                foreach (string[] i in grid) {
                    foreach (string j in i) { 
                        Console.Write(j); 
                    }
                    Console.WriteLine();
                }   
            }
            
            //output
            Console.WriteLine();
            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine();

            
            //flow
            /*funguje pro a=b*//*
            for(int i=0; i <= a-1; i++) {
                for(int j=b-i; j <= b; j++) {
                    Console.Write("*");
                    
                }
                Console.WriteLine();
            }*/

            /* funguje pro a<b ale vzhuru nohama a bez spicky*/
            /*int backupB = b;
            for(int i=1; i <= a; i++) {

                for(int j=1; j <= backupB; j++) {
                    Console.Write("*");
                }
                Console.WriteLine(); 
                backupB--;
            }*/

            /*funguje pro a<b*//*
            for(int i=0; i <= a-2; i++) {
                for(int j=b-i; j <= b; j++) {
                    Console.Write("*");
                    
                }
                Console.WriteLine();
            }
            for(int c=1; c <= b; c++) {
                Console.Write("*");
                    
            }*/

        } 
    }
}

//Mozne reseni

/*

*/
