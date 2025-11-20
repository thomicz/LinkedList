namespace LinkedList
{
    internal class LinkedList
    {
        private Node head; // první uzel
        private Node tail; // poslední uzel
        private Node current; // aktuální pozice v seznamu

        public LinkedList(Node n)
        {
            head = n;
            tail = n;
            current = n;
        }

        // Přidá nový uzel na konec seznamu
        public void Add(string text)
        {
            Node newNode = new Node(text, DateOnly.FromDateTime(DateTime.Now), null, tail);
            tail.SetNext(newNode);
            tail = newNode;
        }

        // Smaže aktuální uzel (current)
        public void Delete()
        {
            if (current == null) return;

            Node? prev = current.GetPrevious();
            Node? next = current.GetNext();

            if (prev != null)
            {
                prev.SetNext(next);
            }
            else
            {
                head = next!; // mazal se první uzel
            }

            if (next != null)
            {
                next.SetPrevious(prev!);
            }
            else
            {
                tail = prev!; // mazal se poslední uzel
            }

            // posun current na následující nebo zpět
            current = next ?? prev!;
        }

        // Posune ukazatel na další uzel
        public Node Next()
        {
            Node? next = current.GetNext();

            if (next == null)
            {
                throw new Exception("Žádný další uzel neexistuje.");
            }

            current = next;
            return current;
        }

        // Posune ukazatel na předchozí uzel
        public Node Previous()
        {
            Node? prev = current.GetPrevious();

            if (prev == null)
            {
                throw new Exception("Žádný předchozí uzel neexistuje.");
            }

            current = prev;
            return current;
        }

        // Nastaví current na první uzel
        public void First()
        {
            current = head;
        }

        // Nastaví current na poslední uzel
        public void Last()
        {
            current = tail;
        }

        // Vypíše všechny uzly od začátku
        public void PrintAll()
        {
            Node? tmp = head;
            while (tmp != null)
            {
                Console.WriteLine($"{tmp.GetText()} ({tmp.GetDate()})");
                tmp = tmp.GetNext();
            }
        }

        // Uloží seznam do textového souboru
        public void Save(string path = "linkedlist.txt")
        {
            using StreamWriter sw = new StreamWriter(path);
            Node? tmp = head;

            while (tmp != null)
            {
                sw.WriteLine($"{tmp.GetText()},{tmp.GetDate()}");
                tmp = tmp.GetNext();
            }
        }

        // Ukončí program
        public void Close()
        {
            Environment.Exit(0);
        }
    }
}