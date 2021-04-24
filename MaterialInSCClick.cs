using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialInSCClick : MonoBehaviour
{
    public GameObject Database;
    public GameObject DatabaseSC;
    public GameObject content;
    List<GameObject> Slots = new List<GameObject>();
    Color OriginalColor = new Color(0.97f, 0.8f, 0.67f, 1);


    // Start is called before the first frame update
    void Start()
    {
        Slots = content.GetComponent<SlotImportM>().slots;

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ClickInMaterialIcon()
    {
        int firstEmptyIndex = -1;
        if (DatabaseSC.GetComponent<MaterialInventory>().materials[0].materialID != 0)
        {


            firstEmptyIndex = Database.GetComponent<MaterialInventory>().FindEmptyFirstIndex();

            if (firstEmptyIndex != -1 || Database.GetComponent<MaterialInventory>().IsThereSuchMaterial(DatabaseSC.GetComponent<MaterialInventory>().materials[0].materialID) == true)
            {
                Database.GetComponent<MaterialInventory>().AddMaterial(DatabaseSC.GetComponent<MaterialInventory>().materials[0]);
                DatabaseSC.GetComponent<MaterialInventory>().materials[0] = new Material();
                return;
            }




        }


        return;
    }
}
