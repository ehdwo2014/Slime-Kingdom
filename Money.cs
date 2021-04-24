using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public long MoneyC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoneyC = PlayerInfor.Money;
        this.GetComponent<Text>().text = MoneyUnitControl.FormatNumber(MoneyC);

    }
}
