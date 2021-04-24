using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDes : MonoBehaviour
{
    public GameObject SelecItem;
    public GameObject SoundDB;
    // Start is called before the first frame update
    void Start()
    {
        SoundDB = GameObject.Find("SoundSources");
        SelecItem = GameObject.Find("SelectedItem");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickReqItem()
    {
        SoundDB.GetComponent<SoundController>().CallCancelSound();
        SelecItem.GetComponent<SelectedItem>().selectedMT = this.transform.parent.GetComponent<RequiredMaterial>().RequireMT;
        MaterialUI.SwitchMaterialUI = true;

    }
}
