using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotImportM : MonoBehaviour
{
    public List<GameObject> slots = new List<GameObject>();
    public GameObject Database;
    int Index;
    public static int IsDraggingM = -1;
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
            if (IsDraggingM != i)
            {
                list[i].transform.GetChild(0).GetComponent<Image>().sprite = Database.GetComponent<MaterialInventory>().ReturnIndexMaterial(i).MaterialImage;
                list[i].transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = Database.GetComponent<MaterialInventory>().ReturnIndexMaterial(i).MaterialRank;
                list[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = Database.GetComponent<MaterialInventory>().ReturnIndexMaterial(i).Amount.ToString();
                if(Database.GetComponent<MaterialInventory>().ReturnIndexMaterial(i).materialID == 0)
                {
                    list[i].transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = "";
                    list[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "";
                }
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
