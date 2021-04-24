using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeloChanger : MonoBehaviour
{
    int i=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(-0.5f, 0));
        
            if(this.GetComponent<Rigidbody2D>().velocity.x < -2)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-2,0);
        }
        
    }
}
