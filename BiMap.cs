using BiMap;

public class KeyBehaviorTranslator
{
    public BiMap<string, string> MakeKeyBehaviorTranslationBiMap()
    {
        // Create a new BiMap of type <string, string>
        var keyCodes = new BiMap<string, string>();

        // Insert the key-value pairs into the BiMap
        keyCodes.AddPair("Key Press", "&kp");
        keyCodes.AddPair("Key Hold", "&mo");
        keyCodes.AddPair("Layer Tap", "&lt");
        keyCodes.AddPair("To Layer", "&lt");
        keyCodes.AddPair("Toggle Layer", "&tog");
        keyCodes.AddPair("Transparent", "&trans");
        keyCodes.AddPair("None", "&none");
        keyCodes.AddPair("Hold-Tap", "&ht-hp");
        keyCodes.AddPair("Mod-Tap", "&mt");
        keyCodes.AddPair("Mod-Morph", "&gresc");
        keyCodes.AddPair("Tap key in macro", "&macro_tap");
        keyCodes.AddPair("Hold key in macro", "&macro_press");
        keyCodes.AddPair("Release key in macro", "&macro_release");
        keyCodes.AddPair("Key Toggle", "&kt");
        keyCodes.AddPair("Sticky Key", "&sk");
        keyCodes.AddPair("Sticky Layer", "&sl");
        keyCodes.AddPair("Tap Dance", "&td");
        keyCodes.AddPair("Caps Word", "&caps_word");
        keyCodes.AddPair("Key Repeat", "&key_repeat");
        keyCodes.AddPair("Mouse Key Press", "&mkkp");
        keyCodes.AddPair("Reset To Factory Settings", "&reset");
        keyCodes.AddPair("Enter Bootloader", "&bootloader");
        keyCodes.AddPair("Bluetooth", "&bt");
        keyCodes.AddPair("Indicator lights", "&rgb_ug");
        keyCodes.AddPair("Backlight", "&bl");
        keyCodes.AddPair("&ext_power", "&ext_power");
        keyCodes.AddPair("Soft off", "&soft_off");

        return keyCodes;
    }


    public BiMap<string, string> MakeKeyCodeTranslationBiMap()
    {
        // Create a new BiMap of type <string, string>
        var keyCodes = new BiMap<string, string>();

        // Insert the key-value pairs into the BiMap
        keyCodes.AddPair("1 and !", "N1");
        keyCodes.AddPair("2 and @", "N2");
        keyCodes.AddPair("3 and #", "N3");
        keyCodes.AddPair("4 and $", "N4");
        keyCodes.AddPair("5 and %", "N5");
        keyCodes.AddPair("6 and ^", "N6");
        keyCodes.AddPair("7 and &", "N7");
        keyCodes.AddPair("8 and *", "N8");
        keyCodes.AddPair("9 and (", "N9");
        keyCodes.AddPair("0 and )", "N0");
        keyCodes.AddPair("!", "EXCL");
        keyCodes.AddPair("@", "AT");
        keyCodes.AddPair("#", "HASH");
        keyCodes.AddPair("$", "DOLLAR");
        keyCodes.AddPair("%", "PERCENT");
        keyCodes.AddPair("^", "CARET");
        keyCodes.AddPair("&", "AMPERSAND");
        keyCodes.AddPair("*", "STAR");
        keyCodes.AddPair("(", "LPAR");
        keyCodes.AddPair(")", "RPAR");
        keyCodes.AddPair("= and +", "EQUAL");
        keyCodes.AddPair("+", "PLUS");
        keyCodes.AddPair("-", "MINUS");
        keyCodes.AddPair("_", "UNDERSCORE");
        keyCodes.AddPair("/", "FSLH");
        keyCodes.AddPair("?", "QUESTION");
        keyCodes.AddPair("\\ and |", "BSLH");
        keyCodes.AddPair("|", "PIPE");
        keyCodes.AddPair("Non-US \\ and |", "NON_US_BACKSLASH");
        keyCodes.AddPair("; and :", "SEMI");
        keyCodes.AddPair("' and \"", "SQT");
        keyCodes.AddPair("\"", "DOUBLE_QUOTES");
        keyCodes.AddPair(",", "COMMA");
        keyCodes.AddPair("<", "LT");
        keyCodes.AddPair(">", "GT");
        keyCodes.AddPair("[ and {", "LBKT");
        keyCodes.AddPair("] and }", "RBKT");
        keyCodes.AddPair("` and ~", "GRAVE");
        keyCodes.AddPair("~", "TILDE");
        keyCodes.AddPair("Non-US # and ~", "NON_US_HASH");
        keyCodes.AddPair("Escape", "ESC");
        keyCodes.AddPair("Return", "RETURN");
        keyCodes.AddPair("Enter", "ENTER");
        keyCodes.AddPair("Space", "SPACE");
        keyCodes.AddPair("Tab", "TAB");
        keyCodes.AddPair("Backspace", "BSPC");
        keyCodes.AddPair("Delete", "DEL");
        keyCodes.AddPair("Insert", "INSERT");
        keyCodes.AddPair("Home", "HOME");
        keyCodes.AddPair("End", "END");
        keyCodes.AddPair("Page UP", "PAGE_UP");
        keyCodes.AddPair("Page Down", "PAGE_DOWN");
        keyCodes.AddPair("Up Arrow", "UP");
        keyCodes.AddPair("Down Arrow", "DOWN");
        keyCodes.AddPair("Left Arrow", "LEFT");
        keyCodes.AddPair("Right Arrow", "RIGHT");
        keyCodes.AddPair("Application (Context Menu)", "K_APPLICATION");
        keyCodes.AddPair("Caps Lock", "CAPS");
        keyCodes.AddPair("Locking Caps Lock", "LOCKING_CAPS");
        keyCodes.AddPair("Scroll Lock", "SCROLLLOCK");
        keyCodes.AddPair("Locking Num", "KP_NUM");
        keyCodes.AddPair("Print Screen", "PRINTSCREEN");
        keyCodes.AddPair("Pause/Break", "PAUSE_BREAK");
        keyCodes.AddPair("Alternate Erase", "ALT_ERASE");
        keyCodes.AddPair("SysReq/Attention", "SYSREQ");
        keyCodes.AddPair("Cancel", "K_CANCEL");
        keyCodes.AddPair("Clear", "CLEAR");
        keyCodes.AddPair("Clear/Again", "CLEAR_AGAIN");
        keyCodes.AddPair("CrSel/Props", "CRSEL");
        keyCodes.AddPair("Prior", "PRIOR");
        keyCodes.AddPair("Separator", "SEPARATOR");
        keyCodes.AddPair("Out", "OUT");
        keyCodes.AddPair("Oper", "OPER");
        keyCodes.AddPair("ExSel", "EXSEL");
        keyCodes.AddPair("Edit Keyboard", "K_EDIT");
        keyCodes.AddPair("Left Shift", "LSHFT");
        keyCodes.AddPair("Right Shift", "RSHFT");
        keyCodes.AddPair("Left Control", "LEFT_CONTROL");
        keyCodes.AddPair("Right Control", "RIGHT_CONTROL");
        keyCodes.AddPair("Left Alt", "LEFT_ALT");
        keyCodes.AddPair("Right Alt", "RIGHT_ALT");
        keyCodes.AddPair("Left Command", "LEFT_COMMAND");
        keyCodes.AddPair("Right Command", "RIGHT_COMMAND");
        keyCodes.AddPair("Numlock and Clear", "KP_NUMLOCK");
        keyCodes.AddPair("Keypad Clear", "KP_CLEAR");
        keyCodes.AddPair("Keypad Enter", "KP_ENTER");
        keyCodes.AddPair("1", "KP_N1");
        keyCodes.AddPair("2", "KP_N2");
        keyCodes.AddPair("3", "KP_N3");
        keyCodes.AddPair("4", "KP_N4");
        keyCodes.AddPair("5", "KP_N5");
        keyCodes.AddPair("6", "KP_N6");
        keyCodes.AddPair("7", "KP_N7");
        keyCodes.AddPair("8", "KP_N8");
        keyCodes.AddPair("9", "KP_N9");
        keyCodes.AddPair("0", "KP_N0");
        keyCodes.AddPair("F1", "F1");
        keyCodes.AddPair("F2", "F2");
        keyCodes.AddPair("F3", "F3");
        keyCodes.AddPair("F4", "F4");
        keyCodes.AddPair("F5", "F5");
        keyCodes.AddPair("F6", "F6");
        keyCodes.AddPair("F7", "F7");
        keyCodes.AddPair("F8", "F8");
        keyCodes.AddPair("F9", "F9");
        keyCodes.AddPair("F10", "F10");
        keyCodes.AddPair("F11", "F11");
        keyCodes.AddPair("F12", "F12");
        keyCodes.AddPair(" +", "KP_PLUS");
        keyCodes.AddPair("- ", "KP_MINUS");
        keyCodes.AddPair("* ", "KP_MULTIPLY");
        keyCodes.AddPair("/ ", "KP_DIVIDE");
        keyCodes.AddPair("=", "KP_EQUAL");
        keyCodes.AddPair(".", "DOT");
        keyCodes.AddPair(". ", "KP_DOT");
        keyCodes.AddPair(",", "KP_COMMA");
        keyCodes.AddPair("Left Parenthesis", "KP_LPAR");
        keyCodes.AddPair("Right Parenthesis", "KP_RPAR");
        keyCodes.AddPair("Cut", "C_AC_CUT");
        keyCodes.AddPair("Copy", "C_AC_COPY");
        keyCodes.AddPair("Paste", "C_AC_PASTE");
        keyCodes.AddPair("Undo", "C_AC_UNDO");
        keyCodes.AddPair("Redo/Repeat", "C_AC_REDO");
        keyCodes.AddPair("Volume Up", "C_VOLUME_UP");
        keyCodes.AddPair("Volume Down", "C_VOLUME_DOWN");
        keyCodes.AddPair("Mute", "C_MUTE");
        keyCodes.AddPair("Alternate Audio Increment", "C_ALTERNATE_AUDIO_INCREMENT");
        keyCodes.AddPair("Increase Brightness", "C_BRI_UP");
        keyCodes.AddPair("Decrease Brightness", "C_BRI_DN");
        keyCodes.AddPair("Max Brightness", "C_BRI_MAX");
        keyCodes.AddPair("Min Brightness", "C_BRI_MIN");
        keyCodes.AddPair("Auto Brightness", "C_BRI_AUTO");
        keyCodes.AddPair("Backlight Toggle", "C_BKLT_TOG");
        keyCodes.AddPair("Picture in Picture", "C_PIP");
        keyCodes.AddPair("Channel Increment", "C_CHAN_INC");
        keyCodes.AddPair("Channel Decrement", "C_CHAN_DEC");
        keyCodes.AddPair("Recall Last", "C_CHAN_LAST");
        keyCodes.AddPair("VCR Plus", "C_MEDIA_VCR_PLUS");
        keyCodes.AddPair("Mode Step", "C_MODE_STEP");
        keyCodes.AddPair("Bluetooth select ", "BT_SEL");

        return keyCodes;
    }
}




