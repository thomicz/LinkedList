namespace LinkedList
{
    internal class LinkedList
    {
        private Node first; // první uzel
        private Node last; // poslední uzel
        private Node current; // aktuální pozice v seznamu

        public LinkedList(Node n)
        {
            first = n;
            last = n;
            current = n;
        }

        public void Add(string text)
        {
            Node newNode = new Node(text, DateOnly.FromDateTime(DateTime.Now), null, current);

            if (current.GetNext() != null)
            {
                // vložení doprostřed
                newNode.SetNext(current.GetNext());
                newNode.SetPrevious(current);
                current.GetNext().SetPrevious(newNode);
                current.SetNext(newNode);
            }
            else
            {
                // přidání na konec
                current.SetNext(newNode);
                last = newNode;
            }

            //current.SetNext(newNode);

            
        }




        // Smaže aktuální uzel (current)
        public void Delete()
        {
            if (current == null)
            {
                return;
            }

            Node? prev = current.GetPrevious();
            Node? next = current.GetNext();

            if (prev != null)
            {
                prev.SetNext(next);
            }
            else
            {
                first = next!; // mazal se první uzel
            }

            if (next != null)
            {
                next.SetPrevious(prev!);
            }
            else
            {
                last = prev!; // mazal se poslední uzel
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
                throw new ArgumentNullException();
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
        public Node First()
        {
            current = first;
            return first;
        }

        // Nastaví current na poslední uzel
        public Node Last()
        {
            current = last;
            return last;
        }

        // Uloží seznam do textového souboru
        public void Save(string path = "linkedlist.txt")
        {
            using StreamWriter sw = new StreamWriter(path);
            Node? tmp = first;

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