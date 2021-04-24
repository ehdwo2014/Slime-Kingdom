using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SellButton : MonoBehaviour
{
    public GameObject SelectedIT;
    public GameObject MaterialDES;
    public Material ItemComparor;
 

    public int Amount;


    public void ClickP1()
    {
        Amount += 1;
    }
    public void ClickP2()
    {
        Amount += 10;
    }
    public void ClickP3()
    {
        Amount += 100;
    }

    public void ClickP4()
    {
        Amount += SelectedIT.GetComponent<SelectedItem>().selectedMT.Amount;
    }
    public void ClickM1()
    {
        Amount -= 1; 
    }
    public void ClickM2()
    {
        Amount -= 10;
    }
    public void ClickM3()
    {
        Amount -= 100;
    }
    public void ClickM4()
    {
        Amount = 0;
    }

    public void SetZero()
    {
        Amount = 0;
    }

    public void ClickCancel()
    {
        this.gameObject.SetActive(false);
        Amount = 0;
    }
    public void Confirm()
    {
        PlayerInfor.Money += Amount * SelectedIT.GetComponent<SelectedItem>().selectedMT.Price;
        SelectedIT.GetComponent<SelectedItem>().selectedMT.Amount -= Amount;
    }



    // Update is called once per frame
    void Update()
    {
        if(ItemComparor.materialID != SelectedIT.GetComponent<SelectedItem>().selectedMT.materialID)
        {
            Amount = 0;
        }
        ItemComparor = SelectedIT.GetComponent<SelectedItem>().selectedMT;
        


        if (Amount > SelectedIT.GetComponent<SelectedItem>().selectedMT.Amount)
        {
            Amount = SelectedIT.GetComponent<SelectedItem>().selectedMT.Amount;
        }
        if(Amount < 0)
        {
            Amount = 0;
        }
        this.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = Amount.ToString();
        this.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = SelectedIT.GetComponent<SelectedItem>().selectedMT.MaterialImage;
        this.transform.GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>().text = SelectedIT.GetComponent<SelectedItem>().selectedMT.Amount.ToString();
       
        if(SelectedIT.GetComponent<SelectedItem>().selectedMT.materialID == 0 || SelectedIT.GetComponent<SelectedItem>().selectedMT.Amount ==0)
        {
            this.gameObject.SetActive(false);
        }

    }


}
