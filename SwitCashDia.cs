using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitCashDia : MonoBehaviour
{
    public GameObject CashTable;
    public GameObject DiamondTable;

    public static bool CashOrDia;
    
    // Update is called once per frame
    void Update()
    {
        if(CashOrDia == true)
        {
            if(CashTable.activeSelf == false)
            {
                CashTable.gameObject.SetActive(true);
            }
            else if(DiamondTable.activeSelf == true)
            {
                DiamondTable.gameObject.SetActive(false);
            }
        }
        else if(CashOrDia == false)
        {
            if (CashTable.activeSelf == true)
            {
                CashTable.gameObject.SetActive(false);
            }
            else if (DiamondTable.activeSelf == false)
            {
                DiamondTable.gameObject.SetActive(true);
            }
        }
        
    }

    public void CashClick()
    {
        CashOrDia = false;
    }
    public void DiaClick()
    {
        CashOrDia = true;
    }


}
