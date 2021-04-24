using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeSelection : MonoBehaviour
{
    public GameObject SelectedSlime;
    public GameObject Cam;
    public GameObject CancelButton;
    public Vector3 OriginalPlace = new Vector3();
    public static bool NowClickable;
    public static int CameraPosition;
    Vector3 target = new Vector3();
    public GameObject Left1Place;
    // Start is called before the first frame update
    void Start()
    {
        NowClickable = true;
        CameraPosition = 0;
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
