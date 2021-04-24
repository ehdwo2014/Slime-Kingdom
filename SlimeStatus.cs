using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class SlimeStatus : MonoBehaviour
{
    public GameObject SS;
    GameObject content;
    public Slime SOS;
    public GameObject ColorCon;
    Color D;
    Color C;
    Color B;
    Color A;
    Color S;
    // Start is called before the first frame update
    void Start()
    {
        content = this.transform.GetChild(0).GetChild(0).GetChild(0).gameObject;
        ColorCon = GameObject.Find("ColorCon");
        D = ColorCon.GetComponent<ColorControl>().D;
        C = ColorCon.GetComponent<ColorControl>().C;
        B = ColorCon.GetComponent<ColorControl>().B;
        A = ColorCon.GetComponent<ColorControl>().A;
        S = ColorCon.GetComponent<ColorControl>().S;
    }

    // Update is called once per frame
    void Update()
    {
        if(SS.GetComponent<SlimeSelection>().SelectedSlime != null)
        {
            SOS = SS.GetComponent<SlimeSelection>().SelectedSlime.GetComponent<SlimeState>().slimeState;
        }
        if (SOS != null)
        {
            content.transform.GetChild(2).GetComponent<Image>().sprite = SOS.SlimeSprite;
            content.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = SOS.SlimeRank;
            content.transform.GetChild(4).GetComponent<TextMeshProUGUI>().text = SOS.Level.ToString();
            content.transform.GetChild(5).GetComponent<TextMeshProUGUI>().text = SOS.PhysicalATK.ToString();
            content.transform.GetChild(6).GetComponent<TextMeshProUGUI>().text = SOS.MagicalATK.ToString();
            content.transform.GetChild(7).GetComponent<TextMeshProUGUI>().text = SOS.MovementSpeed.ToString();
            content.transform.GetChild(8).GetComponent<TextMeshProUGUI>().text = (Mathf.Round(SOS.CriticalPoint * 100)).ToString() +"%";
            content.transform.GetChild(9).GetComponent<TextMeshProUGUI>().text = SOS.MiningAbility.ToString();
            content.transform.GetChild(10).GetComponent<TextMeshProUGUI>().text = SOS.Fire.ToString();
            content.transform.GetChild(11).GetComponent<TextMeshProUGUI>().text = SOS.Ice.ToString();
            content.transform.GetChild(12).GetComponent<TextMeshProUGUI>().text = SOS.Light.ToString();
            content.transform.GetChild(13).GetComponent<TextMeshProUGUI>().text = SOS.Dark.ToString();

            if(SOS.SlimeRank.Equals("D"))
            {
                content.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color = D;
                content.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color = D;
            }
            if(SOS.SlimeRank.Equals("C"))
            {
                content.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color = C;
                content.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color = C;
            }
            if(SOS.SlimeRank.Equals("B"))
            {
                content.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color = B;
                content.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color = B;
            }
            if(SOS.SlimeRank.Equals("A"))
            {
                content.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color = A;
                content.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color = A;
            }
            if(SOS.SlimeRank.Equals("S"))
            {
                content.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color = S;
                content.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color = S;
            }



            content.transform.GetChild(14).GetChild(0).GetComponent<Image>().sprite = SOS.Weapon.EquipmentImage;
            content.transform.GetChild(14).GetChild(1).GetComponent<TextMeshProUGUI>().text = SOS.Weapon.EquipmentRank;
            content.transform.GetChild(14).GetChild(2).GetComponent<TextMeshProUGUI>().text = "+" + SOS.Weapon.EqLevel;

            if(SOS.Weapon.EquipmentRank.Equals("D"))
            {
                content.transform.GetChild(14).GetChild(1).GetComponent<TextMeshProUGUI>().color = D;
            }
            else if (SOS.Weapon.EquipmentRank.Equals("C"))
            {
                content.transform.GetChild(14).GetChild(1).GetComponent<TextMeshProUGUI>().color = C;
            }
            else if (SOS.Weapon.EquipmentRank.Equals("B"))
            {
                content.transform.GetChild(14).GetChild(1).GetComponent<TextMeshProUGUI>().color = B;
            }
            else if (SOS.Weapon.EquipmentRank.Equals("A"))
            {
                content.transform.GetChild(14).GetChild(1).GetComponent<TextMeshProUGUI>().color = A;
            }
            else if (SOS.Weapon.EquipmentRank.Equals("S"))
            {
                content.transform.GetChild(14).GetChild(1).GetComponent<TextMeshProUGUI>().color = S;
            }





            content.transform.GetChild(15).GetChild(0).GetComponent<Image>().sprite = SOS.Accessory.EquipmentImage;
            content.transform.GetChild(15).GetChild(1).GetComponent<TextMeshProUGUI>().text = SOS.Accessory.EquipmentRank;
            content.transform.GetChild(15).GetChild(2).GetComponent<TextMeshProUGUI>().text = "+" + SOS.Accessory.EqLevel.ToString();


            if (SOS.Accessory.EquipmentRank.Equals("D"))
            {
                content.transform.GetChild(15).GetChild(1).GetComponent<TextMeshProUGUI>().color = D;
            }
            else if (SOS.Accessory.EquipmentRank.Equals("C"))
            {
                content.transform.GetChild(15).GetChild(1).GetComponent<TextMeshProUGUI>().color = C;
            }
            else if (SOS.Accessory.EquipmentRank.Equals("B"))
            {
                content.transform.GetChild(15).GetChild(1).GetComponent<TextMeshProUGUI>().color = B;
            }
            else if (SOS.Accessory.EquipmentRank.Equals("A"))
            {
                content.transform.GetChild(15).GetChild(1).GetComponent<TextMeshProUGUI>().color = A;
            }
            else if (SOS.Accessory.EquipmentRank.Equals("S"))
            {
                content.transform.GetChild(15).GetChild(1).GetComponent<TextMeshProUGUI>().color = S;
            }





            content.transform.GetChild(16).GetChild(0).GetComponent<Image>().sprite = SOS.Aura.EquipmentImage;
            content.transform.GetChild(16).GetChild(1).GetComponent<TextMeshProUGUI>().text = SOS.Aura.EquipmentRank;
            content.transform.GetChild(16).GetChild(2).GetComponent<TextMeshProUGUI>().text = "+" + SOS.Aura.EqLevel.ToString();


            if (SOS.Aura.EquipmentRank.Equals("D"))
            {
                content.transform.GetChild(16).GetChild(1).GetComponent<TextMeshProUGUI>().color = D;
            }
            else if (SOS.Aura.EquipmentRank.Equals("C"))
            {
                content.transform.GetChild(16).GetChild(1).GetComponent<TextMeshProUGUI>().color = C;
            }
            else if (SOS.Aura.EquipmentRank.Equals("B"))
            {
                content.transform.GetChild(16).GetChild(1).GetComponent<TextMeshProUGUI>().color = B;
            }
            else if (SOS.Aura.EquipmentRank.Equals("A"))
            {
                content.transform.GetChild(16).GetChild(1).GetComponent<TextMeshProUGUI>().color = A;
            }
            else if (SOS.Aura.EquipmentRank.Equals("S"))
            {
                content.transform.GetChild(16).GetChild(1).GetComponent<TextMeshProUGUI>().color = S;
            }



            content.transform.GetChild(17).GetChild(0).GetComponent<Image>().sprite = SOS.UsedCore.itemImage;
            content.transform.GetChild(17).GetChild(1).GetComponent<TextMeshProUGUI>().text = SOS.UsedCore.coreRank;
            content.transform.GetChild(17).GetChild(2).GetComponent<TextMeshProUGUI>().text = "+" + SOS.UsedCore.coreLevel.ToString();


            if (SOS.UsedCore.coreRank.Equals("D"))
            {
                content.transform.GetChild(17).GetChild(1).GetComponent<TextMeshProUGUI>().color = D;
            }
            else if (SOS.UsedCore.coreRank.Equals("C"))
            {
                content.transform.GetChild(17).GetChild(1).GetComponent<TextMeshProUGUI>().color = C;
            }
            else if (SOS.UsedCore.coreRank.Equals("B"))
            {
                content.transform.GetChild(17).GetChild(1).GetComponent<TextMeshProUGUI>().color = B;
            }
            else if (SOS.UsedCore.coreRank.Equals("A"))
            {
                content.transform.GetChild(17).GetChild(1).GetComponent<TextMeshProUGUI>().color = A;
            }
            else if (SOS.UsedCore.coreRank.Equals("S"))
            {
                content.transform.GetChild(17).GetChild(1).GetComponent<TextMeshProUGUI>().color = S;
            }

            content.transform.GetChild(18).GetChild(0).GetComponent<TextMeshProUGUI>().text = SOS.STR.ToString();
            content.transform.GetChild(18).GetChild(1).GetComponent<TextMeshProUGUI>().text = SOS.INT.ToString();
            content.transform.GetChild(18).GetChild(2).GetComponent<TextMeshProUGUI>().text = SOS.DEX.ToString();
            content.transform.GetChild(18).GetChild(3).GetComponent<TextMeshProUGUI>().text = SOS.LUK.ToString();

            if (SOS.Level < maxValueController.MaxSlimeLevel)
            {
                content.transform.parent.parent.parent.GetChild(2).GetChild(0).GetComponent<TextMeshProUGUI>().text = MoneyUnitControl.FormatNumber(SOS.PriceToLevelUP);
                content.transform.parent.parent.parent.GetChild(2).GetChild(1).gameObject.SetActive(true);
                content.transform.parent.parent.parent.GetChild(2).GetComponent<Button>().interactable = true;
                content.transform.parent.parent.parent.GetChild(2).GetChild(2).gameObject.SetActive(true);

            }
            else
            {
                content.transform.parent.parent.parent.GetChild(2).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Max Level";
                content.transform.parent.parent.parent.GetChild(2).GetChild(1).gameObject.SetActive(false);
                content.transform.parent.parent.parent.GetChild(2).GetComponent<Button>().interactable = false;
                content.transform.parent.parent.parent.GetChild(2).GetChild(2).gameObject.SetActive(false);
            }

        }
    }
}
