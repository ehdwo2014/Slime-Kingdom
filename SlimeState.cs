using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlimeState : MonoBehaviour
{
    public Slime slimeState;
    public int AuraIndex;
    float DamageAlpha;
    float MaxMoveSpeed;
    float LevelStateAlpha;
    float MovementSpeedAlpha;
    float MiningAbAlpha;
    float AlphaForMM;
    float LevelPriceAlpha;
    float LevelPricePowIndex;
    public GameObject SkillDBS;
    float AttackTimeMax;

    float WorkTimeMax;

    public float[] Elements = new float[3];
    public int TypeOfElement;
    public bool AuraEquipped;
    public GameObject AuraDBOB;

    // Start is called before the first frame update
    void Start()
    {
        WorkTimeMax = 10;

       


        AttackTimeMax = 6;
        slimeState.MovementSpeed = 1;
        DamageAlpha = 0.05f;
        LevelStateAlpha = 0.2f;
        MovementSpeedAlpha = 20;
        MiningAbAlpha = 100;

        AlphaForMM = 500;
        LevelPriceAlpha = 3480;
        LevelPricePowIndex = 1.1f;


        slimeState.WorkTimeNeed = WorkTimeMax;
        SkillDBS = GameObject.Find("SelectedSkill");
        AuraDBOB = GameObject.Find("AuraGBHolder");
    }

    // Update is called once per frame
    void Update()
    {
     
        if(slimeState.Weapon.typeOfAttack.Equals("Magical"))
        {
            slimeState.AttackPoint = slimeState.MagicalATK;
        }
        else 
        {
            slimeState.AttackPoint = slimeState.PhysicalATK;
        }
        slimeState.Weapon.IsThisDesc = false;
        slimeState.Accessory.IsThisDesc = false;
        slimeState.Aura.IsThisDesc = false;
        slimeState.UsedCore.IsThisDesc = true;


        if (slimeState != null)
        {
            AuraIndex = slimeState.Aura.EquipmentID;
        }
        if (AuraIndex == 0)
        {
            AuraEquipped = false;
        }
        if (AuraIndex != 0)
        {
            AuraEquipped = true;
        }

        if (AuraEquipped == true)
        {
            if (this.transform.GetChild(3).childCount == 0)
            {
                if (slimeState.Aura.EquipmentID == 109 || slimeState.Aura.EquipmentID == 110 || slimeState.Aura.EquipmentID == 111 || slimeState.Aura.EquipmentID == 113)
                {
                    Instantiate(AuraDBOB.GetComponent<AuraHoldGameOB>().Auras[AuraIndex - 100], this.transform.position + new Vector3(0, 0, 0), new Quaternion(), this.transform.GetChild(3)).transform.localPosition = new Vector3(0,2,0);

                }
                else
                {
                   Instantiate(AuraDBOB.GetComponent<AuraHoldGameOB>().Auras[AuraIndex - 100], this.transform.position, new Quaternion(), this.transform.GetChild(3)).transform.localPosition = new Vector3(0, 0, 0);

                }
            }
            if (this.transform.GetChild(3).childCount != 0 && this.transform.GetChild(3).GetChild(0).GetComponent<GetIDAura>().ID != AuraIndex - 100)
            {
                if ((slimeState.Aura.EquipmentID == 109 || slimeState.Aura.EquipmentID == 110 || slimeState.Aura.EquipmentID == 111 || slimeState.Aura.EquipmentID == 113))
                {
                    Destroy(this.transform.GetChild(3).GetChild(0).gameObject);
                    Instantiate(AuraDBOB.GetComponent<AuraHoldGameOB>().Auras[AuraIndex - 100], this.transform.position + new Vector3(0,0,0), new Quaternion(), this.transform.GetChild(3)).transform.localPosition = new Vector3(0, 2, 0);
                }

                else
                {
                    Destroy(this.transform.GetChild(3).GetChild(0).gameObject);
                    Instantiate(AuraDBOB.GetComponent<AuraHoldGameOB>().Auras[AuraIndex - 100], this.transform.position, new Quaternion(), this.transform.GetChild(3)).transform.localPosition = new Vector3(0, 0, 0);
                }
            }

           


        }
        if( AuraEquipped == false)
        {
            if(this.transform.GetChild(3).childCount != 0)
            {
                Destroy(this.transform.GetChild(3).GetChild(0).gameObject);
            }

        }




        if (slimeState.AttackType.Equals("Physical"))
        {
            slimeState.AtimeNeed = ((2 + slimeState.MovementSpeed) / slimeState.MovementSpeed) * 0.5f ;
        }
        else if(slimeState.AttackType.Equals("Magical"))
        {
            slimeState.AtimeNeed = (2 + slimeState.MovementSpeed) / slimeState.MovementSpeed;
        }
        else
        {
            slimeState.AtimeNeed = ((2 + slimeState.MovementSpeed) / slimeState.MovementSpeed) * 0.5f;
        }


        if(slimeState.AtimeNow >= slimeState.AtimeNeed)
        {
            slimeState.AttackReady = true;
        }
        else if(slimeState.AtimeNow < slimeState.AtimeNeed)
            {
                slimeState.AttackReady = false;
            }

        



        if (slimeState.WorkTimeNow >= slimeState.WorkTimeNeed)
        {
            slimeState.WorkDone = true;
        }

        else if(slimeState.WorkTimeNow < slimeState.AtimeNeed)
        {
            slimeState.WorkDone = false;
        }





        slimeState.STR = Mathf.Round(1+slimeState.UsedCore.STR * slimeState.Level * LevelStateAlpha);
        slimeState.INT = Mathf.Round(1+slimeState.UsedCore.INT * slimeState.Level * LevelStateAlpha);
        slimeState.DEX = Mathf.Round(1+slimeState.UsedCore.DEX * slimeState.Level * LevelStateAlpha);
        slimeState.LUK = Mathf.Round(1+slimeState.UsedCore.LUK * slimeState.Level * LevelStateAlpha);


        if(SkillDatabase.INTBuffer == true)
        {
            slimeState.INT = Mathf.Round(1+slimeState.UsedCore.INT * slimeState.Level * LevelStateAlpha* SkillDBS.GetComponent<SkillDatabase>().ManaAmplS.IntIncrease);

        }

        if (SkillDatabase.STRBuffer == true)
        {
            slimeState.STR = Mathf.Round(1+slimeState.UsedCore.STR * slimeState.Level * LevelStateAlpha * SkillDBS.GetComponent<SkillDatabase>().StrengthenS.STRIncrease);

        }



        slimeState.MovementSpeed = Mathf.Round(((slimeState.DEX / (slimeState.DEX + AlphaForMM)) * MovementSpeedAlpha) + 1f + slimeState.Accessory.MovementSpeed);
        slimeState.MiningAbility = Mathf.Round(((slimeState.LUK / (slimeState.LUK + AlphaForMM)) * MiningAbAlpha) +1f + slimeState.Accessory.WorkingPoint + slimeState.Weapon.WorkingPoint);
        slimeState.CriticalPoint = (slimeState.LUK / (slimeState.LUK + AlphaForMM) + slimeState.Weapon.CriticalPoint + slimeState.Accessory.CriticalPoint + slimeState.Aura.CriticalPoint);

        if(slimeState.CriticalPoint > 1)
        {
            slimeState.CriticalPoint = 1;
        }

        slimeState.Fire = slimeState.UsedCore.fire + slimeState.Weapon.fire + slimeState.Accessory.fire + slimeState.Aura.fire;
        slimeState.Ice = slimeState.UsedCore.ice + slimeState.Weapon.ice + slimeState.Accessory.ice + slimeState.Aura.ice;
        slimeState.Light = slimeState.UsedCore.light + slimeState.Weapon.light + slimeState.Accessory.light + slimeState.Aura.light;
        slimeState.Dark = slimeState.UsedCore.dark + slimeState.Weapon.dark + slimeState.Accessory.dark + slimeState.Aura.dark;
        

        if(slimeState.Weapon.typeOfAttack.Equals("Magical"))
        {
            slimeState.AttackType = slimeState.Weapon.typeOfAttack;
        }
        else
        {
            slimeState.AttackType = "Physical";
        }

        slimeState.PhysicalATK = 5 + slimeState.Weapon.PhysicalAttack + slimeState.STR + (slimeState.STR * DamageAlpha) * (slimeState.Accessory.PhysicalAttack + slimeState.Weapon.PhysicalAttack + slimeState.Aura.PhysicalAttack);
        slimeState.MagicalATK = 5 + slimeState.Weapon.MagicalAttack + slimeState.INT + (slimeState.INT * DamageAlpha) * (slimeState.Accessory.MagicalAttack + slimeState.Weapon.MagicalAttack + slimeState.Aura.MagicalAttack);
        slimeState.PriceToLevelUP = System.Convert.ToInt64(ItemRefactorizing.RankToNumber(slimeState.SlimeRank) * System.Math.Pow(LevelPricePowIndex, slimeState.Level) * LevelPriceAlpha);





        if (slimeState.Weapon.IsItEquipped == false)
        {
            slimeState.Weapon.IsItEquipped = true;
        }
        if (slimeState.Accessory.IsItEquipped == false)
        {
            slimeState.Accessory.IsItEquipped = true;
        }
        if (slimeState.Aura.IsItEquipped == false)
        {
            slimeState.Aura.IsItEquipped = true;
        }
        if (slimeState.UsedCore.IsItEquipped == true)
        {
            slimeState.UsedCore.IsItEquipped = true;
        }

        if(SkillDatabase.INTBuffer == true && SkillDatabase.STRBuffer == true)
        {
            this.transform.GetChild(4).GetChild(2).gameObject.SetActive(true);
            this.transform.GetChild(4).GetChild(1).gameObject.SetActive(false);
            this.transform.GetChild(4).GetChild(0).gameObject.SetActive(false);

        }
        if (SkillDatabase.INTBuffer == true && SkillDatabase.STRBuffer == false)
        {
            this.transform.GetChild(4).GetChild(2).gameObject.SetActive(false);
            this.transform.GetChild(4).GetChild(1).gameObject.SetActive(true);
            this.transform.GetChild(4).GetChild(0).gameObject.SetActive(false);
        }
        if (SkillDatabase.STRBuffer == true && SkillDatabase.INTBuffer == false)
        {
            this.transform.GetChild(4).GetChild(2).gameObject.SetActive(false);
            this.transform.GetChild(4).GetChild(1).gameObject.SetActive(false);
            this.transform.GetChild(4).GetChild(0).gameObject.SetActive(true);
        }
        if (SkillDatabase.INTBuffer == false && SkillDatabase.STRBuffer == false)
        {

            this.transform.GetChild(4).GetChild(2).gameObject.SetActive(false);
            this.transform.GetChild(4).GetChild(1).gameObject.SetActive(false);
            this.transform.GetChild(4).GetChild(0).gameObject.SetActive(false);

        }

        SetTypeOfElement();

    }

    public void SetTypeOfElement()
    {
        if(slimeState.Fire > slimeState.Ice && slimeState.Fire > slimeState.Light && slimeState.Fire > slimeState.Dark)
        {
            TypeOfElement = 1;
        }
        else if (slimeState.Ice > slimeState.Fire && slimeState.Ice > slimeState.Light && slimeState.Ice > slimeState.Dark)
        {
            TypeOfElement = 2;
        }
        else if (slimeState.Light > slimeState.Fire && slimeState.Light > slimeState.Ice && slimeState.Light > slimeState.Dark)
        {
            TypeOfElement = 3;
        }
        else if (slimeState.Dark > slimeState.Ice && slimeState.Dark > slimeState.Light && slimeState.Dark > slimeState.Fire)
        {
            TypeOfElement = 4;
        }
        else
        {
            TypeOfElement = 0;
        }
    }
}
