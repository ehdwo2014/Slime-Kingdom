using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartGameBip : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BlinkText());

    }

    // Update is called once per frame
    void Update()
    {
    }

    public IEnumerator BlinkText()
    {

        while (true)
        {
            this.GetComponent<TextMeshProUGUI>().text = "";
            yield return new WaitForSeconds(.75f);
            this.GetComponent<TextMeshProUGUI>().text = "Click To Start Game";
            yield return new WaitForSeconds(.75f);
        }
    }
}

