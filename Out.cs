using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Out : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10));
    }

    // Update is called once per frame
    void Update()
    {

    }
   void OnMouseDown()
    {
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(40, 400));

    }
}
