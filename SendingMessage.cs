using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class SendingMessage : MonoBehaviour
{
    public GameObject OriginalDummy;
    public GameObject TargetDummy1;
    public GameObject TargetDummy2;
    Vector3 Original = new Vector3();
    Vector3 Target = new Vector3();
    Vector3 Target2 = new Vector3();
    public bool SwitchMessage;
    public GameObject Instant;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Original = OriginalDummy.transform.position;
        Target = TargetDummy1.transform.position;
        Target2 = TargetDummy2.transform.position;

        if (SwitchMessage == true)
        {
            Vector2 velo = Vector2.zero;
            transform.position = Vector2.SmoothDamp(transform.position, Target, ref velo, 0.05f);
        }

        else if (SwitchMessage == false)
        {
            if (Mathf.Abs(Target2.x - this.transform.position.x) < 0.3 && Mathf.Abs(Target2.y - this.transform.position.y) < 0.3)
            {
                this.transform.position = Original;
                Destroy(this.gameObject);
              
            }
            Vector2 velo = Vector2.zero;
            transform.position = Vector2.SmoothDamp(transform.position, Target2, ref velo, 0.05f);
        }



    }

    public void SetFalseDF()
    {
        SwitchMessage = false;
    }
    public void ActTheText(string text)
    {
        Instant = Instantiate(this.gameObject, this.transform.position, new Quaternion(), this.transform.parent);
        Instant.SetActive(true);
        Instant.GetComponent<TextMeshProUGUI>().text = text;
        Instant.GetComponent<SendingMessage>().SwitchMessage = true;
        Instant.GetComponent<SendingMessage>().Invoke("SetFalseDF", 1.5f);
    }
}