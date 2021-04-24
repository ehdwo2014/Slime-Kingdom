using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickRev : MonoBehaviour
{
    
    GameObject Rev;
    public GameObject DatabaseCore;
    public GameObject DatabaseMaterial;
    public GameObject SC;
    public GameObject SC2;
    Rigidbody2D rb;	
    Animator Animator_Rev;	
    void Start()
    {
	Rev = GameObject.Find("Rev");
	Rigidbody2D rb = Rev.GetComponent<Rigidbody2D>();
	Animator_Rev = Rev.GetComponent<Animator>();
    }

void OnMouseDown()
{
Animator_Rev.SetBool("Clicked", true);
        if (DatabaseCore.GetComponent<CoreInventory>().cores[0].coreID != 0 && DatabaseMaterial.GetComponent<MaterialInventory>().materials[0].materialID !=0)
        {
            TransFormUISC.clickable = false;
            SC.GetComponent<Animator>().SetBool("True", true);
            SC2.GetComponent<Animator>().SetBool("True", true);
        }

}


    // Update is called once per frame
    void Update()
    {
if (Animator_Rev.GetCurrentAnimatorStateInfo(0).IsName("Stopping"))
{
Animator_Rev.SetBool("Clicked", false);
}        
if(SC.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Stopping"))
        {
            
        }

    }
}
