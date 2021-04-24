using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDeleteConfirmUI : MonoBehaviour
{
    public GameObject SelectedIT;
    public GameObject SoundDB;


    // Update is called once per frame
    void Update()
    {
        if(SelectedIT.GetComponent<SelectedItem>().selectedEQ.EquipmentID == 0  || SelectedIT.GetComponent<SelectedItem>().selectedEQ.IsThisDesc == true || EquipmentUI.SwitchEQUI == false)
        {
            this.gameObject.SetActive(false);
        }


    }
    public void SellThisItemEQ()
    {
        if(SelectedIT.GetComponent<SelectedItem>().selectedEQ.IsThisDesc == false)
        {
            SoundDB.GetComponent<SoundController>().CallSellSound();
            PlayerInfor.Money += SelectedIT.GetComponent<SelectedItem>().selectedEQ.Price;
            ResetEQ();
            
        }
    }

    public void ClickCancelButton()
    {
        this.gameObject.SetActive(false);
    }



    public void ResetEQ()
    {
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.AttackPoint = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.CriticalPoint = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.dark = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.Description = "";
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.EqLevel = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.EquipmentID = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.EquipmentImage = null;
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.EquipmentName = "";
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.EquipmentRank = "";
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.fire = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.ice = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.light =0;
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.MagicalAttack = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.MagicalAttackOrigin = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.MovementSpeed = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.originaldark = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.originalfire = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.originalice = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.originallight = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.PhysicalAttack = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.PhysicalAttackOrigin = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.Price = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.PriceToUpgrade = 0;
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.typeOfAttack = "";
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.typeOfEQ = "";
        SelectedIT.GetComponent<SelectedItem>().selectedEQ.WorkingPoint = 0;

    }





}
