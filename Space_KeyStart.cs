using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Space_KeyStart : MonoBehaviour{

    Text flashingText;

    void Start(){
        flashingText = GetComponent<Text> ();
	StartCoroutine (BlinkText());

         }
public IEnumerator BlinkText(){

	while (true) {
			flashingText.text = "";
			yield return new WaitForSeconds (.5f);
			flashingText.text = "Click to start game";
			yield return new WaitForSeconds (.5f);
			}
	}
}
