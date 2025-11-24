namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface();
            Node n = new Node("", DateOnly.FromDateTime(DateTime.Now), null);
            LinkedList l = new LinkedList(n);

            ui.Render(n);
            string? t = Console.ReadLine();
            n.SetText(t);

            while (true)
            {
                Console.Clear();
                ui.Render(n);

                Console.WriteLine();
                string command = Console.ReadLine().ToLower();

                if (command == "add" || command == "a")
                {
                    Console.Clear();
                    ui.Render(n);
                    string? text = Console.ReadLine();
                    l.Add(text);
                }
                else if (command == "delete" || command == "d")
                {
                    l.Delete();
                }
                else if (command == "next" || command == "n")
                {
                    try
                    {
                        n = l.Next();
                        ui.Render(n);

                    }
                    catch
                    {

                    }
                }
                else if (command == "previous" || command == "p")
                {
                    try
                    {
                        n = l.Previous();
                        ui.Render(n);

                    }
                    catch
                    {

                    }
                }
                else if (command == "first" || command == "f")
                {
                    n = l.First();

                }
                else if (command == "last" || command == "l")
                {
                    n = l.Last();
                }
                else if (command == "save" || command == "s")
                {
                    l.Save();
                }
                else if (command == "close" || command == "c")
                {
                    l.Close();
                }
               
            }
        }
    }
}
