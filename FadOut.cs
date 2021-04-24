using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadOut : MonoBehaviour
{
    public Image Panel;
    float time =0f;
	float F_time = 1f;
	public void Fade()
{
StartCoroutine(FadeFlow());
}



// Start is called before the first frame update
    void Start()
    {
       Fade();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
IEnumerator FadeFlow()
{
Panel.gameObject.SetActive(true);
Color alpha = Panel.color;
while (alpha.a >0f)
{
time += Time.deltaTime /F_time;
alpha.a = Mathf.Lerp(1,0,time);
Panel.color = alpha;
yield return null;
}
yield return null;
}
}


