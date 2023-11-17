using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moq1
{
    public class BreadOrderingSystem
    {
        private IProductService productService;
        private List<string> orders = new List<string>();

        public BreadOrderingSystem(IProductService productService)
        {
            this.productService = productService;
        }

        public void PlaceOrder()
        {
            // Pobranie dostępnych produktów
            var availableProducts = productService.GetAvailableProducts();

            // Wyświetlenie dostępnych produktów
            Console.WriteLine("\nDostępne produkty:");

            for (int i = 0; i < availableProducts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {availableProducts[i]}");
            }

            // Wybór produktu
            Console.Write("Wybierz numer produktu: ");
            int productIndex;

            while (!int.TryParse(Console.ReadLine(), out productIndex) || productIndex < 1 || productIndex > availableProducts.Count)
            {
                Console.WriteLine("Nieprawidłowy numer produktu. Spróbuj ponownie.");
                Console.Write("\nWybierz numer produktu: ");
            }

            // Pobranie imienia
            Console.Write("Podaj imię: ");
            string firstName = Console.ReadLine();

            // Pobranie nazwiska
            Console.Write("Podaj nazwisko: ");
            string lastName = Console.ReadLine();

            // Pobranie numeru telefonu
            string phoneNumber;
            bool validPhoneNumber = false;

            do
            {
                Console.Write("Podaj numer telefonu: ");
                phoneNumber = Console.ReadLine();

                // Sprawdzenie długości numeru telefonu
                if (phoneNumber.Length == 9)
                {
                    validPhoneNumber = true;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa długość numeru telefonu. Numer powinien składać się z 9 cyfr.");
                }

            } while (!validPhoneNumber);

            // Zapisanie zamówienia
            string orderDetails = $"{firstName} {lastName}, Tel: {phoneNumber}, Produkt: {availableProducts[productIndex - 1]}";
            orders.Add(orderDetails);

            Console.WriteLine($"\nZamówienie zapisane: {orderDetails}\nMożna odebrać swoje zamówienie w naszej piekarni. \nLokalizacja: Poznań, ul. Marca Pola 12,druga klatka od podwórka");
        }

        public void ChangeOrder()
        {
            // Wyświetlenie listy zamówień
            Console.WriteLine("\nLista zamówień:");

            for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {orders[i]}");
            }

            // Wybór zamówienia do edycji
            Console.Write("\nWybierz numer zamówienia do edycji: ");
            int orderIndex;

            while (!int.TryParse(Console.ReadLine(), out orderIndex) || orderIndex < 1 || orderIndex > orders.Count)
            {
                Console.WriteLine("Nieprawidłowy numer zamówienia. Spróbuj ponownie.");
                Console.Write("\nWybierz numer zamówienia do edycji: ");
            }

            var availableProducts = productService.GetAvailableProducts();
            Console.WriteLine("\nDostępne produkty:");

            for (int i = 0; i < availableProducts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {availableProducts[i]}");
            }
            // Pobranie informacji o zamówieniu przed edycją
            string oldOrderDetails = orders[orderIndex - 1];

            // Pobranie numeru produktu
            Console.Write("\nPodaj nowy numer produktu: ");
            int productIndex;

            while (!int.TryParse(Console.ReadLine(), out productIndex) || productIndex < 1 || productIndex > productService.GetAvailableProducts().Count)
            {
                Console.WriteLine("Nieprawidłowy numer produktu. Spróbuj ponownie.");
                Console.Write("\nPodaj nowy numer produktu: ");
            }

            // Pobranie imienia
            Console.Write("Podaj nowe imię: ");
            string firstName = Console.ReadLine();

            // Pobranie nazwiska
            Console.Write("Podaj nowe nazwisko: ");
            string lastName = Console.ReadLine();

            // Pobranie numeru telefonu
            Console.Write("Podaj nowy numer telefonu: ");
            string phoneNumber = Console.ReadLine();

            // Nadpisanie informacji o zamówieniu
            string newOrderDetails = $"{firstName} {lastName}, Tel: {phoneNumber}, Produkt: {productService.GetAvailableProducts()[productIndex - 1]}";
            orders[orderIndex - 1] = newOrderDetails;

            Console.WriteLine("\nZamówienie zostało zmienione:");
            Console.WriteLine($"Stare zamówienie: {oldOrderDetails}");
            Console.WriteLine($"Nowe zamówienie: {newOrderDetails}");
        }

        public void DeleteOrder()
        {
            // Wyświetlenie listy zamówień
            Console.WriteLine("\nLista zamówień:");

            for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {orders[i]}");
            }

            // Wybór zamówienia do usunięcia
            Console.Write("Wybierz numer zamówienia do usunięcia: ");
            int orderIndex;

            while (!int.TryParse(Console.ReadLine(), out orderIndex) || orderIndex < 1 || orderIndex > orders.Count)
            {
                Console.WriteLine("Nieprawidłowy numer zamówienia. Spróbuj ponownie.");
                Console.Write("\nWybierz numer zamówienia do usunięcia: ");
            }

            // Pobranie informacji o zamówieniu przed usunięciem
            string deletedOrderDetails = orders[orderIndex - 1];

            // Usunięcie zamówienia z listy
            orders.RemoveAt(orderIndex - 1);

            Console.WriteLine("Zamówienie zostało usunięte:");
            Console.WriteLine($"\nUsunięte zamówienie: {deletedOrderDetails}");
        }

        public void CheckOrders()
        {
            // Wyświetlenie listy zamówień wraz z numerami
            Console.WriteLine("\nLista zamówień:");

                for (int i = 0; i < orders.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {orders[i]}");
                }
            }


        public void AddProduct()
        {
            Console.Write("\nPodaj nazwę nowego produktu: ");
            string newProduct = Console.ReadLine();

            // Sprawdzenie, czy produkt już istnieje
            while (productService.GetAvailableProducts().Contains(newProduct))
            {
                Console.WriteLine($"Produkt o nazwie '{newProduct}' już istnieje. Podaj inną nazwę.");
                Console.Write("Podaj nazwę nowego produktu: ");
                newProduct = Console.ReadLine();
            }

            productService.AddNewProduct(newProduct);
            Console.WriteLine($"Dodano nowy produkt: {newProduct}");
        }

        public void CheckProducts()
        {
            var availableProducts = productService.GetAvailableProducts();
            Console.WriteLine("\nDostępne produkty:");
            foreach (var product in availableProducts)
            {
                Console.WriteLine(product);
            }
        }
    }
}
