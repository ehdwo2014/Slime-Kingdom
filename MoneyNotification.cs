using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyNotification : MonoBehaviour
{
    public GameObject OriginalMoneyParent;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position += new Vector3(0, 0.01f, 0);
        this.GetComponent<Text>().color -= new Color(0, 0, 0, 0.01f);
        Invoke("SetFalseThis", 1);


    }
    void SetFalseThis()
    {
        this.transform.SetParent(OriginalMoneyParent.transform);
        this.GetComponent<Text>().color += new Color(0, 0, 0, 1);
        this.gameObject.SetActive(false);
    }
}
