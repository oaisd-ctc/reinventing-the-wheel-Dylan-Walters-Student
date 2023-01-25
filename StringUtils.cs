namespace StringUtils;

public static class StringUtilities
{
    public static string ToUpper(string s)
    {
        // P.S. SO SORRY! I dislike these long switch statement type stuff too but i'm going with it today!
        char[] charArray = ToCharArray(s);
        for (int i = 0; i < charArray.Length; i++)
        {
            switch (charArray[i])
            {
                case 'a':
                    charArray[i] = 'A';
                    break;
                case 'b':
                    charArray[i] = 'B';
                    break;
                case 'c':
                    charArray[i] = 'C';
                    break;
                case 'd':
                    charArray[i] = 'D';
                    break;
                case 'e':
                    charArray[i] = 'E';
                    break;
                case 'f':
                    charArray[i] = 'F';
                    break;
                case 'g':
                    charArray[i] = 'G';
                    break;
                case 'h':
                    charArray[i] = 'H';
                    break;
                case 'i':
                    charArray[i] = 'I';
                    break;
                case 'j':
                    charArray[i] = 'J';
                    break;
                case 'k':
                    charArray[i] = 'K';
                    break;
                case 'l':
                    charArray[i] = 'L';
                    break;
                case 'm':
                    charArray[i] = 'M';
                    break;
                case 'n':
                    charArray[i] = 'N';
                    break;
                case 'o':
                    charArray[i] = 'O';
                    break;
                case 'p':
                    charArray[i] = 'P';
                    break;
                case 'q':
                    charArray[i] = 'Q';
                    break;
                case 'r':
                    charArray[i] = 'R';
                    break;
                case 's':
                    charArray[i] = 'S';
                    break;
                case 't':
                    charArray[i] = 'T';
                    break;
                case 'u':
                    charArray[i] = 'U';
                    break;
                case 'v':
                    charArray[i] = 'V';
                    break;
                case 'w':
                    charArray[i] = 'W';
                    break;
                case 'x':
                    charArray[i] = 'X';
                    break;
                case 'y':
                    charArray[i] = 'Y';
                    break;
                case 'z':
                    charArray[i] = 'Z';
                    break;
            }
        }
        // Converts new Char Array to string then returns it
    s = ToStringArray(charArray);
    return s;
    }
    public static char[] ToCharArray(string s)
    {
        // initinalize new array to put string chars in
        char[] charArray = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            charArray[i] = s[i];
        }
        return charArray;
    }
    public static string ToStringArray(char[] characters)
    {
        string s = new string(characters);
        return s;
    }
}

