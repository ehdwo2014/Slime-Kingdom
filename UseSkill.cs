using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseSkill : MonoBehaviour
{
    public Skill A = new MagicShield();
    public GameObject SkillDB;
    public GameObject SoundDB;
    public GameObject GateWayOB;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UseSkills()
    {
        if (SkillDB.GetComponent<SkillDatabase>().SkillDB[this.transform.GetSiblingIndex()].CoolingState == true && StageCurrent.IsItFighting == true && SkillDB.GetComponent<SkillDatabase>().SkillDB[this.transform.GetSiblingIndex()].ManaConsumption <= GateWayOB.GetComponent<GateWayHP>().GateWayMPNow && SkillDB.GetComponent<SkillDatabase>().SkillDB[this.transform.GetSiblingIndex()].SkillLevel > 0)
        {
            GateWayOB.GetComponent<GateWayHP>().GateWayMPNow -= SkillDB.GetComponent<SkillDatabase>().SkillDB[this.transform.GetSiblingIndex()].ManaConsumption;

            if (this.transform.GetSiblingIndex() ==  1)
            {
                SoundDB.GetComponent<SoundController>().CallFixSound();
            }
            else if (this.transform.GetSiblingIndex() == 4)
            {

            }
            else
            {
                SoundDB.GetComponent<SoundController>().CallSkillUseSound();
            }
            SkillDB.GetComponent<SkillDatabase>().SkillDB[this.transform.GetSiblingIndex()].UseSkill();
            SkillDB.GetComponent<SkillDatabase>().SkillDB[this.transform.GetSiblingIndex()].CoolDownNow = SkillDB.GetComponent<SkillDatabase>().SkillDB[this.transform.GetSiblingIndex()].CoolDown;
        }

    }
}
