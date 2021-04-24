using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UpGradeCas : MonoBehaviour
{

    public GameObject CasUI;
    public GameObject MTDB;

    public Material NeededMat;
    public GameObject SoundDB;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NeededMat.Amount = CasUI.GetComponent<GateWayHP>().GateWayStat[this.transform.GetSiblingIndex()];
        this.transform.GetChild(2).GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = NeededMat.Amount.ToString();

        if(IsEnoughMaterial())
        {
            this.GetComponent<Button>().interactable = true;
        }
        else if (IsEnoughMaterial() == false)
        {
            this.GetComponent<Button>().interactable = false;
        }

    }
    public void ClickUpgrade()
    {
        if(IsEnoughMaterial())
        {
            SoundDB.GetComponent<SoundController>().CallConfirmSound();
            MTDB.GetComponent<MaterialInventory>().RemoveMaterial(NeededMat, NeededMat.Amount);
            CasUI.GetComponent<GateWayHP>().GateWayStat[this.transform.GetSiblingIndex()]++;
        }

    }

    public bool IsEnoughMaterial()
    {
        if(MTDB.GetComponent<MaterialInventory>().HowManyItems(NeededMat.materialID) >= NeededMat.Amount)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
