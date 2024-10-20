//using System;
//using System.Collections.Generic;
//using System.IO;

public class Program
{

    public static void Main()
    {
        try
        {
            FileManager fileManager = new();
            HandleUserInteraction.MenuHandler menu = new();
            List<List<List<string>>> keymap = fileManager.ParseKeymap();
            List<string> keymapNames = fileManager.ParseKeymapNames(keymap);
            int userSelection = menu.DisplayMainMenu();
            if (userSelection == 1) {
                menu.DisplayKeymaps(keymapNames);
                
            } 
            //var keyBehaviorBiMap = BiMap.MakeKeyBehaviorTranslationBiMap();
            //Console.WriteLine("Example Key Behavior Mapping:");
            //Console.WriteLine($"Key Press maps to: {keyBehaviorBiMap.GetForward("Key Press")}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}
