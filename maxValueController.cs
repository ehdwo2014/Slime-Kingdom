using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maxValueController : MonoBehaviour
{
    public static long MaxMoney = 99999999999999999;
    public static int MaxDia = 9999999;
    public static int MaxSlimeLevel = 250;
    public static int MaxSkillLevel = 50;
    public static int MaxItemAmount = 99999;

    // Update is called once per frame
    void Update()
    {
        if(PlayerInfor.Money > 99999999999999999)
        {
            PlayerInfor.Money = 99999999999999999;
        }
        

        if(PlayerInfor.Diamond > 99999)
        {
            PlayerInfor.Diamond = 9999999;
        }
        

        




        

    }
}
