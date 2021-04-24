using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeScript : MonoBehaviour
{
    public Image Panel;
    float time =0f;
	float F_time = 1f;
	public GameObject textBlink;
	public void Fade()
{
textBlink = GameObject.Find("TextBlink");
Destroy(textBlink);
StartCoroutine(FadeFlow());
Invoke("test",3f);
}

public void test()
{
SceneManager.LoadScene(1);
}

// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
IEnumerator FadeFlow()
{
Panel.gameObject.SetActive(true);
Color alpha = Panel.color;
while (alpha.a <1f)
{
time += Time.deltaTime /F_time;
alpha.a = Mathf.Lerp(0,1,time);
            this.GetComponent<AudioSource>().volume -= 0.05f;
Panel.color = alpha;
    yield return null;
    }
    yield return null;
    }
    }

