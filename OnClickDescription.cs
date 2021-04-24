using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickDescription : MonoBehaviour
{
    public GameObject Database;
    public GameObject PopUpThis;
    public Core CoreT;
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
        CoreT = Database.GetComponent<CoreInventory>().cores[Index];
        PopUpThis.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = Database.GetComponent<CoreInventory>().cores[Index].itemImage;
        PopUpThis.transform.GetChild(1).GetChild(0).GetComponent<Text>().text = Database.GetComponent<CoreInventory>().cores[Index].coreName;
        PopUpThis.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = Database.GetComponent<CoreInventory>().cores[Index].coreRank;
        PopUpThis.transform.GetChild(4).GetChild(0).GetComponent<Text>().text = Database.GetComponent<CoreInventory>().cores[Index].CoreDescription;
        PopUpThis.transform.GetChild(6).GetChild(0).GetComponent<Text>().text = "+ " + Database.GetComponent<CoreInventory>().cores[Index].coreLevel;
        PopUpThis.transform.GetChild(8).GetChild(0).GetComponent<Text>().text = Database.GetComponent<CoreInventory>().cores[Index].corePower.ToString();
    }
}
