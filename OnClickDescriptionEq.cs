using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickDescriptionEq : MonoBehaviour
{
    public GameObject Database;
    public GameObject PopUpThis;
    public Equipment EqT;
    int Index;
    // Start is called before the first frame update
    void Start()
    {
        Index = this.transform.GetSiblingIndex();


    }

    // Update is called once per frame
    void Update()
    {


    }
    public void ClickDes()
    {

        PopUpThis.SetActive(true);
        EqT = Database.GetComponent<EquipmentInventory>().eqs[Index];
        PopUpThis.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = Database.GetComponent<EquipmentInventory>().eqs[Index].EquipmentImage;
        PopUpThis.transform.GetChild(1).GetChild(0).GetComponent<Text>().text = Database.GetComponent<EquipmentInventory>().eqs[Index].EquipmentName;
        PopUpThis.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = Database.GetComponent<EquipmentInventory>().eqs[Index].EquipmentRank;
        PopUpThis.transform.GetChild(4).GetChild(0).GetComponent<Text>().text = Database.GetComponent<EquipmentInventory>().eqs[Index].Description;
        PopUpThis.transform.GetChild(6).GetChild(0).GetComponent<Text>().text = "+ " + Database.GetComponent<EquipmentInventory>().eqs[Index].EqLevel.ToString();
        PopUpThis.transform.GetChild(8).GetChild(0).GetComponent<Text>().text = Database.GetComponent<EquipmentInventory>().eqs[Index].Price.ToString();
    }
}
