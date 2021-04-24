using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MoneyNotification2 : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position += new Vector3(0, 0.01f, 0);
        this.GetComponent<Text>().color -= new Color(0, 0, 0, 0.01f);
        Invoke("DestroyThis", 1);
        
    }
    void DestroyThis()
    {
        Destroy(this.gameObject);
    }

}
