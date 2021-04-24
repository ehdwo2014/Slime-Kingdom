using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Skill
{
    public int SkillID;
    public string SkillName;
    public int SkillLevel;
    public long OriginalPrice;
    public Sprite SkillImage;
    public string Description;
    public long Price;
    public float CoolDownOriginal;
    public float CoolDown;
    public float CoolDownNow;
    public int ManaConsumption;
    public int ManaConOriginal;
    public float Duration;
    public bool CoolingState;


    public virtual void UseSkill()
    {

    }

}

class MagicShield: Skill
{
    public override void UseSkill()
    {
        this.Price = 10000;
        Debug.Log(this.Price);
        Debug.Log("1");
    }
    
}

