namespace LinkedList
{
    internal class Node
    {
        public Node(string text, DateOnly date, Node? next, Node? previous = null)
        {
            this.text = text;
            this.date = date;
            this.next = next;
            this.previous = previous;
        }

        private string text;
        private DateOnly date;

        private Node? next = null;
        private Node? previous = null;

        //Gettery
        public string GetText()
        {
            return this.text;
        }

        public DateOnly GetDate()
        {
            return this.date;
        }

        public Node? GetNext()
        {
            return this.next;
        }

        public Node? GetPrevious()
        {
            return this.previous;
        }

        //Settery
        public void SetText(string text)
        {
            this.text = text;
        }

        public void SetDate(DateOnly date)
        {
            this.date = date;
        }

        public void SetNext(Node n)
        {
            this.next = n;
        }

        public void SetPrevious(Node n)
        {
            this.previous = n;
        }
    }
}
