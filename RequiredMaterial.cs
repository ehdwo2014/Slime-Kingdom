using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RequiredMaterial : MonoBehaviour
{
    public Material RequireMT;
    public bool IsThereEnoughMT;
    public GameObject MTDB;
    public GameObject MTDatabaseOrigin;
    public int HowManyHas;
    public int HowManyRequired;
    public GameObject SoundDB;


    // Start is called before the first frame update
    void Start()
    {
        SoundDB = GameObject.Find("SoundSources");
        MTDB = GameObject.Find("MaterialInventory");
        MTDatabaseOrigin = GameObject.Find("DatabaseMT");
        
    }

    // Update is called once per frame
    void Update()
    {

        RequireMT.MaterialImage = MTDatabaseOrigin.GetComponent<MaterialInventory>().materials[RequireMT.materialID].MaterialImage;
        RequireMT.MaterialName = MTDatabaseOrigin.GetComponent<MaterialInventory>().materials[RequireMT.materialID].MaterialName;
        RequireMT.MaterialRank = MTDatabaseOrigin.GetComponent<MaterialInventory>().materials[RequireMT.materialID].MaterialRank;
        RequireMT.Price = MTDatabaseOrigin.GetComponent<MaterialInventory>().materials[RequireMT.materialID].Price;
        RequireMT.Description = MTDatabaseOrigin.GetComponent<MaterialInventory>().materials[RequireMT.materialID].Description;


        HowManyRequired = RequireMT.Amount;
        HowManyHas = MTDB.GetComponent<MaterialInventory>().HowManyItems(RequireMT.materialID);


        this.transform.GetChild(2).GetChild(1).GetComponent<Image>().sprite = RequireMT.MaterialImage;
        this.transform.GetChild(2).GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = HowManyHas.ToString() + "/" + HowManyRequired.ToString();

        if (HowManyRequired > HowManyHas)
        {
            this.transform.GetChild(2).GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color(1, 0, 0);
        }
        else if (HowManyRequired <= HowManyHas)
        {
            this.transform.GetChild(2).GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color(1, 1, 1);
        }


    }

    public bool EnoughMT()
    {
       
            if (MTDB.GetComponent<MaterialInventory>().IsThereSuchMaterial(RequireMT.materialID) == false)
            {
                return false;
            }

            if (MTDB.GetComponent<MaterialInventory>().HowManyItems(RequireMT.materialID) < RequireMT.Amount)
            {
                return false;
            }
        
        return true;
    }

    public void RemoveItemsFromInvCrafting()
    {
      MTDB.GetComponent<MaterialInventory>().RemoveMaterial(RequireMT, RequireMT.Amount);
    }
}
