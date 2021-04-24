using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialSaverSC : MonoBehaviour
{
    public GameObject SCDatabaes;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SCDatabaes.GetComponent<MaterialInventory>().materials[0].MaterialImage != this.GetComponent<SpriteRenderer>().sprite)
        {
            this.GetComponent<SpriteRenderer>().sprite = SCDatabaes.GetComponent<MaterialInventory>().materials[0].MaterialImage;
        }

    }
}
