using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StateCalc : MonoBehaviour
{
    System.Random S = new System.Random();

    float STR;
    float INT;
    float DEX;
    float LUK;
    float TOTAL = 100;
    float PSTR;
    float PINT;
    float PDEX;
    float PLUK;

    // Start is called before the first frame update
    void Start()
    {
        STR = S.Next(1, 100);
        INT = S.Next(1, 100);
        DEX = S.Next(1, 100);
        LUK = S.Next(1, 100);

        TOTAL = STR + INT + DEX + LUK;
        PSTR = STR / TOTAL;
        PINT = INT / TOTAL;
        PDEX = DEX / TOTAL;
        PLUK = LUK / TOTAL;
        

    }

}
