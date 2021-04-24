using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class InstantDamage : MonoBehaviour
{
    GameObject Instant;
    GameObject Instant2;
    GameObject CreatedInstant;
    System.Random r = new System.Random();
    Slime OriS;
    Enemy OriE;
    public bool Switch = false;
    float DamagePoint;
    float ElementalPoint;
    public GameObject DamStoreInstParents;
    public GameObject DamStoreInstUsedParents;
    bool CriticalHit;


    Vector3 RanVec;
    // Start is called before the first frame update
    void Start()
    {
        DamStoreInstUsedParents = this.transform.parent.parent.parent.parent.GetChild(5).GetChild(6).gameObject;
        DamStoreInstParents = this.transform.parent.parent.parent.parent.GetChild(5).gameObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Switch==true)
            {
            Damaged(null);
            Switch = false;
         }

    }

    public void Damaged(GameObject Origin)
    {

        if (Origin.GetComponent<SlimeState>().slimeState.CriticalPoint > r.Next(0,100) * 0.01)
        {
            CriticalHit = true;
        }


        if (Origin != null)
        {
            OriS = Origin.GetComponent<SlimeState>().slimeState;
            OriE = transform.parent.parent.GetComponent<EnemyState>().enemystate;
            DamagePoint = DamageCalculation(OriS, OriE);
            if(CriticalHit == true)
            {
                DamagePoint = DamagePoint + DamagePoint;
                CriticalHit = false;
            }
            

            if (OriE.EnemyNowHP - DamagePoint < 0)
            {
                OriE.EnemyNowHP = 0;
            }
            else
            {
                OriE.EnemyNowHP -= DamagePoint;
            }
        


            RanVec = new Vector3 ( Convert.ToSingle(r.Next(0,15)) * 0.1f, Convert.ToSingle(r.Next(0,15)) * 0.1f , 0);


            if (DamStoreInstParents.transform.GetChild(0).childCount != 0)
            {
                Instant = DamStoreInstParents.transform.GetChild(0).GetChild(0).gameObject;
                Instant.SetActive(true);
                Instant.transform.SetParent(DamStoreInstUsedParents.transform);
                Instant.transform.position = this.transform.parent.position + RanVec;
                Instant.GetComponent<TextMeshProUGUI>().text = Mathf.RoundToInt(DamagePoint).ToString();
            }

            if (Origin.GetComponent<SlimeState>().TypeOfElement != 0)
            {
                ElementalPoint = DamageCalculationElement(OriS, Origin.GetComponent<SlimeState>().TypeOfElement, OriE);

                if (ElementalPoint < 1)
                {
                    ElementalPoint = 0;
                }



                if (OriE.EnemyHP - ElementalPoint < 0)
                {
                    OriE.EnemyHP = 0;
                }
                else
                {
                    OriE.EnemyHP -= ElementalPoint;
                }
                if (DamStoreInstParents.transform.GetChild(Origin.GetComponent<SlimeState>().TypeOfElement).childCount != 0)
                {
                    Instant2 = DamStoreInstParents.transform.GetChild(Origin.GetComponent<SlimeState>().TypeOfElement).GetChild(0).gameObject;
                    Instant2.SetActive(true);
                    Instant2.transform.SetParent(DamStoreInstUsedParents.transform);
                    Instant2.transform.position = Instant.transform.position + new Vector3(0, 0.5f, 0);
                    if (ElementalPoint > 1)
                    {
                        Instant2.GetComponent<TextMeshProUGUI>().text = Mathf.RoundToInt(ElementalPoint).ToString();
                    }
                    else
                    {
                        Instant2.GetComponent<TextMeshProUGUI>().text = "Resisted";
                    }

                }
            }


        }
        

    }


    public float DamageCalculation(Slime S, Enemy E)
    {
        if((S.AttackPoint - E.EnemyArmor) < 1)
        {
            return 1;
        }
       else
        {
            return S.AttackPoint - E.EnemyArmor;
        }


    }

    public float DamageCalculationElement(Slime S, int Type, Enemy E)
    {
        if(Type == 1)
        {
           return S.AttackPoint * 0.01f * (S.Fire - E.EnemyFire);
        }

        if (Type == 2)
        {
            return S.AttackPoint * 0.01f * (S.Ice - E.EnemyIce);
        }

        if (Type == 3)
        {
            return S.AttackPoint * 0.01f * (S.Light - E.EnemyLight);
        }
        if (Type == 4)
        {
            return S.AttackPoint * 0.01f * (S.Dark - E.EnemyDark);
        }
        else
        {
            return 0;
        }
        }



}
