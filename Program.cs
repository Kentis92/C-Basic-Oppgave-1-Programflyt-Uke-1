namespace C__Basic_Oppgave_1_Programflyt;

using System;
class Program
{
    static void Main()
    {
        while (true)
        {
        Console.Write("Enter your password. ");
        string password = Console.ReadLine();

        bool hasNumber = false;
        bool hasSpecialChar = false;

        foreach (char c in password)
        {
            if (char.IsDigit(c))
            {
                hasNumber = true;
            }
                else if (!char.IsLetterOrDigit(c))
            {
                hasSpecialChar = true;
            }
        }
        if (password.Length < 12 || !hasNumber || hasSpecialChar)
        {
            Console.WriteLine("Password too weak: Too short and/or using special characters. ");
        }
            else
        {
            Console.WriteLine("Password is strong enough! ");
            break;
            }
        }
    }
}
