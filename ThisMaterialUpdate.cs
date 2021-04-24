using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisMaterialUpdate : MonoBehaviour
{
    public GameObject DatabaseMT;
    public List<Material> MTINV;
    int MTcount;
    // Start is called before the first frame update
    void Start()
    {
        MTcount = this.GetComponent<MaterialInventory>().materials.Count;
        MTINV = DatabaseMT.GetComponent<MaterialInventory>().materials;
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i< MTcount; i++)
        {
            this.GetComponent<MaterialInventory>().materials[i].MaterialImage = DatabaseMT.GetComponent<MaterialInventory>().materials[this.GetComponent<MaterialInventory>().materials[i].materialID].MaterialImage;
            this.GetComponent<MaterialInventory>().materials[i].MaterialName = DatabaseMT.GetComponent<MaterialInventory>().materials[this.GetComponent<MaterialInventory>().materials[i].materialID].MaterialName;
            this.GetComponent<MaterialInventory>().materials[i].MaterialRank = DatabaseMT.GetComponent<MaterialInventory>().materials[this.GetComponent<MaterialInventory>().materials[i].materialID].MaterialRank;
            this.GetComponent<MaterialInventory>().materials[i].Price = DatabaseMT.GetComponent<MaterialInventory>().materials[this.GetComponent<MaterialInventory>().materials[i].materialID].Price;
            this.GetComponent<MaterialInventory>().materials[i].Description = DatabaseMT.GetComponent<MaterialInventory>().materials[this.GetComponent<MaterialInventory>().materials[i].materialID].Description;

        }
    }
}
