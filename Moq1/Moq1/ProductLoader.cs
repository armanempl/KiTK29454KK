using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moq1
{
    public class ProductLoader
    {
        public static List<string> LoadProductsFromFile(string filePath = "C:\\Users\\Konrad\\source\\repos\\Moq1\\Moq1\\Products.txt", TextWriter @object = null)
        {
            try
            {
                var lines = File.ReadAllLines(filePath).ToList();

                if (lines.Count == 0)
                {
                    Console.WriteLine("Błąd: Brak produktów do dodania w pliku. Uzupełnij plik Products.txt wartościami, aby je dodać");
                    return new List<string>();
                }

                return lines;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd podczas wczytywania produktów z pliku: {ex.Message}");
                return new List<string>();
            }
        }
    }
}
