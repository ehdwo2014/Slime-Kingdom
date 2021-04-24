using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScripCreate : MonoBehaviour
{
    public GameObject SC1;
    public GameObject SC2;
    public static bool IsCreation;
    public GameObject bar;
    public GameObject Slime;
    GameObject instant;
    public GameObject ObjectPlace;
    public GameObject SlimeParen;


    // Start is called before the first frame update
    void Start()
    {

           
        
    }
    // Update is called once per frame
    void Update()
    {
        
        if (IsCreation == true)
        {
            TransFormUISC.clickable = false;
            ButtonSwitSC.SwitSC = false;


            if (bar.GetComponent<Image>().fillAmount < 0.01f)
            {
                IsCreation = false;
                bar.GetComponent<Image>().fillAmount = 1;
                if (SlimeNumberCounter.IsMaximumSlimeNow == false)
                {
                    CreateTheSlime();
                }
            }
        }

        if(IsCreation == false)
        {
            TransFormUISC.clickable = true;
        }



    }
    public void CreateTheSlime()
    {
        MaterialUI.SwitchMaterialUI = false;
        CoreUI.SwitchCoreUI = false;

        CoreValueAdded();
        instant = Instantiate(Slime, ObjectPlace.transform.position, new Quaternion());
        instant.gameObject.GetComponent<SlimeState>().slimeState.UsedCore = SC1.GetComponent<CoreInventory>().cores[0];
        instant.gameObject.GetComponent<SlimeState>().slimeState.Level = 1;
        SC1.GetComponent<CoreInventory>().cores[0] = new Core();
        SC2.GetComponent<MaterialInventory>().materials[0] = new Material();
        instant.GetComponent<Rigidbody2D>().velocity = new Vector2(8,0);
        instant.GetComponent<Rigidbody2D>().gravityScale = 1;
        instant.transform.SetParent(SlimeParen.transform);
    }


    public void CoreValueAdded()
    {
        Material MT = SC2.GetComponent<MaterialInventory>().materials[0];

        if(MT.materialID == 32)
        {
            SC1.GetComponent<CoreInventory>().cores[0].Originalfire += 2;
        }
        if (MT.materialID == 33)
        {
            SC1.GetComponent<CoreInventory>().cores[0].Originalice += 2;
        }
        if (MT.materialID == 34)
        {
            SC1.GetComponent<CoreInventory>().cores[0].Originallight += 2;
        }
        if (MT.materialID == 35)
        {
            SC1.GetComponent<CoreInventory>().cores[0].Originaldark += 2;
        }
        if (MT.materialID == 31)
        {
            SC1.GetComponent<CoreInventory>().cores[0].INTOri += 2;
            SC1.GetComponent<CoreInventory>().cores[0].STROri += 2;
        }

        if (MT.materialID == 29)
        {
            SC1.GetComponent<CoreInventory>().cores[0].INTOri += 2;
        }


        if (MT.materialID == 27)
        {
            SC1.GetComponent<CoreInventory>().cores[0].STROri += 2;


        }



        if (MT.materialID == 23)
        {
            SC1.GetComponent<CoreInventory>().cores[0].INTOri += 1;
            SC1.GetComponent<CoreInventory>().cores[0].STROri += 1;
        }

        if (MT.materialID == 38)
        {
            SC1.GetComponent<CoreInventory>().cores[0].LUKOri += 1;
            SC1.GetComponent<CoreInventory>().cores[0].DEXOri += 1;

        }
        if (MT.materialID == 39)
        {
            SC1.GetComponent<CoreInventory>().cores[0].LUKOri += 3;
            SC1.GetComponent<CoreInventory>().cores[0].DEXOri += 3;

        }





        if (MT.materialID == 24)
        {
            SC1.GetComponent<CoreInventory>().cores[0].STROri += 1;
        }

        if (MT.materialID == 25)
        {
            SC1.GetComponent<CoreInventory>().cores[0].INTOri += 1;
        }


        if (MT.materialID == 11)
        {
            SC1.GetComponent<CoreInventory>().cores[0].LUKOri += 1;
        }

        if (MT.materialID == 36)
        {
            SC1.GetComponent<CoreInventory>().cores[0].coreLevel += 1;
        }

        ItemRefactorizing.ChangingCore(SC1.GetComponent<CoreInventory>().cores[0]);




    }




}
