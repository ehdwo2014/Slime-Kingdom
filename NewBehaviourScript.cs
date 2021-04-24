using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    Rigidbody2D rigid;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        float h=Input.GetAxisRaw("Horizontal");
	rigid.AddForce(Vector2.right *h*1, ForceMode2D.Impulse);
	
	

    }
}
