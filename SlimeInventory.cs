using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlimeInventory : MonoBehaviour
{
    int GroupNumber = 5;
    int SlimeNumber = 5;
    public List<GameObject> SlimeList = new List<GameObject>();
    public Slime TempSlime;



    void FixedUpdate()
    {
        for (int i = 0; i < GroupNumber; i++)
        {
            for (int w = 0; w < SlimeNumber; w++)
            {
                if (SlimeList[i * 5 + w] != null)
                {
                    transform.GetChild(i).GetChild(0).GetChild(0).GetChild(w).GetChild(0).GetComponent<Image>().sprite = SlimeList[i * 5 + w].GetComponent<SlimeState>().slimeState.SlimeSprite;
                    transform.GetChild(i).GetChild(0).GetChild(0).GetChild(w).GetChild(0).GetChild(0).GetComponent<Text>().text = "LV "+ SlimeList[i * 5 + w].GetComponent<SlimeState>().slimeState.Level.ToString();
                }
                else if (SlimeList[i * 5 + w] == null)
                {
                    transform.GetChild(i).GetChild(0).GetChild(0).GetChild(w).GetChild(0).GetComponent<Image>().sprite = null;
                    transform.GetChild(i).GetChild(0).GetChild(0).GetChild(w).GetChild(0).GetChild(0).GetComponent<Text>().text = "";

                }
            }
        }


    }
}



