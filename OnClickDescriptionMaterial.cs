using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickDescriptionMaterial : MonoBehaviour
{
    public GameObject Database;
    public GameObject PopUpThis;
    public Material MaterialT;
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
        MaterialT = Database.GetComponent<MaterialInventory>().materials[Index];
        PopUpThis.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = Database.GetComponent<MaterialInventory>().materials[Index].MaterialImage;
        PopUpThis.transform.GetChild(1).GetChild(0).GetComponent<Text>().text = Database.GetComponent<MaterialInventory>().materials[Index].MaterialName;
        PopUpThis.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = Database.GetComponent<MaterialInventory>().materials[Index].MaterialRank;
        PopUpThis.transform.GetChild(4).GetChild(0).GetComponent<Text>().text = Database.GetComponent<MaterialInventory>().materials[Index].Description;
        PopUpThis.transform.GetChild(6).GetChild(0).GetComponent<Text>().text = Database.GetComponent<MaterialInventory>().materials[Index].Price.ToString();
    }
}
