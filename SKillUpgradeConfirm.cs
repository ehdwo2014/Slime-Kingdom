using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKillUpgradeConfirm : MonoBehaviour
{
    public GameObject SelectedSkillSA;
    public GameObject MessageSender;
    public GameObject SoundDB;


    public void onClickConfirm()
    {
        if(SelectedSkillSA.GetComponent<SelectedSkill>().SelectedSkillS.Price < PlayerInfor.Money)
        {
            PlayerInfor.Money -= SelectedSkillSA.GetComponent<SelectedSkill>().SelectedSkillS.Price;
            SelectedSkillSA.GetComponent<SelectedSkill>().SelectedSkillS.SkillLevel++;
            SoundDB.GetComponent<SoundController>().CallConfirmSound();
        }
        else
        {
            MessageSender.GetComponent<SendingMessage>().ActTheText("Not enough money");
        }
    }
}
