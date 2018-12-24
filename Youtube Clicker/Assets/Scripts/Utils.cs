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

    public static string formatTime(int secs)
    {

        int hours = secs / 3600;
        secs = secs % 3600;

        int mins = secs / 60;
        secs = secs % 60;

        string result = "";

        if (hours != 0)
        {
            result += hours+"h ";
        }

        if (mins != 0)
        {
            result += mins + "m ";
        }

        result += secs+"s ";

        return result;
    }
}
