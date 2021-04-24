using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeClick : MonoBehaviour
{
    public GameObject SoundDB;
    public GameObject ButtonCancel;
    public static Vector3 OriginalCamPlace;


    // Start is called before the first frame update
    void Start()
    {
        SoundDB = GameObject.Find("SoundSources");
        ButtonCancel = GameObject.Find("SC");
        OriginalCamPlace = GameObject.Find("Camera1").transform.position;
        
    }
    void OnMouseDown()
    {
        if (ButtonCancel.GetComponent<SlimeSelection>().SelectedSlime == null && SlimeSelection.NowClickable == true)
        {
            SoundDB.GetComponent<SoundController>().CallCancelSound();
            ButtonCancel.GetComponent<SlimeSelection>().SelectedSlime = gameObject;
            OriginalCamPlace = GameObject.Find("Camera1").transform.position;
            SlimeSelection.NowClickable = false;
        }
        else if (ButtonCancel.GetComponent<SlimeSelection>().SelectedSlime != null)
        {
        }

    }
        // Update is called once per frame
        void Update()
    {
        

        }
        
    }
 

