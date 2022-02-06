using System;


namespace ConsoleApp2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string sample = "aaa.bbb";
            string[] a = new string[100];
            a = sample.Split(".");

            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(a[i]);

            //Bu proje iyi
            //Changes branch

        }
    }
}
