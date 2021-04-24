using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDeleteConfirmUICore : MonoBehaviour
{
    public GameObject SelectedIT;
    public GameObject SoundDB;

    // Update is called once per frame
    void Update()
    {
        if (SelectedIT.GetComponent<SelectedItem>().selectedCore.coreID == 0 || SelectedIT.GetComponent<SelectedItem>().selectedCore.IsThisDesc == true || CoreUI.SwitchCoreUI == false)
        {
            this.gameObject.SetActive(false);
        }


    }
    public void SellThisItemCore()
    {
        if (SelectedIT.GetComponent<SelectedItem>().selectedCore.IsThisDesc == false)
        {
            SoundDB.GetComponent<SoundController>().CallSellSound();
            PlayerInfor.Money += SelectedIT.GetComponent<SelectedItem>().selectedCore.price;
            ResetCore();

        }
    }

    public void ClickCancelButton()
    {
        this.gameObject.SetActive(false);
    }
    public void ResetCore()
    {
        SelectedIT.GetComponent<SelectedItem>().selectedCore.CoreDescription = "";
        SelectedIT.GetComponent<SelectedItem>().selectedCore.coreID = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedCore.coreLevel = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedCore.coreName = "";
        SelectedIT.GetComponent<SelectedItem>().selectedCore.corePower = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedCore.coreRank = "";
        SelectedIT.GetComponent<SelectedItem>().selectedCore.dark = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedCore.DEX = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedCore.DEXOri = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedCore.fire = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedCore.ice = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedCore.INT = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedCore.INTOri = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedCore.itemImage = null;
        SelectedIT.GetComponent<SelectedItem>().selectedCore.light = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedCore.LUK = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedCore.LUKOri = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedCore.OriginalcorePower = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedCore.Originaldark = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedCore.Originalfire = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedCore.Originalice = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedCore.Originallight = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedCore.price = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedCore.priceToUpgrade = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedCore.STR = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedCore.STROri = 0;




            }


}
