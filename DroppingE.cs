using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DroppingE : MonoBehaviour, IDropHandler
{

    public int FromIndexE;
    public int ToIndexE;
    public GameObject DatabaseE;
    public Equipment AlterE;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null && eventData.pointerDrag.GetComponent<DraggerE>() != null)
        {
            Debug.Log("Getting");
            FromIndexE = eventData.pointerDrag.GetComponent<DraggerE>().parentIndexE;
            AlterE = DatabaseE.GetComponent<EquipmentInventory>().ReturnIndexEquipment(FromIndexE);
            DatabaseE.GetComponent<EquipmentInventory>().EquipmentSort(FromIndexE, ToIndexE);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        ToIndexE = transform.GetSiblingIndex();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
