using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeOnCas : MonoBehaviour
{
    public GameObject SC;
    public GameObject SlimeCas;
    public GameObject SlimeTemp;
    int SizeOfGroups;
    int SizeOfSlimes;
    int InvIndex;

    // Start is called before the first frame update
    void Start()
    {
        SizeOfGroups = 5;
        SizeOfSlimes = 5;
        InvIndex = this.transform.parent.GetSiblingIndex() * SizeOfGroups + this.transform.GetSiblingIndex();
        SC = GameObject.Find("SC");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (SlimeCas != null)
        {
            if (SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex] != null)
            {
                SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex].GetComponent<SpriteRenderer>().flipX = true;
                SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex].transform.localScale = new Vector3(0.3f, 0.3f, 1);
                SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex].transform.position = this.transform.position;
                SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex].GetComponent<SpriteRenderer>().sortingOrder = 10;
                SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex].GetComponent<Rigidbody2D>().gravityScale = 0;
                SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex].GetComponent<SlimeWork>().WorkIndex = 0;
                SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex].GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
            }
        }


    }
}
