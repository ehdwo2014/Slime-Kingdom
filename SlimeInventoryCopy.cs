using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeInventoryCopy : MonoBehaviour
{
    public GameObject SlimeINVORI;
    public List<GameObject> SlimeList1 = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SlimeINVORI != null)
        {
            SlimeINVORI.GetComponent<SlimeInventory>().SlimeList = SlimeList1;
        }
    }
}
