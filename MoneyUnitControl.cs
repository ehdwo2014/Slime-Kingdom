using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class MoneyUnitControl
{
    public static string FormatNumber(long num)
    {
        if (num >= 100000000000)
            return (num / 1000000000).ToString("#,0") + " B";
        if (num >= 10000000000)
            return (num / 1000000000D).ToString("0.#") + " B";

        if (num >= 100000000)
        {
            return (num / 1000000D).ToString("0.##M");
        }
        if (num >= 1000000)
        {
            return (num / 1000000D).ToString("0.###M");
        }
        if (num >= 100000)
        {
            return (num / 1000D).ToString("0.##k");
        }
        if (num >= 10000)
        {
            return (num / 1000D).ToString("0.###k");
        }

        return num.ToString("#,0");
    }

    public static float ReturnProbForRein(int n)
    {
    
        if(n ==5)
        {
            return 0.9f;
        }
        if(n == 6)
        {
            return 0.85f;
        }
        if(n == 7)
        {
            return 0.8f;
        }
        if(n == 8)
        {
            return 0.7f;
        }
        if(n == 9)
        {
            return 0.6f;
        }
        if(n > 9)
        {
            return 0.5f;
        }
        else
        {
            return 1;
        }
    }

    public static bool ItemUpgrade(int grade)
    {
        float F;
        System.Random r = new System.Random();
        F = r.Next(0, 100);

        if (1-ReturnProbForRein(grade) <= F * 0.01)
        {
            return true;
        }
        else if (1-ReturnProbForRein(grade) > F * 0.01)
        {
            return false;
        }

        else return false;
    }

   




}
