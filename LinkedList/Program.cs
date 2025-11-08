namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface();
            LinkedList l = new LinkedList();
            Node n = new Node("text", DateOnly.FromDateTime(DateTime.Now), null);

            while (true)
            {
                Console.Clear();
                ui.Render(n);

                Console.WriteLine();
                string command = Console.ReadLine().ToLower();

                if (command == "add")
                {
                    l.Add();
                }
                else if (command == "delete")
                {
                    l.Delete();
                }
                else if (command == "next")
                {
                    l.Next();
                }
                else if (command == "previous")
                {
                    l.Previous();
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
