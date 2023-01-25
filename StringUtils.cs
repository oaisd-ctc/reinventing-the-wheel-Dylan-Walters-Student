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
    public static string ToLower(string s)
    {
        char[] charArray = ToCharArray(s);
        for (int i = 0; i < charArray.Length; i++)
        {
            switch (charArray[i])
            {
                case 'A':
                    charArray[i] = 'a';
                    break;
                case 'B':
                    charArray[i] = 'b';
                    break;
                case 'C':
                    charArray[i] = 'c';
                    break;
                case 'D':
                    charArray[i] = 'd';
                    break;
                case 'E':
                    charArray[i] = 'e';
                    break;
                case 'F':
                    charArray[i] = 'f';
                    break;
                case 'G':
                    charArray[i] = 'g';
                    break;
                case 'H':
                    charArray[i] = 'h';
                    break;
                case 'I':
                    charArray[i] = 'i';
                    break;
                case 'J':
                    charArray[i] = 'j';
                    break;
                case 'K':
                    charArray[i] = 'k';
                    break;
                case 'L':
                    charArray[i] = 'l';
                    break;
                case 'M':
                    charArray[i] = 'm';
                    break;
                case 'N':
                    charArray[i] = 'n';
                    break;
                case 'O':
                    charArray[i] = 'o';
                    break;
                case 'P':
                    charArray[i] = 'p';
                    break;
                case 'Q':
                    charArray[i] = 'q';
                    break;
                case 'R':
                    charArray[i] = 'r';
                    break;
                case 'S':
                    charArray[i] = 's';
                    break;
                case 'T':
                    charArray[i] = 't';
                    break;
                case 'U':
                    charArray[i] = 'u';
                    break;
                case 'V':
                    charArray[i] = 'v';
                    break;
                case 'W':
                    charArray[i] = 'w';
                    break;
                case 'X':
                    charArray[i] = 'x';
                    break;
                case 'Y':
                    charArray[i] = 'y';
                    break;
                case 'Z':
                    charArray[i] = 'z';
                    break;
            }
        }
        // Converts new Char Array to string then returns it
        s = ToStringArray(charArray);
        return s;
    }
    public static int Length(string s)
    {
        int length = 0;
        foreach (char letter in s)
        {
            length += 1;
        }
        return length;
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

    // This one doesnt need to be a function cause its simple to write it in one line but here it is... you're welcome :)
    public static string ToStringArray(char[] characters)
    {
        return new string(characters);
    }
    public static string reverse(string s)
    {
        char[] charArray = new char[s.Length];
        for (int i = s.Length; i > 0; i--)
        {
            charArray[i] = s[i];
        }
        s = ToStringArray(charArray);
        return s;
    }
    public static int CountVowels(string s)
    {
        s = ToUpper(s);
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
            {
                count++;
            }
        }
        return count;
    }
    public static int CountConsonants(string s)
    {
        s = ToUpper(s);
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != 'A' && s[i] != 'E' && s[i] != 'I' && s[i] != 'O' && s[i] != 'U')
            {
                count++;
            }
        }
        return count;
    }
}

