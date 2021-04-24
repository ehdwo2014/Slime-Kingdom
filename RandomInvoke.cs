using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RandomInvoke : MonoBehaviour
{
    System.Random r = new System.Random();
   float RandValue;
   public bool SetValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(SetValue == false)
        {
            RandValue = System.Convert.ToSingle(r.Next(0,5));
            Invoke("ActiveTrue", RandValue);
        }
        
    }
    public void ActiveTrue()
    {
        this.transform.GetChild(0).gameObject.SetActive(true);
        SetValue = true;
    }

}
