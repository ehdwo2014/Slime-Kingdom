using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SlotImport : MonoBehaviour
{
    public List<GameObject> slots = new List<GameObject>();
    public GameObject Database;
    int Index;
    public static int IsDragging = -1;
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
            if (IsDragging != i)
            {
                if (Database.GetComponent<CoreInventory>().cores[i].coreLevel != 0)
                {

                    list[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "+" + Database.GetComponent<CoreInventory>().ReturnIndexCore(i).coreLevel.ToString();
                }
                else
                {
                    list[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "";
                }
                list[i].transform.GetChild(0).GetComponent<Image>().sprite = Database.GetComponent<CoreInventory>().ReturnIndexCore(i).itemImage;
                list[i].transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = Database.GetComponent<CoreInventory>().ReturnIndexCore(i).coreRank;
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



