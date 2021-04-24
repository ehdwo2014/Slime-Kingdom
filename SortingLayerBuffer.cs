using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingLayerBuffer : MonoBehaviour
{
    public bool SortingLayerUpOrDownSlime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SortingLayerUpOrDownSlime == false)
        {
            this.GetComponent<Renderer>().sortingOrder = this.transform.parent.parent.GetComponent<Renderer>().sortingOrder;
        }
        if (SortingLayerUpOrDownSlime == true)
        {
            this.GetComponent<Renderer>().sortingOrder = 1+ this.transform.parent.parent.GetComponent<Renderer>().sortingOrder;
        }

    }
}
