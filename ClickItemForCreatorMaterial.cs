using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickItemForCreatorMaterial : MonoBehaviour
{
    public GameObject SCDatabase;
    public GameObject ItemDatabase;
    Material TempMaterial = new Material();
    public int index;
   

    // Start is called before the first frame update
    void Start()
    {
        index = transform.GetSiblingIndex();
      
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void OnClickItem()
    {
        if (SlotImportM.IsDraggingM == -1)
        {

            if (ButtonSwitSC.SwitSC == true && ItemDatabase.GetComponent<MaterialInventory>().materials[index].materialID != 0)
            {

                if (ItemDatabase.GetComponent<MaterialInventory>().IsThereSuchMaterial(TempMaterial.materialID) == true || ItemDatabase.GetComponent<MaterialInventory>().FindEmptyFirstIndex() != -1)
                {
                    TempMaterial = SCDatabase.GetComponent<MaterialInventory>().materials[0];
                    SCDatabase.GetComponent<MaterialInventory>().materials[0] = SCDatabase.GetComponent<MaterialInventory>().DeepCopyMT(ItemDatabase.GetComponent<MaterialInventory>().ReturnIndexMaterial(index));
                    SCDatabase.GetComponent<MaterialInventory>().materials[0].Amount = 1;
                    ItemDatabase.GetComponent<MaterialInventory>().materials[index].Amount--;
                    ItemDatabase.GetComponent<MaterialInventory>().AddMaterial(TempMaterial);

                }

            }
        }
      

        
    }


   

}
