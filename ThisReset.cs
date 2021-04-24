using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisReset : MonoBehaviour
{
    public Vector3 Original;
    // Start is called before the first frame update
    void Start()
    {
        Original = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if(this.transform.position.y < -30)
        {
            this.transform.position = Original;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        }
        
    }
}
