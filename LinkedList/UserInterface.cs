namespace LinkedList
{
    internal class UserInterface
    {
        public void Render(Node n)
        {
            this.RenderHelpMenu();
            Console.WriteLine($"\nDatum: {n.GetDate()}");
            Console.WriteLine($"\n{n.GetText()}");
                

        }

        private void RenderHelpMenu()
        {
            this.RenderColorText(ConsoleColor.Cyan, "add");
            Console.WriteLine(" - přidá záznam");

            this.RenderColorText(ConsoleColor.Cyan, "delete");
            Console.WriteLine(" - odebere záznam");

            this.RenderColorText(ConsoleColor.Cyan, "next");
            Console.WriteLine(" - zobrazí následující záznam");

            this.RenderColorText(ConsoleColor.Cyan, "previous");
            Console.WriteLine(" - zobrazí předchozí záznam");

            this.RenderColorText(ConsoleColor.Cyan, "first");
            Console.WriteLine(" - zobrazí první záznam");

            this.RenderColorText(ConsoleColor.Cyan, "last");
            Console.WriteLine(" - zobrazí poslední záznam");

            this.RenderColorText(ConsoleColor.Cyan, "save");
            Console.WriteLine(" - uloží vytvořený záznam");

            this.RenderColorText(ConsoleColor.Cyan, "close");
            Console.WriteLine(" - vypne program");
        }

        private void RenderColorText(ConsoleColor c, string t, bool b = false)
        {
            Console.ForegroundColor = c;

            if (b)
            {
                Console.WriteLine(t);
            }
            else
            {
                Console.Write(t);
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
