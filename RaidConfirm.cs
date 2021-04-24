using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RaidConfirm : MonoBehaviour
{

    public int BossIndex;
    public GameObject RaidContent;
    public GameObject BossDB;
    public static int BossIndexReal = -1;
    public GameObject StageRaidT;

    // Start is called before the first frame update
    void Start()
    {
        RaidContent = GameObject.Find("ContentRaid");
        BossDB = GameObject.Find("BossMonsterDB");
    }

    // Update is called once per frame
    void Update()
    {
        if (BossIndex != -1)
        {
            this.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = RaidContent.transform.GetChild(BossIndex).GetChild(4).GetComponent<TextMeshProUGUI>().text ;
            this.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color = RaidContent.transform.GetChild(BossIndex).GetChild(4).GetComponent<TextMeshProUGUI>().color;

        }

    }

    public void RaidConfirming()
    {
        if(RaidContent.transform.GetChild(BossIndex).GetComponent<RequiredMaterial>().EnoughMT() == true)
        {
            RaidContent.transform.GetChild(BossIndex).GetComponent<RequiredMaterial>().RemoveItemsFromInvCrafting();
            BossIndexReal = BossIndex;
            StageRaidT.SetActive(true);
            ButtonStartBattle.Clickable = false;

        }

    }
    public void CancelRaid()
    {
        this.gameObject.SetActive(false);
    }

}
