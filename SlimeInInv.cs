using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeInInv : MonoBehaviour
{
    int InvIndex;
    int SizeOfGroups;
    int SizeOfSlimes;
    int FromIndex;
    public GameObject SC;
    public GameObject SlimeCas;
    public GameObject SlimeTemp;
    public GameObject SoundDB;
    // Start is called before the first frame update
    void Start()
    {
        SoundDB = GameObject.Find("SoundSources");
        SizeOfGroups = 5;
        SizeOfSlimes = 5;
        InvIndex = this.transform.parent.parent.parent.GetSiblingIndex() * SizeOfGroups + this.transform.GetSiblingIndex();
        SC = GameObject.Find("SC");
        SlimeCas = GameObject.Find("SlimeCascleUI");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickedThisOneSlime()
    {
        if(SC.GetComponent<SlimeSelection>().SelectedSlime != null)
        {
            SoundDB.GetComponent<SoundController>().CallCancelSound();
           if(SC.GetComponent<SlimeSelection>().SelectedSlime.GetComponent<SlimeState>().slimeState.SlimePlaceIndex == -1 && SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex] == null)
            {
                SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex] = SC.GetComponent<SlimeSelection>().SelectedSlime;
                SC.GetComponent<SlimeSelection>().SelectedSlime.GetComponent<SlimeState>().slimeState.SlimePlaceIndex = InvIndex;
            }



           else if (SC.GetComponent<SlimeSelection>().SelectedSlime.GetComponent<SlimeState>().slimeState.SlimePlaceIndex == -1 && SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex] != null)
            {
                SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex].GetComponent<Rigidbody2D>().gravityScale = 1;
                SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex].GetComponent<SpriteRenderer>().flipX = false;
                SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex].transform.localScale = new Vector3(0.5f, 0.5f, 1);
                SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex].transform.position = new Vector3(0,0,10);
                SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex].GetComponent<SpriteRenderer>().sortingOrder = 1;


                SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex].GetComponent<SlimeState>().slimeState.SlimePlaceIndex = -1;
                SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex] = SC.GetComponent<SlimeSelection>().SelectedSlime;
                SC.GetComponent<SlimeSelection>().SelectedSlime.GetComponent<SlimeState>().slimeState.SlimePlaceIndex = InvIndex;
            }
            else if (SC.GetComponent<SlimeSelection>().SelectedSlime.GetComponent<SlimeState>().slimeState.SlimePlaceIndex != -1 && SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex] == null)
            {
                SlimeCas.GetComponent<SlimeInventory>().SlimeList[SC.GetComponent<SlimeSelection>().SelectedSlime.GetComponent<SlimeState>().slimeState.SlimePlaceIndex] = null;
                SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex] = SC.GetComponent<SlimeSelection>().SelectedSlime;
                SC.GetComponent<SlimeSelection>().SelectedSlime.GetComponent<SlimeState>().slimeState.SlimePlaceIndex = InvIndex;
            }

            else if (SC.GetComponent<SlimeSelection>().SelectedSlime.GetComponent<SlimeState>().slimeState.SlimePlaceIndex != -1 && SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex])
            {
                if (SC.GetComponent<SlimeSelection>().SelectedSlime.GetComponent<SlimeState>().slimeState.SlimePlaceIndex == InvIndex)
                {
                    SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex].GetComponent<Rigidbody2D>().gravityScale = 1;
                    SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex].GetComponent<SpriteRenderer>().flipX = false;
                    SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex].transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex].transform.position = new Vector3(0, 0, 10);
                    SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex].GetComponent<SpriteRenderer>().sortingOrder = 1;
                    SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex].GetComponent<SlimeState>().slimeState.SlimePlaceIndex = -1;
                    SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex] = null;
                }
                else
                {
                    SlimeTemp = SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex];
                    SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex].GetComponent<SlimeState>().slimeState.SlimePlaceIndex = SC.GetComponent<SlimeSelection>().SelectedSlime.GetComponent<SlimeState>().slimeState.SlimePlaceIndex;
                    SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex] = SC.GetComponent<SlimeSelection>().SelectedSlime;
                    SlimeCas.GetComponent<SlimeInventory>().SlimeList[SC.GetComponent<SlimeSelection>().SelectedSlime.GetComponent<SlimeState>().slimeState.SlimePlaceIndex] = SlimeTemp;
                    SC.GetComponent<SlimeSelection>().SelectedSlime.GetComponent<SlimeState>().slimeState.SlimePlaceIndex = InvIndex;
                    SlimeTemp = null;
                }
            }



            
        }

        if(SC.GetComponent<SlimeSelection>().SelectedSlime == null)
        {
            if(SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex] != null)
            {
                SoundDB.GetComponent<SoundController>().CallCancelSound();
                SC.GetComponent<SlimeSelection>().SelectedSlime = SlimeCas.GetComponent<SlimeInventory>().SlimeList[InvIndex];
            }

        }




    }


    public void ExchangeSlimePos(int from, int to)
    {
       
    }

}
