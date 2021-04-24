using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public GameObject bar;
    Vector3 Original;
    Vector3 RealO;
    RawImage RawIm;
    // Start is called before the first frame update
    void Start()
    {
        RawIm = bar.transform.parent.GetComponent<RawImage>();
        Original = this.transform.position;
        RealO = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Rect uvRect = RawIm.uvRect;
        Original.x = RealO.x + (1f-bar.gameObject.GetComponent<Image>().fillAmount) * 5f;
        Original.y = this.transform.position.y;
        this.transform.position = Original;
        uvRect.x -= 1 * Time.deltaTime;
        bar.transform.parent.GetComponent<RawImage>().uvRect = uvRect;
    }
}
