using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils
{
    public static string formatInt(long i)
    {
        string result = "";
        string iStr = i.ToString();
        if (i < 0) iStr = (i * -1).ToString();
        int index = 0;

        for (int j = 0; j < iStr.Length; j++)
        {
            char chr = iStr.ToCharArray()[iStr.Length-1-j];
            if (index == 3)
            {
                result = " " + result;
                index = 0;
            }

            result = chr + result;
            index++;
        }

        if (i < 0) result = "- " + result;

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
