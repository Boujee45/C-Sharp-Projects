using System;
using System.Text;

public class Program
{
    static Random random = new Random();
    
        public static String generatePassword(int length = 12)
        {
        
            const String lower_case = "abcdefghijklmnopqrstuv";
            const String Upper_case = "ABCDEFGHIJKLMNOPQRSTUV";
            const String numbers = "0123456789";
            const String Symbols = "!@#$%^~*&(){}|:<>?`[],";
        
            String allChars = lower_case + Upper_case + numbers + Symbols;

            char[] Password = new char[length];

            for(int i = 0;i < length;i++)
            {
            
                int index = random.Next(allChars.Length);

                Password[i] = allChars[index];
                
            
            }
            return new string(Password);
        }
    public static void Main()
    {
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("                   PASSWORD GENERATOR                    ");
        Console.WriteLine("---------------------------------------------------------\n");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"\n{i + 1}. {generatePassword()}");
        }

        Console.WriteLine("\n---------------------------------------------------------");




        Console.WriteLine("\n\n===========================================================");
        Console.WriteLine("                     PASSWORD GENERATOR                    ");
        Console.WriteLine("===========================================================");

        for (int i = 0; i < 5;i++)
        {
            Console.WriteLine($"\n{i + 1}. {generatePassword2(12)}");
        }

        Console.WriteLine("\n===========================================================");

    }

    
    public static String generatePassword2(int length)
    {
        String lowerCase = "abcdefghijklmnopqrstuvwxyz";
        String upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        String numbers = "0123456789";
        String symbols = "!@#$%^&*(){}|?.,:;~`";

        String allChars = lowerCase + upperCase + numbers + symbols;

        Random rand = new Random();
        StringBuilder password = new StringBuilder();


        for (int i = 0;i < length;i++)
        {
            int index = rand.Next(allChars.Length);

            password.Append(allChars[index]);


        }
        return password.ToString();

    }
}
