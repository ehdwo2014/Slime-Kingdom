using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextCastleStateChanger : MonoBehaviour
{
    public GameObject GateWayOB;   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.GetSiblingIndex()==0)
        {
            this.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = GateWayOB.GetComponent<GateWayHP>().GateWayHpMax.ToString();
        }
        if (this.transform.GetSiblingIndex() == 1)
        {
            this.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = GateWayOB.GetComponent<GateWayHP>().GateWayMPMax.ToString();
        }
        if (this.transform.GetSiblingIndex() == 2)
        {
            this.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = GateWayOB.GetComponent<GateWayHP>().GateWayDEF.ToString();
        }
        if (this.transform.GetSiblingIndex() == 3)
        {
            this.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = GateWayOB.GetComponent<GateWayHP>().GateWayRIS.ToString();

        }
        if (this.transform.GetSiblingIndex() == 4)
        {
            this.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = GateWayOB.GetComponent<GateWayHP>().GateWayRege.ToString();
        }
        if (this.transform.GetSiblingIndex() == 5)
        {
            this.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = GateWayOB.GetComponent<GateWayHP>().GateWayRegenMana.ToString();
        }
    }
}
