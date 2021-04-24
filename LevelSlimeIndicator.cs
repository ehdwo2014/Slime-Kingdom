using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class LevelSlimeIndicator : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        this.GetComponent<TextMeshProUGUI>().text = "LV "+ this.transform.parent.parent.GetComponent<SlimeState>().slimeState.Level.ToString();
    }

}
