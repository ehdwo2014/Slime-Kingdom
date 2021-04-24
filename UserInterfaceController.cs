using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInterfaceController : MonoBehaviour
{
    public GameObject InventoryUI;
    public GameObject SCUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TurnOnOfInVUI()
    {
        if(ButtonSwitch.Swit == true)
        {
            TurnOffInventoryUI();
        }
        else if(ButtonSwitch.Swit == false)
        {
            TurnOnInventoryUI();
        }

    }

    public void TurnOnInventoryUI()
    {
        InventoryUI.SetActive(true);
        ButtonSwitch.Swit = true;
    }
    public void TurnOffInventoryUI()
    {
        ButtonSwitch.Swit = false;
    }
}
