using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingShot : MonoBehaviour
{
    Vector2 v = new Vector2();
    float angle;
    public GameObject ShotOrigin;
    public GameObject ShotOriginalDB;
    // Start is called before the first frame update
    void OnEnable()
    {
        Invoke("SetFalseThis", 3);

    }

   public void SetFalseThis()
    {
        this.transform.SetParent(ShotOriginalDB.transform);
        this.gameObject.SetActive(false);
    }

    void DestroyThis()
    {
        Destroy(this.gameObject);
    }

}
