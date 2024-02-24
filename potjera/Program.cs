using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace potjera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "pitanja.txt");

            string[] lines = File.ReadAllLines(path, Encoding.UTF8);

            Random rnd = new Random();
            int line_number = rnd.Next(lines.Length);
            string answer = "";

            while (true)
            {
                line_number = rnd.Next(lines.Length);
                for(int i = 0; i < lines[line_number].Length; i++) 
                {
                    if (lines[line_number][i] != '?')
                        Console.Write(lines[line_number][i]);
                    else
                    {
                        answer = lines[line_number].Substring(i + 1);
                        break;
                    }
                }
                Console.Write('?');
                Console.ReadLine();
                Console.WriteLine(answer);
                Console.ReadLine();
            }

        }
    }
}
