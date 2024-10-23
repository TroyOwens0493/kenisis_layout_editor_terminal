using System.Text.RegularExpressions;
public class FileManager
{
    //Attributes
    private string _filePath = "./config/adv360.keymap";
    private List<string> _finishedFile = new();

    public List<List<List<string>>> ParseKeymap()
    {
        var keymap = new List<List<List<string>>>();
        var currentLayer = new List<List<string>>();
        bool isKeymapLine = false;
        int i = 0;

        using (var reader = new StreamReader(_filePath))
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

    public void EditKey(List<string> changes, int keymapIndex, List<List<List<string>>> keymap, List<string> keymapNames)
    {
        //Make the key edit in the list
        var keyMapWeAreEditing = keymap[keymapIndex];
        int currentKeyIndex = 0;
        Console.WriteLine(changes[0]);
        for (int i = 0; i < keyMapWeAreEditing.Count(); i++)
        {
            var currentLayer = keyMapWeAreEditing[i];
            for (int j = 0; j < currentLayer.Count(); j++)
            {
                if (currentKeyIndex == int.Parse(changes[0]))
                {
                    currentLayer[j] = $"{changes[1]} {changes[2]}";
                    keyMapWeAreEditing[i] = currentLayer;
                    break;
                }
            }
            currentKeyIndex++;
        }

        // Read all lines from the keymap file into an array
        string[] lines = File.ReadAllLines(_filePath);

        // Convert the array to a List<string>
        List<string> lineList = new List<string>(lines);
        bool isKeyMapLine = false;
        int layerLineCount = 0;

        for (int i = 0; i < lineList.Count(); i++)//Loop through each line of the map file
        {
            layerLineCount++;

            if (lineList[i].Trim().StartsWith(keymapNames[keymapIndex]))
            {
                layerLineCount = 0;
                isKeyMapLine = true;
                continue;
            }
            else if (isKeyMapLine)
            {
                if (layerLineCount < keyMapWeAreEditing.Count() + 1)//Loop through all the keys in the keymap we are editing
                {
                    lineList[i] = " "; // Clear the line for the new key mappings

                    if (layerLineCount == 1)
                    {
                        lineList[i] = keymapNames[keymapIndex] + "{";
                    }
                    else if (layerLineCount == 2)
                    {
                        lineList[i] = "bindings = <";
                    }
                    else
                    {

                        foreach (string word in keyMapWeAreEditing[layerLineCount - 2])
                        {
                            lineList[i] += $" {word.Trim()}";
                        }
                    }
                }
                else
                {
                    isKeyMapLine = false; // Reset when finished
                }
            }
        }
    }

    public void WriteToFile()
    {
        using (var writer = new StreamWriter(_filePath))
        {
            foreach (string line in _finishedFile)
            {
                writer.WriteLine(line);
            }
        }
    }
}
