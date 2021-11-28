using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamReader_Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Logs/Log.txt";
            StreamWriter sw = new StreamWriter(path);
            {
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(rnd.Next(100));
                }
            }
            sw.Close();
            StreamReader sr = new StreamReader(path);
            Console.WriteLine(sr.ReadToEnd());
            sw.Close();
            int sum = 0;
            string [] file_name = File.ReadAllLines("C:\\Users\\79064\\Desktop\\Lab8\\StreamReader_Writer\\bin\\Debug\\Logs\\Log.txt");
            int[] str1 = Array.ConvertAll(file_name, int.Parse);
            for (int i = 0; i < str1.Length; i++)
            {

                sum += str1[i];
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
