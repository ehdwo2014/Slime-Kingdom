using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransFormStage : MonoBehaviour
{
    public GameObject OriginalDummy;
    public GameObject TargetDummy1;
    public GameObject TargetDummy2;
    Vector3 Original = new Vector3();
    Vector3 Target = new Vector3();
    Vector3 Target2 = new Vector3();
    public static bool SwitchStage;

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

        if (SwitchStage == true)
        {
            Vector2 velo = Vector2.zero;
            transform.position = Vector2.SmoothDamp(transform.position, Target, ref velo, 0.05f);
        }


        else if (SwitchStage == false)
        {
            if (Mathf.Abs(Target2.x - this.transform.position.x) < 0.3 && Mathf.Abs(Target2.y - this.transform.position.y) < 0.3)
            {
                this.transform.position = Original;
                this.gameObject.SetActive(false);
            }
            Vector2 velo = Vector2.zero;
            transform.position = Vector2.SmoothDamp(transform.position, Target2, ref velo, 0.05f);
        }

       

    }

    public void SetFalse()
    {
        SwitchStage = false;
    }
    public void ActTheText()
    {
        SwitchStage = true;
        Invoke("SetFalse", 1.5f);
    }
}
