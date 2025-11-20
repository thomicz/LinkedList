namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface();
            Node n = new Node("text", DateOnly.FromDateTime(DateTime.Now), null);
            LinkedList l = new LinkedList(n);
            n.SetText("");



            while (true)
            {
                Console.Clear();
                ui.Render(n);

                Console.WriteLine();
                string command = Console.ReadLine().ToLower();

                if (command == "add")
                {
                    Console.Clear();
                    ui.Render(n);
                    string text = Console.ReadLine();
                    l.Add(text);
                }
                else if (command == "delete")
                {
                    l.Delete();
                }
                else if (command == "next")
                {
                    try
                    {
                        n = l.Next();
                    }
                    catch
                    {
                       
                    }
                }
                else if (command == "previous")
                {
                    try
                    {
                        n = l.Previous();
                    }
                    catch
                    {

                    }
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
