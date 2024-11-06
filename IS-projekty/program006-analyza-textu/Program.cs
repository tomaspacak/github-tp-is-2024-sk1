using System; //načtení knihovn

class Program {
    static void Main() {

        string again = "a";
        while (again=="a") {
            Console.Clear();
            Console.WriteLine("********************");
            Console.WriteLine("***Analýza textu***");
            Console.WriteLine("********************");
            Console.WriteLine("****Tomáš Pacák*****");
            Console.WriteLine("   **************");

            //input
            Console.Write("Zadejte text: ");
            string myText = Console.ReadLine();
           
            string samohlasky = "aáeéěiíouůúy";
            string souhlasky = "bcčdďfghjklmnňprqrřsštťvwxzž";
            string cislice = "0123456789";

            int Pocetsamohlasky = 0;
            int Pocetsouhlasky = 0;
            int PocetostatniZnaky = 0;
            int Pocetcislice = 0;

            foreach(char znak in myText) {
                if(souhlasky.Contains(znak)) {
                    Pocetsouhlasky++;
                }
                else if(samohlasky.Contains(znak)) {
                    Pocetsamohlasky++;
                }
                else if(cislice.Contains(znak)) {
                    Pocetcislice++;
                }
                else {
                    PocetostatniZnaky++;
                }
            }

            // Výpis zadaných hodnot
            Console.WriteLine();
            Console.WriteLine(myText);
            Console.WriteLine("První znak: {0}", myText[0]);
            Console.WriteLine("Počet znaků: {0}", myText.Length);
            Console.WriteLine("Počet samohlásek: {0}", Pocetsamohlasky);
            Console.WriteLine("Počet souhlásek: {0}", Pocetsouhlasky);
            Console.WriteLine("Počet číslic: {0}", Pocetcislice);
            Console.WriteLine("Počet ostatních znaků: {0}", PocetostatniZnaky);
            

            

            Console.WriteLine("Pro opakování stiskněte klávesu a");
            again = Console.ReadLine(); // pro string
        } 
    }
}
