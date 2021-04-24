using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateImageTextSkill : MonoBehaviour
{
    public GameObject SkillDB;
    void Update()
    {
        if (SkillDB.GetComponent<SkillDatabase>().SkillDB[this.transform.GetSiblingIndex()].SkillLevel != 0)
        {
            this.transform.GetChild(3).GetComponent<Button>().interactable = true;
        }
        else if(SkillDB.GetComponent<SkillDatabase>().SkillDB[this.transform.GetSiblingIndex()].SkillLevel == 0)
        {
            this.transform.GetChild(3).GetComponent<Button>().interactable = false;
        }

        if (SkillDB.GetComponent<SkillDatabase>().SkillDB[this.transform.GetSiblingIndex()].SkillLevel < maxValueController.MaxSkillLevel)
        {
            this.transform.GetChild(3).GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "LV " + SkillDB.GetComponent<SkillDatabase>().SkillDB[this.transform.GetSiblingIndex()].SkillLevel.ToString();
        }

        if (SkillDB.GetComponent<SkillDatabase>().SkillDB[this.transform.GetSiblingIndex()].SkillLevel >= maxValueController.MaxSkillLevel)
        {
            this.transform.GetChild(3).GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Max";
        }


    }
}
