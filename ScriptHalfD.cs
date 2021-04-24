using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScriptHalfD : MonoBehaviour
{
    public int i = 0;
    public Vector3 Original;
    public GameObject dummy;
    public Vector3 target;

    public Vector3 PlaceHereWhenCreate;

    // Start is called before the first frame update
    void Start()
    {
        Original = this.transform.position;
        target = Original;
        target.y = Original.y + 0.5f;
        PlaceHereWhenCreate = Original;
        PlaceHereWhenCreate.y = Original.y + 1.05f;
    }

    // Update is called once per frame
    void Update()
    {
        if (ScripCreate.IsCreation == false)
        {
            i++;
            if (i <= 500)
            {
                Vector3 velo = Vector3.zero;
                this.transform.position = Vector3.SmoothDamp(this.transform.position, target, ref velo, 0.5f);
            }
            if (i > 500)
            {
                Vector3 velo = Vector3.zero;
                this.transform.position = Vector3.SmoothDamp(this.transform.position, Original, ref velo, 0.5f);
            }
            if (i > 1000 && i < 2000)
            {
                i = 0;
            }
            if (i > 2000)
            {
                Vector3 velo = Vector3.zero;
                this.transform.position = Vector3.SmoothDamp(this.transform.position, Original, ref velo, 0.1f);
            }
            if (i > 2300)
            {
                i = 0;
            }
        }

        if(ScripCreate.IsCreation == true)
        {
            Vector3 velo = Vector3.zero;
            this.transform.position = Vector3.SmoothDamp(this.transform.position, PlaceHereWhenCreate, ref velo, 0.1f);
            GetComponent<Animator>().SetBool("Creating", true);
            i = 2001;
        }


    }

}

