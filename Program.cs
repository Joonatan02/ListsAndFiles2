using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ListsAndFiles2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\opilane\Data\wishlist.txt";
            List<string> dataFromFile = File.ReadAllLines(filepath).ToList();

            foreach(string line in dataFromFile)
            {
                Console.WriteLine($"Data from file: {line}");
            }
            Console.WriteLine("Enter 3 wishes");
            
            dataFromFile.Add(Console.ReadLine());
            
            File.WriteAllLines(filepath, dataFromFile);
            dataFromFile.Add(Console.ReadLine());

            File.WriteAllLines(filepath, dataFromFile); dataFromFile.Add(Console.ReadLine());

            File.WriteAllLines(filepath, dataFromFile);


        }
    }
}
