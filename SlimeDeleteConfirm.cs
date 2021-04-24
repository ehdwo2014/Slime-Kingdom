using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeDeleteConfirm : MonoBehaviour
{
    public GameObject SS;
    public GameObject SendMSG;
    public GameObject SlimeParen;

    // Update is called once per frame
    public void DeleteTheSlimeConfirm()
    {
        if (SlimeParen.transform.childCount > 2)
        {
            Destroy(SS.GetComponent<SlimeSelection>().SelectedSlime.gameObject);
            SS.GetComponent<SlimeSelection>().SelectedSlime = null;
            SlimeSelection.NowClickable = true;
            this.gameObject.SetActive(false);
        }
        else
        {
            SendMSG.GetComponent<SendingMessage>().ActTheText("The number of slimes cannot be less than 2.");
        }
        
    }

    public void CancelButtonClick()
    {
        this.gameObject.SetActive(false);
    }

    void Update()
    {
        if (SS.GetComponent<SlimeSelection>().SelectedSlime == null)
        {
            this.gameObject.SetActive(false);
        }
    }
}
