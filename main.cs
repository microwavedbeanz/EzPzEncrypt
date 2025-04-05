using System;
using System.Text;
using System.Threading;

class Program
{
    static void Main()
    {
        string title = @"

░▒▓████████▓▒░▒▓████████▓▒░▒▓████████▓▒░▒▓███████▓▒░ ░▒▓██████▓▒░░▒▓███████▓▒░░▒▓███████▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░ 
░▒▓█▓▒░             ░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░  ░▒▓█▓▒░     
░▒▓█▓▒░           ░▒▓██▓▒░░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░  ░▒▓█▓▒░     
░▒▓██████▓▒░    ░▒▓██▓▒░  ░▒▓██████▓▒░ ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓███████▓▒░░▒▓███████▓▒░ ░▒▓██████▓▒░   ░▒▓█▓▒░     
░▒▓█▓▒░       ░▒▓██▓▒░    ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░         ░▒▓█▓▒░      ░▒▓█▓▒░     
░▒▓█▓▒░      ░▒▓█▓▒░      ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░         ░▒▓█▓▒░      ░▒▓█▓▒░     
░▒▓████████▓▒░▒▓████████▓▒░▒▓████████▓▒░▒▓█▓▒░░▒▓█▓▒░░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░         ░▒▓█▓▒░      ░▒▓█▓▒░     
                                                                                                                                                                                                                           
######################################################################################################################
|                                                                                                                    |
|                                                   [1] Encrpyt                                                      |
|                                                                                                                    |
|                                                   [2] Decrypt                                                      |
|                                                                                                                    |
######################################################################################################################

Enter Choice:";
        Console.WriteLine(title);
        string input = Console.ReadLine();

        if (int.TryParse(input, out int menuChoice))
        {
            if (menuChoice == 1)
            {
                Console.WriteLine("Enter text To Be Encrypted:");
                string plaintext = Console.ReadLine();
                StringBuilder result = new StringBuilder();
                Random random = new Random();
                int randomNumber = random.Next(10,100);
                for (int i = 1; i<=randomNumber; i++){
                    foreach (Char C in plaintext){
                        double asciiValue = (int)C;
                        asciiValue = (int)Math.Round(asciiValue*randomNumber+randomNumber);
                        char EncyrptedCharacter = (char)asciiValue;
                        result.Append(EncyrptedCharacter);
                    }
                }
                string placeholder = randomNumber.ToString();
                foreach (Char C in placeholder){
                        double asciiValue = (int)C;
                        asciiValue = (int)Math.Round(asciiValue*42);
                        char EncyrptedCharacter = (char)asciiValue;
                        result.Append(EncyrptedCharacter);
                    }
                string finalString = result.ToString();
                Console.WriteLine(finalString);

            }
                
            /*else if (menuChoice == 2)
            {   
                Console.WriteLine("Enter text To Be Decrypted:");
                string encyptedtext = Console.ReadLine();
                string key = encyptedtext.Substring(encyptedtext.Length -2);
                foreach (Char C in key){
                    
                }
            }
            
            else
            {
                Console.WriteLine("Invalid Option");
            }*/

        }
        

    }   

}

