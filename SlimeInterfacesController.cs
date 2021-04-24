using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeInterfacesController : MonoBehaviour
{
    public GameObject SlimeWork;
    public GameObject SlimeStatus;
    public GameObject SlimeEquip;
    public GameObject SlimePlace;
    public GameObject SlimeS;
    public GameObject CoreUIOB;
    public GameObject MaterialUIOB;
    public GameObject EquipmentUIOB;
    public GameObject SlimeStatusUIOB;
    public GameObject WorkUIOB;
    public GameObject SlimePlaceUIOB;
    public GameObject reinUICore;
    public GameObject reinEq;
    public GameObject SlimeCasStatusUI;
    public GameObject SkillUIS;
    public GameObject SkillUIUpgrade;
    public GameObject CraftTranUI;
    public GameObject RaidTranUI;
    public GameObject RaidConfirm;
    public GameObject ShopUI;
    public GameObject SelectedIT;

    
    // Start is called before the first frame update
    void Start()
    {
        SlimeS = GameObject.Find("SC");
    }

    // Update is called once per frame
    void Update()
    {
        if(SelectedIT.GetComponent<SelectedItem>().selectedCore.coreID == 0)
        {
            CoreUI.SwitchCoreUI = false;
            ReinforceCoreUI.SwitchReinCoreUI = false;
        }
        if(SelectedIT.GetComponent<SelectedItem>().selectedEQ.EquipmentID == 0)
        {
            EquipmentUI.SwitchEQUI = false;
            ReinforceUI.SwitchReinUI = false;
        }
        if(SelectedIT.GetComponent<SelectedItem>().selectedMT.materialID == 0)
        {
            MaterialUI.SwitchMaterialUI = false;
        }



        if(ButtonStartBattle.Clickable == false)
        {
            CoreUI.SwitchCoreUI = false;
            MaterialUI.SwitchMaterialUI = false;
            EquipmentUI.SwitchEQUI = false;
            MoveStatusUI.SwitchStatusUI = false;
            MoveWorkUI.SwitchWorkUI = false;

            SlimeCasUITrans.SwitchCasUI = false;
            ReinforceCoreUI.SwitchReinCoreUI = false;
            ReinforceUI.SwitchReinUI = false;
            SkillUI.SkillUISwit = false;
            SKillUpgradeUI.SkillUpgradeSwit = false;
            CraftingTransformUI.CraftingSwit = false;
            RaidUISC.RaidUISwit = false;
            ShopTransferUI.ShopSwit = false;

        }



        if (SlimeS.GetComponent<SlimeSelection>().SelectedSlime != null)
        {
            SlimeWork.SetActive(true);
            SlimeStatus.SetActive(true);
            SlimeEquip.SetActive(true);
            SlimePlace.SetActive(true);
        }
        if(CoreUI.SwitchCoreUI == true)
        {
            CoreUIOB.SetActive(true);
            CoreUI.SwitchCoreUI = true;
        }
        if(MaterialUI.SwitchMaterialUI == true)
        {
            MaterialUIOB.SetActive(true);
            MaterialUI.SwitchMaterialUI = true;
        }
        if(EquipmentUI.SwitchEQUI == true)
        {
            EquipmentUIOB.SetActive(true);
            EquipmentUI.SwitchEQUI = true;
        }
        if(MoveStatusUI.SwitchStatusUI == true)
        {
            SlimeStatusUIOB.SetActive(true);
            MoveStatusUI.SwitchStatusUI = true;
        }
        if(MoveWorkUI.SwitchWorkUI == true)
        {
            WorkUIOB.SetActive(true);
            MoveWorkUI.SwitchWorkUI = true;
        }
        if(SlimeCasUITrans.SwitchCasUI == true)
        {
            SlimePlaceUIOB.SetActive(true);
            SlimeCasStatusUI.SetActive(true);
            SlimeCasUITrans.SwitchCasUI = true;

        }
        
        if(ReinforceCoreUI.SwitchReinCoreUI == true)
        {
            reinUICore.gameObject.SetActive(true);
            ReinforceCoreUI.SwitchReinCoreUI = true;
        }
        if(ReinforceUI.SwitchReinUI == true)
        {
            reinEq.SetActive(true);
            ReinforceUI.SwitchReinUI = true;
        }
        if(SkillUI.SkillUISwit == true)
        {
            SkillUIS.SetActive(true);
            SkillUI.SkillUISwit = true;
        }
        if(SKillUpgradeUI.SkillUpgradeSwit == true)
        {
            SkillUIUpgrade.SetActive(true);
            SKillUpgradeUI.SkillUpgradeSwit = true;
        }
    
        if(CraftingTransformUI.CraftingSwit== true)
        {
            CraftTranUI.SetActive(true);
            CraftingTransformUI.CraftingSwit = true;
        }

        if(RaidUISC.RaidUISwit == true)
        {
            RaidTranUI.SetActive(true);
            RaidUISC.RaidUISwit = true;
        }

        if(RaidUISC.RaidUISwit == false)
        {
            RaidConfirm.SetActive(false);
        }

        if(ShopTransferUI.ShopSwit == true)
        {
            ShopUI.SetActive(true);
            ShopTransferUI.ShopSwit = true;
        }



    }
}
