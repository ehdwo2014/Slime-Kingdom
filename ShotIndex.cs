using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotIndex : MonoBehaviour
{
    public int IndexOfShot;
    public GameObject ShotEne;
    public float Velo;
    public GameObject Instant;

    void Start()
    {
        ShotEne = GameObject.Find("EnemyShotHolder").GetComponent<EnemyShotHoldingSC>().Shots[IndexOfShot];

    }

    public void CreateShot()
    {
        Instant = Instantiate(ShotEne, this.transform.position, new Quaternion(), null);
        Instant.GetComponent<Rigidbody2D>().velocity = new Vector2(Velo, 0);
        Instant.GetComponent<EnemyShotGB>().ATKP = this.GetComponent<EnemyState>().enemystate.EnemyAttackPoint;

    }
    
}
