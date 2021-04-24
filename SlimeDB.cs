using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeDB : MonoBehaviour
{
    public static int AmountOfSlime;
    public GameObject InstantSlime;
    public List<Slime> Slimes;
    public List<GameObject> SlimeOB;
    
    
    void Update()
    {
        AmountOfSlime = this.transform.childCount;
    }

}
