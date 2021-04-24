using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SkillDatabase : MonoBehaviour
{
    public int Gate;
    public GameObject TT;
    public MagicS MagicShildS = new MagicS();
    public MultiShot MultiShotS = new MultiShot();
    public Repairing RepairS = new Repairing();
    public Haist HaistS = new Haist();
    public ManaAmpl ManaAmplS = new ManaAmpl();
    public Strengthen StrengthenS = new Strengthen();
    public Focus FocusS = new Focus();

    public static List<float> TimeForSKillNow; 


    public List<Skill> SkillDB;

    public static bool STRBuffer;
    public static bool INTBuffer;
    public static bool ShieldBuffer;
    public GameObject GateWayOB;



    // Start is called before the first frame update
    void Start()
    {
        SkillDB.Add(MultiShotS);
        SkillDB.Add(RepairS);
        SkillDB.Add(ManaAmplS);
        SkillDB.Add(StrengthenS);
        SkillDB.Add(MagicShildS);
        SkillDB.Add(FocusS);
        SkillDB.Add(HaistS);
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < SkillDB.Count; i++)
        {
            SkillDB[i].Price = SkillDB[i].OriginalPrice + SkillDB[i].OriginalPrice * Convert.ToInt64(System.Math.Pow(1.3, SkillDB[i].SkillLevel));
            SkillDB[i].ManaConsumption = SkillDB[i].ManaConOriginal + (SkillDB[i].ManaConOriginal * (SkillDB[i].SkillLevel - 1))/5;
            SkillDB[i].CoolDown = SkillDB[i].CoolDownOriginal * (50 / 50);
        }
        MultiShotS.NumberOfShot = 1 + Mathf.RoundToInt((MultiShotS.SkillLevel + 1) / 2);
        MultiShotS.Description = MultiShotS.NumberOfShot.ToString() + " Shots fired sequentially" + "\n"
            + "Cool Down:  " + MultiShotS.CoolDown + "s" + "\n"
            + "MP:  " + MultiShotS.ManaConsumption.ToString();

        RepairS.Percentage = RepairS.OriginalPercentage + 0.01f * RepairS.SkillLevel;

        RepairS.Description = "Restoring " + (RepairS.Percentage * 100).ToString() + "% of HP" + "\n"
            + "Cool Down:  " + RepairS.CoolDown.ToString() + "s" + "\n"
            + "MP:  " + RepairS.ManaConsumption.ToString();

        ManaAmplS.IntIncrease = ManaAmplS.OriginalIntIncrease + ManaAmplS.SkillLevel * 0.1f;

        ManaAmplS.Description = "INT + " + ((ManaAmplS.IntIncrease - 1) * 100).ToString() + " %" + "\n"
            + "Duration:  " + ManaAmplS.Duration.ToString() + "s" + "\n"
            + "Cool Down:  " + ManaAmplS.CoolDown.ToString() + "s" + "\n"
            + "MP:  " + ManaAmplS.ManaConsumption.ToString();

        StrengthenS.STRIncrease = StrengthenS.OriginalSTR + StrengthenS.SkillLevel * 0.1f;

        StrengthenS.Description = "STR + " + ((StrengthenS.STRIncrease - 1) * 100).ToString() + " %" + "\n"
            + "Duration:  " + StrengthenS.Duration.ToString() + "s" + "\n"
            + "Cool Down:  " + StrengthenS.CoolDown.ToString() + "s" + "\n"
            + "MP:  " + StrengthenS.ManaConsumption.ToString();

        MagicShildS.ArmRe = MagicShildS.ArmReOri + 0.2f * MagicShildS.SkillLevel;
        MagicShildS.Description = "Physical DEF + " + Mathf.RoundToInt((MagicShildS.ArmRe - 1) * 100).ToString() + " %" + "\n"
            + "Resistance + " + Mathf.RoundToInt((MagicShildS.ArmRe - 1) * 100).ToString() + " %" + "\n"
           + "Duration:  " + Mathf.RoundToInt(MagicShildS.Duration).ToString() + "s" + "\n"
            + "Cool Down:  " + Mathf.RoundToInt(MagicShildS.CoolDown).ToString() + "s" + "\n"
            + "MP:  " + MagicShildS.ManaConsumption.ToString();

        FocusS.CriticalChance =  FocusS.CriticalChanceOri + 0.01f * FocusS.SkillLevel;

        FocusS.Description = 
        "Crit Rate + " + ((FocusS.CriticalChance) * 100).ToString() + " %" + "\n";

        HaistS.AttackSpeed = HaistS.AttackSpeedOri + 0.02f * HaistS.SkillLevel;

        HaistS.Description =
        "Attack Speed + " + ((HaistS.AttackSpeed) * 100).ToString() + " %" + "\n"
        + "Movement Speed + " + ((HaistS.AttackSpeed) * 100).ToString() + " %" + "\n";

        
    }

    public void SetFalseINT()
    {
        SkillDatabase.INTBuffer = false;
    }
    public void SetFalseSTR()
    {
        SkillDatabase.STRBuffer = false;
    }
    public void SetFalseShield()
    {
        SkillDatabase.ShieldBuffer = false;
    }
    
   

    

}

[System.Serializable]
public class MagicS : Skill
{
    public GameObject GateWayOB;
    public GameObject SkillDBS;
    public GameObject Effect;
    public float ArmReOri;
    public float ArmRe;

    public override void UseSkill()
    {
        
        SkillDatabase.ShieldBuffer = true;
        Effect.gameObject.SetActive(true);
        SkillDBS.GetComponent<SkillDatabase>().Invoke("SetFalseShield", SkillDBS.GetComponent<SkillDatabase>().MagicShildS.Duration);


    }

}

[System.Serializable]
public class MultiShot : Skill
{
    public int NumberOfShot;
    public GameObject SlimeDB;
    public override void UseSkill()
    {
        
            for (int i = 0; i < 25; i++)
            {
                if (SlimeDB.GetComponent<SlimeInventoryCopy>().SlimeList1[i] != null)
                {
                    SlimeDB.GetComponent<SlimeInventoryCopy>().SlimeList1[i].GetComponent<SlimeState>().slimeState.Sprafe = true;
                }
            }
        
        base.UseSkill();
        Debug.Log("2");

    }

}

[System.Serializable]
public class Repairing: Skill
{
    public GameObject GateWayS;
    public float OriginalPercentage;
    public float Percentage;

    public override void UseSkill()
    {
      
            
            GateWayS.GetComponent<GateWayHP>().GateWayHPNow += GateWayS.GetComponent<GateWayHP>().GateWayHpMax * this.Percentage;

            if (GateWayS.GetComponent<GateWayHP>().GateWayHpMax < GateWayS.GetComponent<GateWayHP>().GateWayHPNow)
            {
                GateWayS.GetComponent<GateWayHP>().GateWayHPNow = GateWayS.GetComponent<GateWayHP>().GateWayHpMax;
            }
        
        
    }

}

[System.Serializable]
public class ManaAmpl: Skill
{
    public GameObject GateWayOB;
    public GameObject SKillDB;
    public float OriginalIntIncrease;
    public float IntIncrease;
    public override void UseSkill()
    {


            SkillDatabase.INTBuffer = true;
            SKillDB.GetComponent<SkillDatabase>().Invoke("SetFalseINT", SKillDB.GetComponent<SkillDatabase>().ManaAmplS.Duration);
        
    }

}

[System.Serializable]
public class Strengthen: Skill
{
    public GameObject GateWayOB;
    public GameObject SKillDB;
    public float OriginalSTR;
    public float STRIncrease;
    public override void UseSkill()
    {
      
            SkillDatabase.STRBuffer = true;
            SKillDB.GetComponent<SkillDatabase>().Invoke("SetFalseSTR", SKillDB.GetComponent<SkillDatabase>().StrengthenS.Duration);
        
    }


}

[System.Serializable]
public class Focus: Skill
{
    public GameObject SlimeDB;
    public float CriticalChanceOri;
    public float CriticalChance;
    

}

[System.Serializable]
public class Haist: Skill
{
    public GameObject SlimeDB;
    public float AttackSpeedOri;
    public float AttackSpeed;


}




