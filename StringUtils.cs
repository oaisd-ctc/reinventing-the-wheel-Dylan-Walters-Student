﻿namespace StringUtils;
using ArrayUtils;
public static class StringUtilities
{
    /// <summary>
    /// Changes each letter to be capitalized.
    /// </summary>
    /// <param name="s">Input string to be capitalized.</param>
    /// <returns>
    /// The input string after capitalization.
    /// </returns>
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
    
    /// <summary>
    /// Makes selected char uppercase..
    /// </summary>
    /// <param name="c">Input char to be capitalized.</param>
    /// <returns>
    /// The input cahr after capitalization.
    /// </returns>
    public static char ToUpper(char c)
    {
        switch (c)
        {
            case 'a':
                c = 'A';
                break;
            case 'b':
                c = 'B';
                break;
            case 'c':
                c = 'C';
                break;
            case 'd':
                c = 'D';
                break;
            case 'e':
                c = 'E';
                break;
            case 'f':
                c = 'F';
                break;
            case 'g':
                c = 'G';
                break;
            case 'h':
                c = 'H';
                break;
            case 'i':
                c = 'I';
                break;
            case 'j':
                c = 'J';
                break;
            case 'k':
                c = 'K';
                break;
            case 'l':
                c = 'L';
                break;
            case 'm':
                c = 'M';
                break;
            case 'n':
                c = 'N';
                break;
            case 'o':
                c = 'O';
                break;
            case 'p':
                c = 'P';
                break;
            case 'q':
                c = 'Q';
                break;
            case 'r':
                c = 'R';
                break;
            case 's':
                c = 'S';
                break;
            case 't':
                c = 'T';
                break;
            case 'u':
                c = 'U';
                break;
            case 'v':
                c = 'V';
                break;
            case 'w':
                c = 'W';
                break;
            case 'x':
                c = 'X';
                break;
            case 'y':
                c = 'Y';
                break;
            case 'z':
                c = 'Z';
                break;

        }
        return c;
    }
    
    /// <summary>
    /// Changes each letter to be un-capitalized.
    /// </summary>
    /// <param name="s">Input string to be un-capitalized.</param>
    /// <returns>
    /// The uncapitalized version of the input string..
    /// </returns>
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
    
    /// <summary>
    /// Finds length of a string.
    /// </summary>
    /// <param name="s">The string to find the length of.</param>
    /// <returns>
    /// Length of string.
    /// </returns>
    public static int Length(string s)
    {
        int length = 0;
        foreach (char letter in s)
        {
            length += 1;
        }
        return length;
    }
    
    /// <summary>
    /// Converts string to character array.
    /// </summary>
    /// <param name="s">The string to turn into a char[].</param>
    /// <returns>
    /// Char[] of string.
    /// </returns>
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

    /// <summary>
    /// Converts Char[] to a string.
    /// </summary>
    /// <param name="char[]">The char[] to turn into a string.</param>
    /// <returns>
    /// char[] as a string.
    /// </returns>
    // This one doesnt need to be a function cause its simple to write it in one line but here it is... you're welcome :)
    public static string ToStringArray(char[] characters)
    {
        return new string(characters);
    }
    
    /// <summary>
    /// Reverses string.
    /// </summary>
    /// <param name="s">The string to reverse.</param>
    /// <returns>
    /// reversed String.
    /// </returns>
    public static string reverse(string s)
    {
        char[] charArray = new char[s.Length];
        int j = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            charArray[i] = s[j];
            j++;
        }
        s = ToStringArray(charArray);
        return s;
    }
    
    /// <summary>
    /// Counts the number of vowels in a string.
    /// </summary>
    /// <param name="s">Input to have vowels counted from.</param>
    /// <returns>
    /// The count of vowels as an integer.
    /// </returns>
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
    
    /// <summary>
    /// Counts every non-vowel (consonant) in a string
    /// </summary>
    /// <param name="s"> </param>
    /// <returns>
    /// Total count of consonants in an string.
    /// </returns>
    public static int CountConsonants(string s)
    {
        s = ToUpper(s);
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if ((s[i] >= 'A' && s[i] <= 'Z') &&
                (s[i] != 'A' && s[i] != 'E' && s[i] != 'I' && s[i] != 'O' && s[i] != 'U'))
            {
                count++;
            }
        }
        return count;
    }
    
    /// <summary>
    /// Finds specified letter in a given string.
    /// </summary>
    /// <param name="s">String to look through for the letter.</param>
    /// <param name="c">Character to find in the given string.</param>
    /// <returns>
    /// True or false on if the character is in the string.
    /// </returns>
    public static bool HasLetter(string s, char c)
    {
        string str = ToUpper(s);
        char character = ToUpper(c);
        bool answer = false;
        foreach (char letter in str)
        {
            if (letter == character)
            {
                answer = true;
            }
        }
        return answer;
    }
    
    /// <summary>
    /// Moves each letter through the alphabet by the given amount.
    /// </summary>
    /// <param name="s">The given string to shuffle through the alphabet.</param>
    /// <param name="arrange">An interger deciding how far the letter should shift in the alphabet.</param>
    /// <returns>
    /// The shuffled string.
    /// </returns>
    public static string CaesarCipher(string s, int arrange)
    {
        char[] characters = ToCharArray((ToLower(s)));  //make it lowercase to make our lives easier
        char[] charset = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        int index;                                      // surprise tool that will help us later
        for (int i = 0; i < characters.Length; i++)
        {
            index = (int)characters[i] - 97;            //convert character to integer ascii code (absolutely deranged)
            if (!(index > 25 || index < 0))             //check if it's in the specified range (i belong in an asylum)
            {
                characters[i] = charset[(index + arrange) % 26]; //offset it by the specified amount
            }

        }

        return ToStringArray(characters); //accept that i will never enter heaven
    }
    
    /// <summary>
    /// Determines if a character is uppercase.
    /// </summary>
    /// <param name="c">Character to turn uppercase.</param>
    /// <returns>
    /// The given character as a capital letter.
    /// </returns>
    public static bool isUpper(char c)
    {
        char[] upper = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        bool cap = false;
        for (int i = 0; i < upper.Length; i++)
        {
            if (c == upper[i])
            {
                cap = true;
                break;
            }
        }
        return cap;
    }
    
    /// <summary>
    /// Alternates each letter as capitalized and uncapitalized.
    /// </summary>
    /// <param name="s">String to alternate casing with.</param>
    /// <returns>
    /// Alternated string.
    /// </returns>
    public static string ToAlternatingCase(string s)
    {
        // sets string to a lowercase char[]
        string set = ToLower(s);
        char[] characters = ToCharArray(set);
        for (int i = 0; i < characters.Length; i++)
        {
            // capitalizes even letters in char[]
            if (i % 2 == 0)
            {
                char holder = characters[i];
                char temp = ToUpper(holder);
                characters[i] = temp;
            }
        }
        return ToStringArray(characters);
    }
    
    /// <summary>
    /// Takes out anything that is not a space/ whitespace.
    /// </summary>
    /// <param name="s">The given string to take out characters.</param>
    /// <returns>
    /// A string with the number of spaces from the original string.
    /// </returns>
    public static string OnlySpace(string s)
    {
        int count = 0;
        foreach (char letter in s)
        {
            if ((int)letter == 32)
            {
                count++;
            }
        }
        s = new string(' ', count);
        return s;
    }
    
    /// <summary>
    /// Removes any spaces from a string.
    /// </summary>
    /// <param name="s">String to have spaces taken out of.</param>
    /// <returns>
    /// String without any spaces in it.
    /// </returns>
    public static string RemoveWhiteSpace(string s)
    {
        // char[] noSpace = new char[s.Length];
        string noSpace = "";
        int i = 0;
        foreach (char letter in s)
        {
            if ((int)letter != 32)
            { 
                noSpace += letter;
            }
            i++;
        }
        return noSpace;
    }
}