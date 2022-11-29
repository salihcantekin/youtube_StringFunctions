using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions;
internal static class StringFunctionsExtensions
{

    public static string TBReverse(this string text)
    {
        // Access -> Min-Max: text.Length

        // Salih
        // hilaS
        var sb = new StringBuilder();

        for (int i = text.Length - 1; i >= 0; i--)
        {
            sb.Append(text[i]);
        }

        return sb.ToString();
    }

    public static bool TBEqual(this string text, string str)
    {
        // Access -> Max: text.Length

        if (string.IsNullOrEmpty(text) && string.IsNullOrEmpty(str))
            return true;

        if (text.Length != str.Length)
            return false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != str[i])
                return false;
        }

        return true;
    }

    public static bool TBIsPalindrom(this string text)
    {
        // Access -> Max: halfLength

        //var reversed = text.TBReverse();
        //if (reversed.TBEqual(text))
        //    return true;

        var halfLength = text.Length / 2;
        for (int i = 0; i < halfLength / 2; i++)
        {
            if (text[i] != text[text.Length - i - 1])
                return false;
        }

        return true;
    }

    public static bool TBStartsWith(this string text, string str)
    {
        // Access -> Max: str.Length

        // Text: Salihasdasdasdasdsds, str: Sal
        if (str.Length > text.Length)
            return false;

        for (int i = 0; i < str.Length; i++)
        {
            if (text[i] != str[i])
                return false;
        }

        return true;
    }

    public static bool TBEndsWith(this string text, string str)
    {
        // Access: Max -> str.Length

        // text: Salih, str: ih
        if (str.Length > text.Length)
            return false;

        //for (int i = 0; i < str.Length; i++)
        //{
        //    var textCurChar = text[text.Length - i - 1];
        //    var strCurChar = str[str.Length - i - 1];

        //    if (textCurChar != strCurChar)
        //        return false;
        //}

        int iStr = str.Length - 1;
        for (int i = text.Length - 1; i >= 0 && iStr > 0; i--, iStr--)
        {
            if (text[i] != str[iStr])
                return false;
        }

        return true;

    }

    public static bool TBEndsWithV2WithReversedText(this string reversed, string reversedStr)
    {
        if (reversedStr.Length > reversed.Length)
            return false;

        // Access - Max -> reversedStr.Length
        for (int i = 0; i < reversedStr.Length; i++)
        {
            if (reversed[i] != reversedStr[i])
                return false;
        }

        return true;
    }

    public static bool TBContains(this string text, string str)
    {
        if (str.Length > text.Length)
            return false;

        // Access -> Max: > text.Length
        // text: Salihcantekin, str: ali

        var firstLeterOfStr = str[0];

        for (int i = 0; i < text.Length; i++)
        {
            var currentLetter = text[i];

            if (currentLetter == firstLeterOfStr)
            {
                // Start looking for others

                int strCounter = 1;
                for (int j = 1; j < str.Length; j++)
                {
                    var nextLetterOfStr = text[i + 1];
                    if (nextLetterOfStr != str[strCounter])
                        break;

                    strCounter++;
                    i++;
                }

                if (str.Length == strCounter)
                {
                    return true;
                }
            }
        }

        return false;
    }

    public static string TBSubString(this string text, int startIndex, int length)
    {
        // Access -> Max: startIndex + length

        if (startIndex > text.Length)
            return string.Empty;

        if (startIndex < 0)
            startIndex = 0; // startIndex = Math.Max(startIndex, 0);

        if (startIndex + length > text.Length)
            length = text.Length - startIndex;

        var sb = new StringBuilder();

        for (int i = startIndex; i < startIndex + length; i++)
        {
            sb.Append(text[i]);
        }

        return sb.ToString();
    }

    public static string TBReplace(this string text, string str1, string str2)
    {
        // Access -> Max: > text.Length
        if (str1.Length > text.Length) return text;

        var firstLetterOfStr = str1[0];
        var sb = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            var currentLetter = text[i];

            if (currentLetter == firstLetterOfStr)
            {
                int j = 1;
                for (; j < str1.Length; j++)
                {
                    var nextLetterOfStr = text[i + 1];
                    if (nextLetterOfStr != str1[j])
                        break;

                    i++;
                }

                if (str1.Length == j)
                    sb.Append(str2);
                else
                    sb.Append(currentLetter);
            }
            else
                sb.Append(currentLetter);
        }

        return sb.ToString();
    }
}
