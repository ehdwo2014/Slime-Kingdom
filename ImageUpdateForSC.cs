using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ImageUpdateForSC : MonoBehaviour
{

    public GameObject StoreCore;
    public GameObject SotreMaterial;
    public bool IsItMaterialOrCore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(IsItMaterialOrCore == false)
        {
            UpdateMaterialIM();
        }
        if(IsItMaterialOrCore == true)
        {
            UpdateCoreIM();
        }
        
    }


    public void UpdateCoreIM()
    {
        this.transform.GetChild(0).GetComponent<Image>().sprite = StoreCore.GetComponent<CoreInventory>().cores[0].itemImage;
        this.transform.GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>().text = StoreCore.GetComponent<CoreInventory>().cores[0].coreRank;
        this.transform.GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>().color = SetTheColor(StoreCore.GetComponent<CoreInventory>().cores[0].coreRank);
        if (StoreCore.GetComponent<CoreInventory>().cores[0].coreID != 0)
        {
            this.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "+" + StoreCore.GetComponent<CoreInventory>().cores[0].coreLevel;
        }
        else
        {
            this.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "";
        }
    }
    public void UpdateMaterialIM()
    {
        this.transform.GetChild(0).GetComponent<Image>().sprite = SotreMaterial.GetComponent<MaterialInventory>().materials[0].MaterialImage;
        this.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = SotreMaterial.GetComponent<MaterialInventory>().materials[0].MaterialRank;
        this.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().color = SetTheColor(SotreMaterial.GetComponent<MaterialInventory>().materials[0].MaterialRank);
    }



    public Color SetTheColor(string Rank)
    {
        if (Rank != null)
        {
            if (Rank.Equals("C"))
            {
                return new Color(0, 1, 0);
            }

            else if (Rank.Equals("B"))
            {
                return new Color(0, 0, 1);
            }

            else if (Rank.Equals("A"))
            {
                return new Color(1, 0, 0);
            }
            else if (Rank.Equals("S"))
            {
                return new Color(1, 0, 0.75f);
            }
            else
            {
                return new Color(0, 0, 0);
            }
        }
        else
        {
            return new Color(0, 0, 0);
        }
    }




}
