using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeCreate : MonoBehaviour
{
    Slime SLimy;
    public GameObject Slime;
    Vector3 Pos;

    // Start is called before the first frame update
    void Start()
    {
        Pos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CreateSlimeEgg()
    {
        Slime = Instantiate(Slime, transform.position, transform.rotation);
        Slime.GetComponent<Rigidbody2D>().gravityScale = 0;
    }
    
}
