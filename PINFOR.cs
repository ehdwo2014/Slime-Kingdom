using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PINFOR : MonoBehaviour
{
    public long MON;
    public int Dia;
    public int Sta;
    // Start is called before the first frame update
    void Start()
    {

        PlayerInfor.Money = MON;
        PlayerInfor.Diamond = Dia;
        PlayerInfor.Stage = Sta;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
