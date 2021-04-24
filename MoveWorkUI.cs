﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWorkUI : MonoBehaviour
{
    public GameObject OriginalDummy;
    public GameObject TargetDummy;
    Vector3 Original = new Vector3();
    Vector3 Target = new Vector3();
    public static bool SwitchWorkUI = false;
    public GameObject SS;

    // Start is called before the first frame update
    void Start()
    {
        Original = OriginalDummy.transform.position;
        Target = TargetDummy.transform.position;

        
    }

    // Update is called once per frame
    void Update()
    {

        Original = OriginalDummy.transform.position;
        Target = TargetDummy.transform.position;

        if (SwitchWorkUI == true)
        {
            //transform.position = Vector2.MoveTowards(transform.position, target, 1f);
            Vector2 velo = Vector2.zero;
            transform.position = Vector2.SmoothDamp(transform.position, Target, ref velo, 0.05f);
        }
        if (SwitchWorkUI == false)
        {
            if (Mathf.Abs(Original.x - this.transform.position.x) < 0.3 && Mathf.Abs(Original.y - this.transform.position.y) < 0.3)
            {
                this.gameObject.SetActive(false);
            }
            //transform.position = Vector2.MoveTowards(transform.position, Original, 1f);
            Vector2 velo = Vector2.zero;
            transform.position = Vector2.SmoothDamp(transform.position, Original, ref velo, 0.05f);
        }

        if(SS.GetComponent<SlimeSelection>().SelectedSlime == null)
        {
            SwitchWorkUI = false;
        }


    }
    public void SetSwitValue()
    {
        if(SwitchWorkUI == true)
        {
            SwitchWorkUI = false;
        }
        else if(SwitchWorkUI == false)
        {
            SwitchWorkUI = true;
        }
    }
}