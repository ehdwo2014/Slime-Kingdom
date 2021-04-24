using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class DroppingM : MonoBehaviour, IDropHandler
{

    public int FromIndexM;
    public int ToIndexM;
    public GameObject DatabaseM;
    public Material AlterM;
    Color OriginalColor = new Color(0.97f, 0.8f, 0.67f, 1);
    int n=-1;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null && eventData.pointerDrag.GetComponent<DraggerM>() != null)
        {
            Debug.Log("Getting");
            FromIndexM = eventData.pointerDrag.GetComponent<DraggerM>().parentIndexM;
            if (DatabaseM.GetComponent<MaterialInventory>().materials[FromIndexM].materialID != 0)
            {
                AlterM = DatabaseM.GetComponent<MaterialInventory>().ReturnIndexMaterial(FromIndexM);
                DatabaseM.GetComponent<MaterialInventory>().MaterialSort(FromIndexM, ToIndexM);
            }
            
            
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        ToIndexM = transform.GetSiblingIndex();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
