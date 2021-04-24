using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotImportE : MonoBehaviour
{
    public List<GameObject> slots = new List<GameObject>();
    public GameObject Database;
    int Index;
    public static int IsDraggingE = -1;
    // Start is called before the first frame update
    void Start()
    {
        AddChildOB(transform, slots);
        Index = slots.Count;
    }
    private void AddChildOB(Transform parent, List<GameObject> list)
    {
        foreach (Transform child in parent)
        {
            list.Add(child.gameObject);
        }
    }

    public void UpdateImage(GameObject Database, List<GameObject> list)
    {

        for (int i = 0; i < Index; i++)
        {
            if (IsDraggingE != i)
            {
                if (Database.GetComponent<EquipmentInventory>().eqs[i].EqLevel != 0)
                {

                    list[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "+" + Database.GetComponent<EquipmentInventory>().ReturnIndexEquipment(i).EqLevel.ToString();
                }
                else
                {
                    list[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "";
                }
                list[i].transform.GetChild(0).GetComponent<Image>().sprite = Database.GetComponent<EquipmentInventory>().ReturnIndexEquipment(i).EquipmentImage;
                list[i].transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = Database.GetComponent<EquipmentInventory>().ReturnIndexEquipment(i).EquipmentRank;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Index != 0)
        {
            UpdateImage(Database, slots);
        }
    }

}
