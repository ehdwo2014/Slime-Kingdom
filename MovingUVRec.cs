using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingUVRec : MonoBehaviour
{
    Rect uvRect;
    // Start is called before the first frame update
    void Start()
    {
        uvRect = this.GetComponent<RawImage>().uvRect;


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        uvRect.x -= 0.1f * Time.deltaTime;
        this.GetComponent<RawImage>().uvRect = uvRect;
    }
}
