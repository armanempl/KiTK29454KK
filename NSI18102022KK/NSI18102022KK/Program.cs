using System;

namespace NSI18102022KK
{
    //podstawa - container do kreowania stosu i kolejki
    // komentarze są prawdopodobnie dla autora żeby nie pogubił się przy sprawozdaniu
    abstract class Container<S>
    {
        protected int pointer = -1;
        protected S[] buffer = new S[10]; // tu na bdb definicja jakiego rodzaju zmiennych użyć w container, do zapamiętania S to zmienna typu
        protected int rozmiar = 10; // rozmiar container - domyślnie 10
        public abstract void write(); // wypisywanko
        public abstract S pop();
        public abstract void push(S value);
        public Container() {} // na bdb definiowanie rozmiaru kontenera
        public Container(int roozmiar)
        {
            if (rozmiar > 0)
            {
                buffer = new S[roozmiar];
                rozmiar = roozmiar; // kapitalne nazwanie rozmiaru kontenera, świetny pomysł
            }
        }
        //niestety trzeba tutaj zdefiniować clear, getCount, isEmpty i isFull bo klasy się buntują jak tego tutaj nie zrobię
        public void clear() //czyszczenie buforów, tworzenie nowego containera
        {
            buffer = new S[10];
            pointer = -1;
        }

        public int getCount() //wypisanie ilości zapełnionych buforów w containerze
        {
            return pointer + 1;
        }
        public Boolean isEmpty() //wypisanie, czy container jest pusty, bool tu nie zadziała
        {
            if (pointer == -1)
            {
                return true;
            } else
            {
                return false;
            }

        }
        public Boolean isFull() { //wypisanie, czy container jest pełny
            if (pointer == rozmiar - 1)
            {
                return true;
            }
            else {
                return false;
            }
        }

    }

    class Stos<S> : Container<S> //<S> definiuje rozmiar stosu
    {
        public Stos(int rozmiar) : base(rozmiar) { } //inicjalizacja nowego stosu
        public override S pop()
        {
            if (pointer < 0)
            {
                pointer = 0;
            }
            S popper = buffer[pointer];
            pointer--;
            return popper;
        }
        public override void push(S value)
        {
            pointer++;
            if (pointer < rozmiar)
            {
                buffer[pointer] = value;
            }
            else
            {
                pointer = rozmiar - 1;
            }
        }

        public override void write()
        {
            //Console.WriteLine("Stos: ");
            for (int i = 0; i <= pointer; i++)
            {
                Console.Write(buffer[i] + " ");
            }
            Console.WriteLine(" ");
        }

    }
        class Kolejka<S> : Container<S> //<S> definiuje rozmiar kolejki
        {
            public Kolejka(int rozmiar) : base(rozmiar) { } //inicjalizacja nowej kolejki
            public override S pop()
            {
                S popper2 = buffer[0];
                for (int i = 1; i <= pointer; i++)
                {
                    buffer[i - 1] = buffer[i];
                }
                pointer--;
                if (pointer < -1)
                {
                    pointer = -1;

                }
                return popper2;
            }
            public override void push(S value)
            {
                pointer++;
                if (pointer < rozmiar)
                {
                    buffer[pointer] = value;
                }
                else
                {
                    pointer = rozmiar - 1;
                }
            }
            public override void write()
            {
               // Console.WriteLine("Kolejka: ");
                for (int i = 0; i <= pointer; i++)
                {
                    Console.Write(buffer[i] + " ");
                }
                Console.WriteLine(" ");
            }
        }

        class Program
        {
            static void Main()
            {

            Console.WriteLine("Niezawodność systemów informatycznych - Stos i kolejka - zadanie z 20.10.2022 r. - Konrad Kulka - P1");
            Console.WriteLine(" ");
            /*Console.WriteLine("Jakiego typu zmiennych ma być zapełniona kolejka?");
            string typzmiennych;
            int typzmiennychnaint;
            typzmiennych = console.readline();
            typzmiennychnaint = convert.toint32(typzmiennych);*/
            Stos<int> s = new Stos<int>(10); //zdefiniowanie nowego stosu o rozmiarze 10 i typie int
            Console.WriteLine("Zapełnianie stosu...");
            for (int i = 0; i < 10; i++) //zamiast wypisywania przez użytkownika do stosu dodaje się liczby od 1 do 10
            {
                s.push(i);
                Console.WriteLine("Obecna liczba zapełnionych buforów: " + s.getCount());
            }
            Console.WriteLine(" ");
            Console.WriteLine("Stos wygląda następująco: "); 
            s.write();
            Console.WriteLine(" ");
            bool ifempty = s.isEmpty();
            bool iffull = s.isFull();
            if (ifempty == true) //na db sprawdzenie czy stos jest pusty
            {
                Console.WriteLine("Stos jest pusty");
            } else
            {
                Console.WriteLine("Stos nie jest pusty");
            }
            if (iffull == true) //na db sprawdzenie czy stos jest pełny
            {
                Console.WriteLine("Stos jest pełny");
            }
            else
            {
                Console.WriteLine("Stos nie jest pełny");
            }
            s.pop(); //usunięcie ze stosu wartości wyżej
            Console.WriteLine(" ");
            Console.WriteLine("Po usunięciu stos wygląda następująco: ");
            s.write();
            Console.WriteLine(" ");

            Kolejka<int> k = new Kolejka<int>(10); //zdefiniowanie nowej kolejki o rozmiarze 10  i typie int
            Console.WriteLine("Zapełnianie kolejki...");
            for (int i = 0; i < 10; i++) //zamiast wypisywania przez użytkownika do stosu dodaje się liczby od 1 do 10
            {
                k.push(i);
                Console.WriteLine("Obecna liczba zapełnionych buforów: " + k.getCount());
            }
            Console.WriteLine(" ");
            Console.WriteLine("Kolejka wygląda następująco: ");
            k.write();
            bool ifemptyk = k.isEmpty();
            bool iffullk = k.isFull();
            k.pop(); //usunięcie z kolejki
            Console.WriteLine(" ");
            Console.WriteLine("Po usunięciu kolejka wygląda następująco: ");
            k.write();
            if (ifemptyk == true) //na db sprawdzenie czy stos jest pusty
            {
                Console.WriteLine("Kolejka jest pusta");
            }
            else
            {
                Console.WriteLine("Kolejka nie jest pusta");
            }
            if (iffullk == true) //na db sprawdzenie czy stos jest pełny
            {
                Console.WriteLine("Kolejka jest pełna");
            }
            else
            {
                Console.WriteLine("Kolejka nie jest pełna");
            }
            Console.WriteLine(" ");

            Stos<string> s2 = new Stos<string>(10); //zdefiniowanie stosu o rozmiarze 10 i typie string, pushowane będą litery
            Console.WriteLine("Zapełnianie stosu typu string...");
            s2.push("P");
            s2.push("R");
            s2.push("Z");
            s2.push("Y");
            s2.push("K");
            s2.push("Ł");
            s2.push("A");
            s2.push("D");
            s2.push("1");
            s2.push("2");
            Console.WriteLine("Stos wygląda następująco: ");
            s2.write();
            Console.WriteLine(" ");
            s2.pop();
            Console.WriteLine("Po usunięciu pierwszego bufora stos wygląda następująco: ");
            s2.write();
            Console.ReadLine();
        }
    }
    }

