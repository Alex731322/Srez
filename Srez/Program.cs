using System;

namespace Srez
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str =  Console.ReadLine().Split(' ');
           
            for (int i = 0; i < str.Length ; i++)
            {
                string[] str1 = str[i].Split(',');
                Console.WriteLine($"X: {str1[0].Replace('.',',')} Y:{str1[1].Replace('.',',')} " );
            }
        
        }
    }
}
