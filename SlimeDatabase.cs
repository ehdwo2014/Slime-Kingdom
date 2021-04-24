using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SlimeDatabase : MonoBehaviour
{

    public List<Slime> SlimeDB = new List<Slime>();

    public static SlimeDatabase instance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        instance = this;
    }
}
