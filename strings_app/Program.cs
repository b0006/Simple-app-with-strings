using System;
using System.Text;
using System.IO;

namespace strings_app
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader reader = new StreamReader("TextFile.txt", Encoding.Default);
            string s = reader.ReadToEnd();
            Console.WriteLine(s);
            Console.WriteLine("\n");

            string[] par = s.Split('!', '.', '?');

            for (int i = 0; i < par.Length; i++)
            {
                if (par[i].IndexOf(',') == -1)
                {
                    Console.WriteLine(par[i].Trim());
                }
            }
            reader.Close();
            Console.ReadKey();
        }
    }
}


