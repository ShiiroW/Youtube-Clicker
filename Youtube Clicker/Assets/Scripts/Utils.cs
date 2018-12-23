using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils
{
    public static string formatInt(int i)
    {
        string result = "";
        string iStr = i.ToString();

        for (int j = iStr.Length; j > 0; j--)
        {
            char chr = iStr.ToCharArray()[iStr.Length-j];
            if ((iStr.Length - j) % 3 == 0) result += " ";
            result += chr;
        }

        result = result.Substring(1);

        return result;
    }
}
