using System;
using System.Diagnostics;

namespace gerador_de_senha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("password size: ");
            int size = int.Parse(Console.ReadLine());
            Console.Clear();

            Random random = new Random();
            int maxPassword = size;
            string allCaracters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string password = "";
            for(int i = 1;i <= maxPassword; i++)
            {
                int numberRandom = random.Next(0, allCaracters.Length);
                char caracterRandom = allCaracters[numberRandom];
                Console.WriteLine(caracterRandom);
                Console.Clear();
                password += caracterRandom;                
            }
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Normal;
            ps.Arguments = "/c msg * Senha Gerada: " + password;
            Process.Start(ps);
        }
    }
}
