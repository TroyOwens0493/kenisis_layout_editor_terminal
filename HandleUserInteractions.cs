namespace HandleUserInteraction
{
    using System;

    public class MenuHandler
    {

        public int DisplayMainMenu()
        {
            InputOutput getInput = new();

            var linesToPrint = new string[]
            {
            "Main menu",
            "You can type a number and press enter.",
            "1. Edit a layout",
            "2. Edit a macro",
            "3. Exit"
            };

            Console.Clear();
            for (int i = 0; i < linesToPrint.Length; i++)
            {
                Console.WriteLine(linesToPrint[i]);
            }
            int selection = getInput.GetUserInt();

            return selection; // Return the user's valid selection
        }

        public int DisplayKeymaps(List<string> keyMapNames)
        {
            InputOutput input = new();
            Console.Clear();
            Console.WriteLine("Please choose which keymap you would like to edit: ");
            for (int i = 0; i < keyMapNames.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {keyMapNames[i]}");
            }
            return input.GetUserInt();
        }
    }

    public class InputOutput
    {
        public int GetUserInt()
        {
            bool running = true;
            string? userSelection;
            int selectedInt = 0;

            do
            {
                userSelection = Console.ReadLine();

                if (string.IsNullOrEmpty(userSelection))
                {
                    Console.WriteLine("Please enter something");
                    continue;
                }
                try
                {
                    selectedInt = int.Parse(userSelection);
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number");
                    continue;
                }

                running = false;
            } while (running);

            return selectedInt;
        }
    }
}
