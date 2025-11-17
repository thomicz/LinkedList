namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface();
            Node n = new Node("text", DateOnly.FromDateTime(DateTime.Now), null);
            LinkedList l = new LinkedList(n);
            n.SetText("Welcome to the Linked List Application!");



            while (true)
            {
                Console.Clear();
                ui.Render(n);

                Console.WriteLine();
                string command = Console.ReadLine().ToLower();

                if (command == "add")
                {
                    l.Add("ahoj");
                }
                else if (command == "delete")
                {
                    l.Delete();
                }
                else if (command == "next")
                {
                    n = l.Next();
                }
                else if (command == "previous")
                {
                    n = l.Previous();
                }
                else if (command == "first")
                {
                    l.First();
                }
                else if (command == "last")
                {
                    l.Last();
                }
                else if (command == "save")
                {
                    l.Save();
                }
                else if (command == "close")
                {
                    l.Close();
                }
            }
        }
    }
}
