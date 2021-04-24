using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SkillUpgradeUpdate : MonoBehaviour
{
    public GameObject SelectedSKillGO;
   

    // Update is called once per frame
    void Update()
    {
        this.transform.GetChild(2).GetChild(0).GetComponent<Image>().sprite = SelectedSKillGO.GetComponent<SelectedSkill>().SelectedSkillS.SkillImage;
        transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = SelectedSKillGO.GetComponent<SelectedSkill>().SelectedSkillS.SkillName;
        transform.GetChild(4).GetComponent<TextMeshProUGUI>().text = SelectedSKillGO.GetComponent<SelectedSkill>().SelectedSkillS.SkillLevel.ToString();
        transform.GetChild(5).GetComponent<TextMeshProUGUI>().text = (SelectedSKillGO.GetComponent<SelectedSkill>().SelectedSkillS.SkillLevel+1).ToString();
        transform.GetChild(7).GetComponent<TextMeshProUGUI>().text = SelectedSKillGO.GetComponent<SelectedSkill>().SelectedSkillS.Description;

        if(SelectedSKillGO.GetComponent<SelectedSkill>().SelectedSkillS.SkillLevel < maxValueController.MaxSkillLevel)
        {
            transform.GetChild(6).GetComponent<TextMeshProUGUI>().text = MoneyUnitControl.FormatNumber(SelectedSKillGO.GetComponent<SelectedSkill>().SelectedSkillS.Price);
            transform.GetChild(13).gameObject.SetActive(false);
            transform.GetChild(9).gameObject.SetActive(true);
            transform.GetChild(8).gameObject.SetActive(true);
            transform.GetChild(14).gameObject.SetActive(false);
            transform.GetChild(12).gameObject.SetActive(true);
            transform.GetChild(4).GetComponent<TextMeshProUGUI>().text = SelectedSKillGO.GetComponent<SelectedSkill>().SelectedSkillS.SkillLevel.ToString();
            transform.GetChild(5).GetComponent<TextMeshProUGUI>().text = (SelectedSKillGO.GetComponent<SelectedSkill>().SelectedSkillS.SkillLevel + 1).ToString();
        }

        if (SelectedSKillGO.GetComponent<SelectedSkill>().SelectedSkillS.SkillLevel >= maxValueController.MaxSkillLevel)

        {
            transform.GetChild(13).gameObject.SetActive(true);
            transform.GetChild(14).gameObject.SetActive(true);
            transform.GetChild(6).GetComponent<TextMeshProUGUI>().text = "";
            transform.GetChild(9).gameObject.SetActive(false);
            transform.GetChild(8).gameObject.SetActive(false);
            transform.GetChild(12).gameObject.SetActive(false);
            transform.GetChild(4).GetComponent<TextMeshProUGUI>().text = "";
            transform.GetChild(5).GetComponent<TextMeshProUGUI>().text = "";

        }

    }
}
