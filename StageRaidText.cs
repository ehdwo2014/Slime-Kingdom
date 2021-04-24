using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StageRaidText : MonoBehaviour
{
    public GameObject OriginalDummy;
    public GameObject TargetDummy1;
    public GameObject TargetDummy2;
    Vector3 Original = new Vector3();
    Vector3 Target = new Vector3();
    Vector3 Target2 = new Vector3();
    public static bool SwitStageRaid = true;
    public int Counter = 3;
    public bool After = false;
    public GameObject StageCuUI;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Counter >= 1)
        {
            this.GetComponent<TextMeshProUGUI>().text = Counter.ToString();
        }
        else if(Counter < 1)
        {
            this.GetComponent<TextMeshProUGUI>().text = "Raid Start!";
        }
        Original = OriginalDummy.transform.position;
        Target = TargetDummy1.transform.position;
        Target2 = TargetDummy2.transform.position;

        if (SwitStageRaid == true)
        {
            Vector2 velo = Vector2.zero;
            transform.position = Vector2.SmoothDamp(transform.position, Target, ref velo, 0.05f);

            if(After == false)
            {
                SetFalseLater();
                After = true;
            }

        }


        else if (SwitStageRaid == false)
        {
            if (Mathf.Abs(Target2.x - this.transform.position.x) < 0.3 && Mathf.Abs(Target2.y - this.transform.position.y) < 0.3)
            {
                if (Counter > 0)
                {
                    this.transform.position = Original;
                    SwitStageRaid = true;
                    After = false;
                    Counter--;
                }
                else if(Counter <= 0)
                {
                    RaidStart();
                    this.transform.position = Original;
                    Counter = 3;
                    SwitStageRaid = true;
                    After = false;
                    this.gameObject.SetActive(false);
                }

            }
            Vector2 velo = Vector2.zero;
            transform.position = Vector2.SmoothDamp(transform.position, Target2, ref velo, 0.05f);
        }



    }

    public void SetFalse()
    {
        SwitStageRaid = false;
    }
    public void ActTheText()
    {
        SwitStageRaid = true;
        Invoke("SetFalse", 1.0f);
    }

    public void SetFalseLater()
    {
        Invoke("SetFalse", 1.0f);
    }

    public void RaidStart()
    {
        StageCuUI.GetComponent<StageCurrent>().IsItBossRaid = true;
        StageCurrent.IsItFighting = true;


    }

}

