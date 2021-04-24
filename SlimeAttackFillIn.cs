using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlimeAttackFillIn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(this.GetComponent<SlimeState>().slimeState.SlimePlaceIndex != -1)
        {
            this.transform.GetChild(5).GetChild(0).gameObject.SetActive(true);
        }
        if (this.GetComponent<SlimeState>().slimeState.SlimePlaceIndex == -1)
        {
            this.transform.GetChild(5).GetChild(0).gameObject.SetActive(false);
        }
        if (StageCurrent.IsItFighting == false)
        {
            GetComponent<SlimeState>().slimeState.AtimeNow = 0;
        }
        if(StageCurrent.IsItFighting == true)
        {
            GetComponent<SlimeState>().slimeState.AtimeNow += Time.deltaTime;
        }


        this.transform.GetChild(5).GetChild(0).GetChild(1).GetComponent<Image>().fillAmount = GetComponent<SlimeState>().slimeState.AtimeNow / GetComponent<SlimeState>().slimeState.AtimeNeed;


        
    }

}
