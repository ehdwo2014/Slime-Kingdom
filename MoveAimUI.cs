using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAimUI : MonoBehaviour
{
    public GameObject OriginalPlaceDummyUI;
    public GameObject DummyUI;
    Vector3 Original;
    Vector3 Target;
    
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        Original = OriginalPlaceDummyUI.transform.position;
        Target = DummyUI.transform.position;

        if (CameraController.CameraPosition == 2)
        {
            Vector2 velo = Vector2.zero;
            transform.position = Vector2.SmoothDamp(transform.position, Target, ref velo, 0.05f);
        }
        else if (CameraController.CameraPosition != 2)
        {
            Vector2 velo = Vector2.zero;
            transform.position = Vector2.SmoothDamp(transform.position, Original, ref velo, 0.05f);
        }

    }
}
