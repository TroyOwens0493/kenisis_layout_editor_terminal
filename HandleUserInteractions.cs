namespace HandleUserInteraction
{
    using System;
    using System.Collections.Generic;

    public class MenuHandler
    {
        //Attributes
        private List<int> _keyNumsForLeftSide = new List<int> { 1, 2, 3, 4, 5, 6, 7, 15, 16, 17, 18, 19, 20, 21, 29, 30, 31, 32, 33, 34, 35, 36, 37, 47, 48, 49, 50, 51, 52, 53, 61, 62, 63, 64, 65, 66, 67, 68 };
        private List<int> _keyNumsForRightSide = new List<int> { 8, 9, 10, 11, 12, 12, 13, 14, 22, 23, 24, 25, 26, 27, 28, 38, 39, 40, 41, 42, 43, 44, 45, 46, 54, 55, 56, 57, 58, 59, 60, 69, 70, 71, 72, 73, 74, 75, 76 };
        //List<int> _thumbClusterLeft = new List<int> { 36, 37, 53, 66, 67, 68 };
        //List<int> _thumbClusterRight = new List<int> { 38, 39, 54, 69, 70, 71 };
        private List<string> _keyToEdit = [" ", " ", " "];
        public List<string> _modificationsToMake = [" ", " ", " "];
        List<string> _keyPressStrings = new List<string>
        {
            "Key Press",
            "Key Hold",
            "Layer Tap",
            "To Layer",
            "Toggle Layer",
            "Transparent",
            "None",
            "Hold-Tap",
            "Mod-Tap",
            "Mod-Morph",
            "Tap key in macro",
            "Hold key in macro",
            "Release key in macro",
            "Key Toggle",
            "Sticky Key",
            "Sticky Layer",
            "Tap Dance",
            "Caps Word",
            "Key Repeat",
            "Mouse Key Press",
            "Reset To Factory Settings",
            "Enter Bootloader",
            "Bluetooth",
            "Indicator lights",
            "Backlight",
            "&ext_power",
            "Soft off"
        };
        List<string> _keyCodeStrings = new List<string>
        {
            "1 and !",
            "2 and @",
            "3 and #",
            "4 and $",
            "5 and %",
            "6 and ^",
            "7 and &",
            "8 and *",
            "9 and (",
            "0 and )",
            "!",
            "@",
            "#",
            "$",
            "%",
            "^",
            "&",
            "*",
            "(",
            ")",
            "= and +",
            "+",
            "-",
            "_",
            "/",
            "?",
            "\\ and |",
            "|",
            "Non-US \\ and |",
            "; and :",
            "' and \"",
            "\"",
            ",",
            "<",
            ">",
            "[ and {",
            "] and }",
            "` and ~",
            "~",
            "Non-US # and ~",
            "Escape",
            "Return",
            "Enter",
            "Space",
            "Tab",
            "Backspace",
            "Delete",
            "Insert",
            "Home",
            "End",
            "Page UP",
            "Page Down",
            "Up Arrow",
            "Down Arrow",
            "Left Arrow",
            "Right Arrow",
            "Application (Context Menu)",
            "Caps Lock",
            "Locking Caps Lock",
            "Scroll Lock",
            "Locking Num",
            "Print Screen",
            "Pause/Break",
            "Alternate Erase",
            "SysReq/Attention",
            "Cancel",
            "Clear",
            "Clear/Again",
            "CrSel/Props",
            "Prior",
            "Separator",
            "Out",
            "Oper",
            "ExSel",
            "Edit Keyboard",
            "Left Shift",
            "Right Shift",
            "Left Control",
            "Right Control",
            "Left Alt",
            "Right Alt",
            "Left Command",
            "Right Command",
            "Numlock and Clear",
            "Keypad Clear",
            "Keypad Enter",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            " +",
            "- ",
            "* ",
            "/ ",
            "=",
            ".",
            ". ",
            ",",
            "Left Parenthesis",
            "Right Parenthesis",
            "Cut",
            "Copy",
            "Paste",
            "Undo",
            "Redo/Repeat",
            "Volume Up",
            "Volume Down",
            "Mute",
            "Alternate Audio Increment",
            "Increase Brightness",
            "Decrease Brightness",
            "Max Brightness",
            "Min Brightness",
            "Auto Brightness",
            "Backlight Toggle",
            "Picture in Picture",
            "Channel Increment",
            "Channel Decrement",
            "Recall Last",
            "VCR Plus",
            "Mode Step",
            "Bluetooth select "
        };
        private int _sideToDisplay = new();
        public int _layerIndex = new();


        //Methods
        public void SetKeyToEdit(List<List<List<string>>> keyToEdit, List<List<List<string>>> keymap)
        {
            var layer = keymap[_layerIndex];
            var keyToEditIndex = keyToEdit[0][0][0];
            var keyToEditFunctions = keyToEdit[1][int.Parse(keyToEditIndex)];
            _keyToEdit[0] = keyToEditIndex;
            for (int i = 1; i < keyToEditFunctions.Count(); i++)
            {
                _keyToEdit[i] = keyToEditFunctions[i];
            }

        }
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
            foreach (var line in linesToPrint)
            {
                Console.WriteLine(line);
            }

            int selection = getInput.GetUserInt();
            return selection; // Return the user's valid selection
        }

        public void ChooseKeymaps(List<string> keyMapNames)
        {
            InputOutput input = new();
            Console.Clear();
            Console.WriteLine("Please choose which keymap you would like to edit: ");

            for (int i = 0; i < keyMapNames.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {keyMapNames[i]}");
            }

            _layerIndex = input.GetUserInt() - 1;
        }

        public void ChooseSide()
        {
            InputOutput input = new();
            Console.Clear();
            Console.WriteLine("Would you like to edit the 1. Left or the 2. Right side of your keyboard?");
            _sideToDisplay = input.GetUserInt();
        }

        public List<List<List<string>>> DisplayLayout(List<List<List<string>>> keymaps)
        {
            Console.Clear();
            InputOutput inAndOut = new();
            List<List<string>> keyMapToDisplay = keymaps[_layerIndex];
            List<List<string?>> thumbClusterKeys = new();
            List<List<string>> allKeyOutputs = new();

            int currentKeyNum = 1;
            int keyDisplayNumber = 1;
            int cursorPositionAfterWrite = 0;

            for (int i = 1; i < (keyMapToDisplay.Count - 1); i++) // Loop through each row and skip title row
            {
                int cursorColumn = 0;
                for (int j = 0; j < keyMapToDisplay[i].Count; j++) // Loop through each item in row
                {
                    string[] keyInfo = keyMapToDisplay[i][j].Split(' ');

                    var output = inAndOut.TranslateKeyInfo(keyInfo[0], keyInfo[1], currentKeyNum);
                    allKeyOutputs.Add(output.Where(item => item != null).ToList()!);

                    if (_sideToDisplay == 1 && _keyNumsForLeftSide.Contains(currentKeyNum))
                    {
                        cursorColumn += DisplayKey(currentKeyNum, output, i - 1, j, cursorColumn, keyDisplayNumber);
                        keyDisplayNumber++;
                    }
                    else if (_sideToDisplay == 2 && !_keyNumsForLeftSide.Contains(currentKeyNum))
                    {
                        cursorColumn += DisplayKey(currentKeyNum, output, i - 1, j, cursorColumn, keyDisplayNumber);
                        keyDisplayNumber++;
                    }
                    currentKeyNum++;
                    cursorPositionAfterWrite = ((i - 1) * 4) + 5;
                }
            }
            Console.SetCursorPosition(0, cursorPositionAfterWrite);
            Console.WriteLine("Please type one of the key numbers to edit it.");
            if (_sideToDisplay == 1)
            {
                List<string> userChoice = new();
                userChoice.Add(_keyNumsForLeftSide[inAndOut.GetUserInt() - 1].ToString());
                return [[userChoice], allKeyOutputs];
            }
            else
            {
                List<string> userChoice = new();
                userChoice.Add(_keyNumsForRightSide[inAndOut.GetUserInt() - 1].ToString());
                return [[userChoice], allKeyOutputs];
            }
        }

        private static int DisplayKey(int currentKeyNum, List<string?> keyInfo, int currentRow, int currentColumn, int cursorColumn, int keyDisplayNum)
        {
            int cursorRow = currentRow * 4;
            int shiftForBar = 0;
            int longestLine = 0;

            for (var item = 0; item < keyInfo.Count(); item++) // Loop through each key attribute
            {
                Console.SetCursorPosition(cursorColumn, cursorRow);

                if (cursorColumn > 0)
                {
                    Console.Write(" | ");
                    shiftForBar = 3;
                }

                int currentLineLength = keyInfo[item]?.Length ?? 0;
                if (currentLineLength > longestLine)
                {
                    longestLine = currentLineLength;
                }

                if (item == 0)
                {
                    Console.Write(keyDisplayNum);
                }
                else
                {
                    Console.Write(keyInfo[item]);
                }
                cursorRow++;
            }
            Console.SetCursorPosition(0, cursorRow);
            Console.Write(new string('-', cursorColumn + longestLine + shiftForBar));

            return longestLine + shiftForBar;
        }

        public void EditKey()
        {
            KeyBehaviorTranslator keybiMaps = new();
            InputOutput inandout = new();
            var keyPresses = keybiMaps.MakeKeyCodeTranslationBiMap();
            var keyActions = keybiMaps.MakeKeyBehaviorTranslationBiMap();
            _modificationsToMake[0] = _keyToEdit[0];

            //Get the type of key press
            Console.Clear();
            Console.WriteLine($"Current keypress type: {_keyToEdit[1]}");
            Console.WriteLine("Choose what type of keypress you would like");

            for (int i = 0; i < _keyPressStrings.Count(); i++)
            {
                Console.WriteLine($"{i + 1}. {_keyPressStrings[i]}");
            }

            Console.WriteLine("Please type a number");
            int indexOfNewKeyPress = (inandout.GetUserInt() - 1);
            _modificationsToMake[1] = keyActions.GetLeftToRight(_keyPressStrings[indexOfNewKeyPress]);

            //Con// Get the type of key action
            int terminalWidth = Console.WindowWidth;
            int terminalHeight = Console.WindowHeight;

            int longestLineLen = _keyCodeStrings.Max(s => s.Length);  // Get the length of the longest string in _keyCodeStrings
            int columnWidth = longestLineLen + 5;  // Add padding for spacing between columns

            int x = 0;  // Current column position (horizontal)
            int y = 2;  // Start y at 2 to account for header text

            Console.Clear();
            Console.WriteLine($"Current action on keypress: {_keyToEdit[2]}");
            Console.WriteLine("Choose what you would like the key to do");

            for (int i = 0; i < _keyCodeStrings.Count(); i++)
            {
                // Print the option in the current position
                Console.SetCursorPosition(x, y);
                Console.Write($"{i + 1}. {_keyCodeStrings[i]}");

                y++;  // Move down one line

                // Check if we need to move to the next column (halfway down the terminal)
                if (y >= (terminalHeight / 2) + 2)  // +2 accounts for the header lines
                {
                    y = 2;  // Reset y to start below the headers
                    x += columnWidth;  // Move x to the next column
                }
            }
            Console.SetCursorPosition(0, (terminalHeight / 2) + 3);
            Console.WriteLine("Please type a number: ");
            int indexOfNewKeyAction = (inandout.GetUserInt() - 1);
            _modificationsToMake[2] = keyPresses.GetLeftToRight(_keyCodeStrings[indexOfNewKeyAction]);
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

            public List<string?> TranslateKeyInfo(string keyPress, string keyAction, int i)
            {
                KeyBehaviorTranslator BiMapInit = new();
                var keyCodeMap = BiMapInit.MakeKeyBehaviorTranslationBiMap();
                var keyActionMap = BiMapInit.MakeKeyCodeTranslationBiMap();
                string index = $"{i}";
                var alphabet = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z".Split(',');

                if ((keyPress == "&trans") | (keyPress == "&none"))
                {
                    return [index, keyCodeMap.GetRightToLeft(keyPress), "None"];
                }
                else if ((keyPress == "&tog") | (keyPress == "&mo"))
                {
                    return [index, keyCodeMap.GetRightToLeft(keyPress), keyAction];
                }
                else if (keyPress.StartsWith("&macro_"))
                {
                    return [index, keyPress, "Macro"];
                }
                else
                {
                    for (int itr = 0; itr < alphabet.Length; itr++)
                    {
                        if (keyAction.ToLower() == alphabet[itr])
                        {
                            return [index, keyCodeMap.GetRightToLeft(keyPress), keyAction];
                        }
                    }
                }


                return [index, keyCodeMap.GetRightToLeft(keyPress), keyActionMap.GetRightToLeft(keyAction)];
            }
        }
    }
}
