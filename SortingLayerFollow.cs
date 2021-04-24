using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingLayerFollow : MonoBehaviour
{
    
    
    // Update is called once per frame
    void Update()
    {
        this.GetComponent<SpriteRenderer>().GetComponent<Renderer>().sortingOrder = this.transform.parent.parent.GetComponent<SpriteRenderer>().sortingOrder+1;
    }
}
