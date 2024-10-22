using System.Text.RegularExpressions;
public class FileManager
{
    public List<List<List<string>>> ParseKeymap()
    {
        var keymap = new List<List<List<string>>>();
        var currentLayer = new List<List<string>>();
        bool isKeymapLine = false;
        int i = 0;

        using (var reader = new StreamReader("./config/adv360.keymap"))
        {
            // Set up vars for iterating
            string? line;
            string? prevLine = "";
            while ((line = reader.ReadLine()) != null)
            {

                string cleanLine = line.Trim();

                //Start parsing if we are on a keymap line
                if (cleanLine == "bindings = <")
                {
                    isKeymapLine = true;
                    continue;
                }

                //Store the line before the map to know what the map is called
                if (!isKeymapLine)
                {
                    prevLine = cleanLine;
                }


                if (isKeymapLine)
                {
                    if (i < 6) //Add the keymap lines
                    {
                        if (i == 0) //Add the name of the mapping
                        {
                            var mapName = new List<string>(prevLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                            currentLayer.Add(mapName);
                        }
                        var keys = Regex.Split(cleanLine, @"(?=&)")
                                        .Where(part => !string.IsNullOrWhiteSpace(part))
                                        .ToList();
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

    public List<string> ParseKeymapNames(List<List<List<string>>> parsedKeyMaps)
    {

        List<string> parsedKeyMapNames = new();

        for (int i = 0; i < parsedKeyMaps.Count; i++)
        {
            parsedKeyMapNames.Add(parsedKeyMaps[i][0][0]);
        }

        return parsedKeyMapNames;
    }

    public void EditKey(List<string> changes, int keymapIndex, List<List<List<string>>> keymap)
    {

    }
}
