using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Moq1
{
    class Program
    {
        static void Main()
        {
            // Początkowe wczytanie produktów z pliku tekstowego
            List<string> initialProducts = ProductLoader.LoadProductsFromFile("C:\\Users\\Konrad\\source\\repos\\Moq1\\Moq1\\Products.txt");

            var productService = new ProductService(initialProducts);

            // Utworzenie obiektu, który będzie używał ProductService do obsługi operacji na produktach
            var breadOrderingSystem = new BreadOrderingSystem(productService);

            while (true)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("1. Zamów chleb");
                Console.WriteLine("2. Zmień zamówienie");
                Console.WriteLine("3. Usuń zamówienie");
                Console.WriteLine("4. Sprawdź dodane zamówienia");
                Console.WriteLine("5. Dodaj nowy produkt");
                Console.WriteLine("6. Sprawdź listę produktów");
                Console.WriteLine("0. Wyjście");

                Console.Write("Wybierz opcję: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        breadOrderingSystem.PlaceOrder();
                        break;
                    case "2":
                        breadOrderingSystem.ChangeOrder();
                        break;
                    case "3":
                        breadOrderingSystem.DeleteOrder();
                        break;
                    case "4":
                        breadOrderingSystem.CheckOrders();
                        break;
                    case "5":
                        breadOrderingSystem.AddProduct();
                        break;
                    case "6":
                        breadOrderingSystem.CheckProducts();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                        break;
                }
            }
        }

    }

    
}
