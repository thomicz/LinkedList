namespace LinkedList
{
    internal class LinkedList
    {
        private Node first;
        private Node last;
        private Node current;

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
                newNode.SetNext(current.GetNext());
                newNode.SetPrevious(current);
                current.GetNext().SetPrevious(newNode);
                current.SetNext(newNode);
            }
            else
            {
                current.SetNext(newNode);
                last = newNode;
            }
        }
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
                first = next!; 
            }

            if (next != null)
            {
                next.SetPrevious(prev!);
            }
            else
            {
                last = prev!; 
            }

            current = next ?? prev!;
        }

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

        public Node First()
        {
            current = first;
            return first;
        }

        public Node Last()
        {
            current = last;
            return last;
        }

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

        public void Close()
        {
            Environment.Exit(0);
        }

        public Node Current()
        {
            return current;
        }
    }
}