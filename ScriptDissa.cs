using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDissa : MonoBehaviour
{
    public GameObject Dis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("ButtonCancel").GetComponent<SlimeSelection>().SelectedSlime != null && Dis.gameObject.activeSelf == false)
        {
            Dis.gameObject.SetActive(true);
        }
        if (GameObject.Find("ButtonCancel").GetComponent<SlimeSelection>().SelectedSlime == null && Dis.gameObject.activeSelf == true)
        {
            Dis.gameObject.SetActive(false);
        }
    }
    public void ClickDisa()
    {
        if (GameObject.Find("ButtonCancel").GetComponent<SlimeSelection>().SelectedSlime != null)
        {
            GameObject.Find("ButtonCancel").GetComponent<SlimeSelection>().SelectedSlime = null;
        }
        }
}
