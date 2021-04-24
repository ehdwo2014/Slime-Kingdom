using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StageLevel : MonoBehaviour
{
    int SLevel;


    // Update is called once per frame
    void Update()
    {
        SLevel = PlayerInfor.Stage;
        this.GetComponent<TextMeshProUGUI>().text = SLevel.ToString();
    }
}
