using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static List<List<List<string>>> ParseKeymap()
    {
        var keymap = new List<List<List<string>>>();
        var currentLayer = new List<List<string>>();
        bool isKeymapLine = false;
        int i = 0;

        using (var reader = new StreamReader("./config/adv360.keymap"))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                string cleanLine = line.Trim();

                if (cleanLine == "bindings = <")
                {
                    isKeymapLine = true;
                    continue;
                }

                if (isKeymapLine)
                {
                    if (i < 6)
                    {
                        var keys = new List<string>(cleanLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                        currentLayer.Add(keys);
                        i++;
                    }
                    else
                    {
                        i = 0;
                        isKeymapLine = false;
                        keymap.Add(currentLayer);
                        currentLayer = new List<List<string>>();
                    }
                }
            }

            if (currentLayer.Count > 0)
            {
                keymap.Add(currentLayer);
            }
        }

        return keymap;
    }


    public static void Main()
    {
        try
        {
            var keymap = ParseKeymap();
            Console.WriteLine("Parsed Keymap: ");
            foreach (var layer in keymap)
            {
                foreach (var keyRow in layer)
                {
                    Console.WriteLine(string.Join(", ", keyRow));
                }
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
