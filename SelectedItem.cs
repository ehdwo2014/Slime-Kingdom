using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SelectedItem : MonoBehaviour
{
    public GameObject ColorCon;
    Color D;
    Color C;
    Color B;
    Color A;
    Color S;
    public Equipment selectedEQ;
    public Material selectedMT;
    public Core selectedCore;
    public GameObject CoreContent;
    public GameObject MaterialContent;
    public GameObject EQContent;
    public GameObject ReinforceUIA;
    public GameObject ReinforceUICore;



    // Start is called before the first frame update
    void Start()
    {
        
        D = ColorCon.GetComponent<ColorControl>().D;
        C = ColorCon.GetComponent<ColorControl>().C;
        B = ColorCon.GetComponent<ColorControl>().B;
        A = ColorCon.GetComponent<ColorControl>().A;
        S = ColorCon.GetComponent<ColorControl>().S;
    }

    // Update is called once per frame
    void Update()
    {
        if (CoreUI.SwitchCoreUI == true)
        {
            ItemRefactorizing.ChangingCore(selectedCore);
            CoreContent.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = selectedCore.fire.ToString() + " (+" + (selectedCore.fire - selectedCore.Originalfire).ToString() +")";
            CoreContent.transform.GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>().text = selectedCore.ice.ToString() + " (+" + (selectedCore.ice - selectedCore.Originalice).ToString() + ")";
            CoreContent.transform.GetChild(0).GetChild(3).GetComponent<TextMeshProUGUI>().text = selectedCore.dark.ToString() + " (+" + (selectedCore.dark - selectedCore.Originaldark).ToString() + ")";
            CoreContent.transform.GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = selectedCore.light.ToString() + " (+" + (selectedCore.light - selectedCore.Originallight).ToString() + ")";
            CoreContent.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = selectedCore.coreName + " (+" + selectedCore.coreLevel + ")";
            CoreContent.transform.GetChild(1).GetChild(1).GetComponent<TextMeshProUGUI>().text = selectedCore.corePower.ToString();
            CoreContent.transform.GetChild(1).GetChild(2).GetChild(0).GetComponent<Image>().sprite = selectedCore.itemImage;
            CoreContent.transform.GetChild(1).GetChild(2).GetChild(1).GetComponent<TextMeshProUGUI>().text = selectedCore.coreRank;
            CoreContent.transform.GetChild(1).GetChild(2).GetChild(2).GetComponent<TextMeshProUGUI>().text = "+" + selectedCore.coreLevel.ToString();
            CoreContent.transform.GetChild(1).GetChild(3).GetComponent<TextMeshProUGUI>().text = selectedCore.coreRank;
            CoreContent.transform.GetChild(1).GetChild(4).GetComponent<TextMeshProUGUI>().text = selectedCore.price.ToString();
            CoreContent.transform.GetChild(1).GetChild(5).GetChild(0).GetComponent<TextMeshProUGUI>().text = selectedCore.CoreDescription;

            if (selectedCore.coreRank.Equals("D"))
            {
                CoreContent.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().color = D;
                CoreContent.transform.GetChild(1).GetChild(2).GetChild(1).GetComponent<TextMeshProUGUI>().color = D;
                CoreContent.transform.GetChild(1).GetChild(3).GetComponent<TextMeshProUGUI>().color = D;
            }
            else if (selectedCore.coreRank.Equals("C"))
            {
                CoreContent.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().color = C;
                CoreContent.transform.GetChild(1).GetChild(2).GetChild(1).GetComponent<TextMeshProUGUI>().color = C;
                CoreContent.transform.GetChild(1).GetChild(3).GetComponent<TextMeshProUGUI>().color = C;
            }
            else if (selectedCore.coreRank.Equals("B"))
            {
                CoreContent.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().color = B;
                CoreContent.transform.GetChild(1).GetChild(2).GetChild(1).GetComponent<TextMeshProUGUI>().color = B;
                CoreContent.transform.GetChild(1).GetChild(3).GetComponent<TextMeshProUGUI>().color = B;
            }
            else if (selectedCore.coreRank.Equals("A"))
            {
                CoreContent.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().color = A;
                CoreContent.transform.GetChild(1).GetChild(2).GetChild(1).GetComponent<TextMeshProUGUI>().color = A;
                CoreContent.transform.GetChild(1).GetChild(3).GetComponent<TextMeshProUGUI>().color = A;
            }
            else if (selectedCore.coreRank.Equals("S"))
            {
                CoreContent.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().color = S;
                CoreContent.transform.GetChild(1).GetChild(2).GetChild(1).GetComponent<TextMeshProUGUI>().color = S;
                CoreContent.transform.GetChild(1).GetChild(3).GetComponent<TextMeshProUGUI>().color = S;
            }

            CoreContent.transform.GetChild(2).GetChild(0).GetComponent<TextMeshProUGUI>().text = Mathf.RoundToInt(selectedCore.STR).ToString() + " (+" + Mathf.RoundToInt(selectedCore.STR - selectedCore.STROri).ToString() + ")";
            CoreContent.transform.GetChild(2).GetChild(1).GetComponent<TextMeshProUGUI>().text = Mathf.RoundToInt(selectedCore.INT).ToString() + " (+" + Mathf.RoundToInt(selectedCore.INT - selectedCore.INTOri).ToString() + ")";
            CoreContent.transform.GetChild(2).GetChild(2).GetComponent<TextMeshProUGUI>().text = Mathf.RoundToInt(selectedCore.DEX).ToString() + " (+" + Mathf.RoundToInt(selectedCore.DEX - selectedCore.DEXOri).ToString() + ")";
            CoreContent.transform.GetChild(2).GetChild(3).GetComponent<TextMeshProUGUI>().text = Mathf.RoundToInt(selectedCore.LUK).ToString() + " (+" + Mathf.RoundToInt(selectedCore.LUK - selectedCore.LUKOri).ToString() + ")";

            CoreContent.transform.parent.parent.parent.GetChild(4).GetChild(0).GetComponent<TextMeshProUGUI>().text = MoneyUnitControl.FormatNumber(System.Convert.ToInt64(selectedCore.priceToUpgrade)).ToString();

        }


        if (MaterialUI.SwitchMaterialUI == true)
        {
            MaterialContent.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Image>().sprite = selectedMT.MaterialImage;
            MaterialContent.transform.GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>().text = selectedMT.MaterialName;
            MaterialContent.transform.GetChild(0).GetChild(2).GetChild(0).GetComponent<TextMeshProUGUI>().text = selectedMT.MaterialRank;
            MaterialContent.transform.GetChild(0).GetChild(3).GetChild(0).GetComponent<TextMeshProUGUI>().text = selectedMT.Description;
            MaterialContent.transform.GetChild(0).GetChild(4).GetComponent<TextMeshProUGUI>().text = selectedMT.Price.ToString();

            if (selectedMT.MaterialRank.Equals("D"))
            {
                MaterialContent.transform.GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>().color = D;
                MaterialContent.transform.GetChild(0).GetChild(2).GetChild(0).GetComponent<TextMeshProUGUI>().color = D;
            }
            else if (selectedMT.MaterialRank.Equals("C"))
            {
                MaterialContent.transform.GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>().color = C;
                MaterialContent.transform.GetChild(0).GetChild(2).GetChild(0).GetComponent<TextMeshProUGUI>().color = C;
            }
            else if (selectedMT.MaterialRank.Equals("B"))
            {
                MaterialContent.transform.GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>().color = B;
                MaterialContent.transform.GetChild(0).GetChild(2).GetChild(0).GetComponent<TextMeshProUGUI>().color = B;
            }
            else if (selectedMT.MaterialRank.Equals("A"))
            {
                MaterialContent.transform.GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>().color = A;
                MaterialContent.transform.GetChild(0).GetChild(2).GetChild(0).GetComponent<TextMeshProUGUI>().color = A;
            }
            else if (selectedMT.MaterialRank.Equals("S"))
            {
                MaterialContent.transform.GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>().color = S;
                MaterialContent.transform.GetChild(0).GetChild(2).GetChild(0).GetComponent<TextMeshProUGUI>().color = S;
            }

        }

        if (EquipmentUI.SwitchEQUI == true)
        {
            ItemRefactorizing.ChaningEQ(selectedEQ);
            EQContent.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = selectedEQ.fire.ToString() + " (+" + (selectedEQ.fire - selectedEQ.originalfire).ToString() + ")";
            EQContent.transform.GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>().text = selectedEQ.ice.ToString() + " (+" + (selectedEQ.ice - selectedEQ.originalice).ToString() + ")";
            EQContent.transform.GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = selectedEQ.light.ToString() + " (+" + (selectedEQ.light - selectedEQ.originallight).ToString() + ")";
            EQContent.transform.GetChild(0).GetChild(3).GetComponent<TextMeshProUGUI>().text = selectedEQ.dark.ToString() + " (+" + (selectedEQ.dark - selectedEQ.originaldark).ToString() +")";

            EQContent.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = selectedEQ.EquipmentName + " (+" + selectedEQ.EqLevel + ")";
            EQContent.transform.GetChild(1).GetChild(1).GetComponent<TextMeshProUGUI>().text = selectedEQ.typeOfEQ;
            EQContent.transform.GetChild(1).GetChild(2).GetComponent<TextMeshProUGUI>().text = Mathf.RoundToInt(selectedEQ.PhysicalAttack).ToString() + " (+" + Mathf.RoundToInt((selectedEQ.PhysicalAttack - selectedEQ.PhysicalAttackOrigin)).ToString() + ")";
            EQContent.transform.GetChild(1).GetChild(3).GetComponent<TextMeshProUGUI>().text = Mathf.RoundToInt(selectedEQ.MagicalAttack).ToString() + " (+" + Mathf.RoundToInt((selectedEQ.MagicalAttack - selectedEQ.MagicalAttackOrigin)).ToString() + ")";
            EQContent.transform.GetChild(1).GetChild(4).GetChild(0).GetComponent<Image>().sprite = selectedEQ.EquipmentImage;
            EQContent.transform.GetChild(1).GetChild(4).GetChild(1).GetComponent<TextMeshProUGUI>().text = selectedEQ.EquipmentRank;
            EQContent.transform.GetChild(1).GetChild(4).GetChild(2).GetComponent<TextMeshProUGUI>().text = "+" + selectedEQ.EqLevel.ToString();
            EQContent.transform.GetChild(1).GetChild(5).GetComponent<TextMeshProUGUI>().text = selectedEQ.Price.ToString();
            EQContent.transform.GetChild(1).GetChild(6).GetChild(0).GetComponent<TextMeshProUGUI>().text = selectedEQ.Description;

            EQContent.transform.parent.parent.parent.GetChild(5).GetChild(0).GetComponent<TextMeshProUGUI>().text = MoneyUnitControl.FormatNumber(selectedEQ.PriceToUpgrade);


            if (selectedEQ.EquipmentRank.Equals("D"))
            {
                EQContent.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().color = D;
                EQContent.transform.GetChild(1).GetChild(4).GetChild(1).GetComponent<TextMeshProUGUI>().color = D;
            }

            else if (selectedEQ.EquipmentRank.Equals("C"))
            {
                EQContent.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().color = C;
                EQContent.transform.GetChild(1).GetChild(4).GetChild(1).GetComponent<TextMeshProUGUI>().color = C;
            }
            else if (selectedEQ.EquipmentRank.Equals("B"))
            {
                EQContent.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().color = B;
                EQContent.transform.GetChild(1).GetChild(4).GetChild(1).GetComponent<TextMeshProUGUI>().color = B;
            }
            else if (selectedEQ.EquipmentRank.Equals("A"))
            {
                EQContent.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().color = A;
                EQContent.transform.GetChild(1).GetChild(4).GetChild(1).GetComponent<TextMeshProUGUI>().color = A;
            }
            else if (selectedEQ.EquipmentRank.Equals("S"))
            {
                EQContent.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().color = S;
                EQContent.transform.GetChild(1).GetChild(4).GetChild(1).GetComponent<TextMeshProUGUI>().color = S;
            }



            if (selectedEQ.IsItEquipped == false)
            {
                EQContent.transform.parent.parent.parent.GetChild(2).gameObject.SetActive(true);
                EQContent.transform.parent.parent.parent.GetChild(3).gameObject.SetActive(false);

            }
            else if (selectedEQ.IsItEquipped == true)
            {
                EQContent.transform.parent.parent.parent.GetChild(2).gameObject.SetActive(false);
                EQContent.transform.parent.parent.parent.GetChild(3).gameObject.SetActive(true);

            }



        }


        if (ReinforceUI.SwitchReinUI == true)
        {

            ReinforceUIA.transform.GetChild(2).GetChild(0).GetComponent<Image>().sprite = selectedEQ.EquipmentImage;
            ReinforceUIA.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = selectedEQ.EquipmentName + " (+" + selectedEQ.EqLevel.ToString() + ")";
            ReinforceUIA.transform.GetChild(4).GetComponent<TextMeshProUGUI>().text = "+" + selectedEQ.EqLevel.ToString();
            ReinforceUIA.transform.GetChild(5).GetComponent<TextMeshProUGUI>().text = "+" + (selectedEQ.EqLevel + 1).ToString();
            ReinforceUIA.transform.GetChild(6).GetComponent<TextMeshProUGUI>().text = (MoneyUnitControl.ReturnProbForRein(selectedEQ.EqLevel) * 100).ToString() + " %";
            ReinforceUIA.transform.GetChild(8).GetComponent<TextMeshProUGUI>().text = MoneyUnitControl.FormatNumber(selectedEQ.PriceToUpgrade);
        }
        if (ReinforceCoreUI.SwitchReinCoreUI == true)
        {
            ReinforceUICore.transform.GetChild(2).GetChild(0).GetComponent<Image>().sprite = selectedCore.itemImage;

            ReinforceUICore.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = selectedCore.coreName + " (+" + selectedCore.coreLevel.ToString() + ")";
            ReinforceUICore.transform.GetChild(4).GetComponent<TextMeshProUGUI>().text = "+" + selectedCore.coreLevel.ToString();
            ReinforceUICore.transform.GetChild(5).GetComponent<TextMeshProUGUI>().text = "+" + (selectedCore.coreLevel + 1).ToString();
            ReinforceUICore.transform.GetChild(6).GetComponent<TextMeshProUGUI>().text = (MoneyUnitControl.ReturnProbForRein(selectedCore.coreLevel) * 100).ToString() + " %";
            ReinforceUICore.transform.GetChild(8).GetComponent<TextMeshProUGUI>().text = MoneyUnitControl.FormatNumber(System.Convert.ToInt64(selectedCore.priceToUpgrade));



        }



    }
}
