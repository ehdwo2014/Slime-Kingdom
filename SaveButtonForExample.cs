using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveButtonForExample : MonoBehaviour
{
    public GameObject MaterialInv;
    public GameObject EquipmentInv;
    public GameObject CoreInv;
    public GameObject Instant;

    public GameObject OriginalEQDB;
    public GameObject OriginalCoreDB;
    public GameObject SlimeDBOB;
    public GameObject CasUI;
    public GameObject Skills;
    public GameObject GateWay;
    public GameObject CasUICOPY;


    public PlayerData PD;

    void OnApplicationQuit()
    {
        OnClickSaveButton();
    }

    void OnApplicationPause(bool pause)
    {
        bool DidyouSave = false;
        if(pause && DidyouSave == false)
        {
            DidyouSave = true;
            OnClickSaveButton();
        }

        if(pause == false)
        {
            DidyouSave = false;
        }


    }


    void Start()
    {
        OnClickLoadButton();
    }



    public void OnClickSaveButton()
    {
        PD.Money = PlayerInfor.Money;
        PD.Dia = PlayerInfor.Diamond;
        PD.StageLevel = PlayerInfor.Stage;

        for (int i=0; i<GateWay.GetComponent<GateWayHP>().GateWayStat.Count; i++)
        {
            PD.LevelOfGates[i].Level = GateWay.GetComponent<GateWayHP>().GateWayStat[i];
        }
        
        for (int i=0; i< Skills.GetComponent<SkillDatabase>().SkillDB.Count; i++)
        {
            PD.LevelOfSkills[i].Level = Skills.GetComponent<SkillDatabase>().SkillDB[i].SkillLevel;

        }

        for (int i = 0; i < MaterialInv.GetComponent<MaterialInventory>().materials.Count; i++)
        {
            PD.Material[i].MaterialID = MaterialInv.GetComponent<MaterialInventory>().materials[i].materialID;
            PD.Material[i].Amount = MaterialInv.GetComponent<MaterialInventory>().materials[i].Amount;

        }

        for(int i=0; i< EquipmentInv.GetComponent<EquipmentInventory>().eqs.Count; i++)
        {
            PD.Equipment[i].EquipmentID = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].EquipmentID;
            PD.Equipment[i].AttackPoint = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].AttackPoint;
            PD.Equipment[i].CriticalPoint = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].CriticalPoint;
            PD.Equipment[i].dark = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].dark;
            PD.Equipment[i].Description = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].Description;
            PD.Equipment[i].EqLevel = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].EqLevel;
            PD.Equipment[i].EQPositionIndex = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].EQPositionIndex;
            PD.Equipment[i].EquipmentName = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].EquipmentName;
            PD.Equipment[i].EquipmentRank = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].EquipmentRank;
            PD.Equipment[i].fire = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].fire;
            PD.Equipment[i].ice = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].ice;
            PD.Equipment[i].IsItDescOnly = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].IsItDescOnly;
            PD.Equipment[i].IsItEquipped = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].IsItEquipped;
            PD.Equipment[i].IsThisDesc = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].IsThisDesc;
            PD.Equipment[i].light = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].light;
            PD.Equipment[i].MagicalAttack = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].MagicalAttack;
            PD.Equipment[i].MagicalAttackOrigin = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].MagicalAttackOrigin;
            PD.Equipment[i].MovementSpeed = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].MovementSpeed;
            PD.Equipment[i].originaldark = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].originaldark;
            PD.Equipment[i].originalfire = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].originalfire;
            PD.Equipment[i].originalice = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].originalice;
            PD.Equipment[i].originallight = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].originallight;
            PD.Equipment[i].PhysicalAttack = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].PhysicalAttack;
            PD.Equipment[i].PhysicalAttackOrigin = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].PhysicalAttackOrigin;
            PD.Equipment[i].Price = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].Price;
            PD.Equipment[i].PriceToUpgrade = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].PriceToUpgrade;
            PD.Equipment[i].typeOfAttack = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].typeOfAttack;
            PD.Equipment[i].typeOfEQ = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].typeOfEQ;
            PD.Equipment[i].WorkingPoint = EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].WorkingPoint;

        }

        for(int i=0; i<CoreInv.GetComponent<CoreInventory>().cores.Count; i++)
        {

            PD.Core[i].CoreDescription = CoreInv.GetComponent<CoreInventory>().cores[i].CoreDescription;
            PD.Core[i].coreID = CoreInv.GetComponent<CoreInventory>().cores[i].coreID;
            PD.Core[i].coreLevel = CoreInv.GetComponent<CoreInventory>().cores[i].coreLevel;
            PD.Core[i].coreName = CoreInv.GetComponent<CoreInventory>().cores[i].coreName;
            PD.Core[i].corePower = CoreInv.GetComponent<CoreInventory>().cores[i].corePower;
            PD.Core[i].coreRank = CoreInv.GetComponent<CoreInventory>().cores[i].coreRank;
            PD.Core[i].dark = CoreInv.GetComponent<CoreInventory>().cores[i].dark;
            PD.Core[i].DEX = CoreInv.GetComponent<CoreInventory>().cores[i].DEX;
            PD.Core[i].DEXOri = CoreInv.GetComponent<CoreInventory>().cores[i].DEXOri;
            PD.Core[i].fire = CoreInv.GetComponent<CoreInventory>().cores[i].fire;
            PD.Core[i].ice = CoreInv.GetComponent<CoreInventory>().cores[i].ice;
            PD.Core[i].INT = CoreInv.GetComponent<CoreInventory>().cores[i].INT;
            PD.Core[i].INTOri = CoreInv.GetComponent<CoreInventory>().cores[i].INTOri;
            PD.Core[i].IsItDescOnly = CoreInv.GetComponent<CoreInventory>().cores[i].IsItDescOnly;
            PD.Core[i].IsItEquipped = CoreInv.GetComponent<CoreInventory>().cores[i].IsItEquipped;
            PD.Core[i].IsThisDesc = CoreInv.GetComponent<CoreInventory>().cores[i].IsThisDesc;
            PD.Core[i].light = CoreInv.GetComponent<CoreInventory>().cores[i].light;
            PD.Core[i].LUK = CoreInv.GetComponent<CoreInventory>().cores[i].LUK;
            PD.Core[i].LUKOri = CoreInv.GetComponent<CoreInventory>().cores[i].LUKOri;
            PD.Core[i].OriginalcorePower = CoreInv.GetComponent<CoreInventory>().cores[i].OriginalcorePower;
            PD.Core[i].Originaldark = CoreInv.GetComponent<CoreInventory>().cores[i].Originaldark;
            PD.Core[i].Originalfire = CoreInv.GetComponent<CoreInventory>().cores[i].Originalfire;
            PD.Core[i].Originalice = CoreInv.GetComponent<CoreInventory>().cores[i].Originalice;
            PD.Core[i].Originallight = CoreInv.GetComponent<CoreInventory>().cores[i].Originallight;
            PD.Core[i].price = CoreInv.GetComponent<CoreInventory>().cores[i].price;
            PD.Core[i].priceToUpgrade = CoreInv.GetComponent<CoreInventory>().cores[i].priceToUpgrade;
            PD.Core[i].STR = CoreInv.GetComponent<CoreInventory>().cores[i].STR;
            PD.Core[i].STROri = CoreInv.GetComponent<CoreInventory>().cores[i].STROri;
            
        }

        for(int i = 0; i < SlimeDB.AmountOfSlime; i++ )
        {
            PD.SlimeAcc[i] = EQSetM(SlimeDBOB.transform.GetChild(i).GetComponent<SlimeState>().slimeState.Accessory);
            PD.SlimeAura[i] = EQSetM(SlimeDBOB.transform.GetChild(i).GetComponent<SlimeState>().slimeState.Aura);
            PD.SlimeWeapon[i] = EQSetM(SlimeDBOB.transform.GetChild(i).GetComponent<SlimeState>().slimeState.Weapon);
            PD.SlimeCore[i] = CoreSetM(SlimeDBOB.transform.GetChild(i).GetComponent<SlimeState>().slimeState.UsedCore);
            PD.SlimeStates[i] = SlimeSetM(SlimeDBOB.transform.GetChild(i).GetComponent<SlimeState>().slimeState);

            PD.PositionsOfSlime[i].x = SlimeDBOB.transform.GetChild(i).transform.position.x;
            PD.PositionsOfSlime[i].y = SlimeDBOB.transform.GetChild(i).transform.position.y;
            PD.PositionsOfSlime[i].z = SlimeDBOB.transform.GetChild(i).transform.position.z;

            PD.SLimeOtherStates[i].AuraIndex = SlimeDBOB.transform.GetChild(i).GetComponent<SlimeState>().AuraIndex;
            PD.SLimeOtherStates[i].AuraEquipped = SlimeDBOB.transform.GetChild(i).GetComponent<SlimeState>().AuraEquipped;
            PD.SLimeOtherStates[i].WorkIndex = SlimeDBOB.transform.GetChild(i).GetComponent<SlimeWork>().WorkIndex;
           

        }


        PD.NumberOfSlime = SlimeDB.AmountOfSlime;

        string realPath = Application.persistentDataPath + "/save.dat";

        SaveSystem.Save(PD, realPath);


        
        

        
        

    }
    public void OnClickLoadButton()
    {
        string realPath = Application.persistentDataPath + "/save.dat";
       

        if (SaveSystem.Load(realPath) != null)
        {
            PD = SaveSystem.Load(realPath);

            Destroy(SlimeDBOB.transform.GetChild(0).gameObject);
            Destroy(SlimeDBOB.transform.GetChild(1).gameObject);


            for (int i = 0; i < GateWay.GetComponent<GateWayHP>().GateWayStat.Count; i++)
            {
                GateWay.GetComponent<GateWayHP>().GateWayStat[i] = PD.LevelOfGates[i].Level;
            }


            for (int i = 0; i < PD.NumberOfSlime; i++)
            {

                Instant = Instantiate(SlimeDBOB.GetComponent<SlimeDB>().InstantSlime, new Vector3(0, 0, 0), new Quaternion(), SlimeDBOB.transform);
                Instant.transform.GetChild(0).gameObject.SetActive(false);
                Instant.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                Instant.gameObject.GetComponent<SlimeState>().slimeState = SlimeSet(PD.SlimeStates[i]);

                Instant.gameObject.GetComponent<SlimeState>().slimeState.Weapon = EQSet(PD.SlimeWeapon[i]);
                Instant.gameObject.GetComponent<SlimeState>().slimeState.Aura = EQSet(PD.SlimeAura[i]);
                Instant.gameObject.GetComponent<SlimeState>().slimeState.Accessory = EQSet(PD.SlimeAcc[i]);
                Instant.gameObject.GetComponent<SlimeState>().slimeState.UsedCore = CoreSet(PD.SlimeCore[i]);

                Instant.gameObject.GetComponent<SlimeState>().slimeState.UsedCore.itemImage = OriginalCoreDB.GetComponent<CoreInventory>().cores[Instant.gameObject.GetComponent<SlimeState>().slimeState.UsedCore.coreID].itemImage;
                Instant.gameObject.GetComponent<SlimeState>().slimeState.Weapon.EquipmentImage = OriginalEQDB.GetComponent<EquipmentInventory>().eqs[Instant.gameObject.GetComponent<SlimeState>().slimeState.Weapon.EquipmentID].EquipmentImage;
                Instant.gameObject.GetComponent<SlimeState>().slimeState.Accessory.EquipmentImage = OriginalEQDB.GetComponent<EquipmentInventory>().eqs[Instant.gameObject.GetComponent<SlimeState>().slimeState.Accessory.EquipmentID].EquipmentImage;
                Instant.gameObject.GetComponent<SlimeState>().slimeState.Aura.EquipmentImage = OriginalEQDB.GetComponent<EquipmentInventory>().eqs[Instant.gameObject.GetComponent<SlimeState>().slimeState.Aura.EquipmentID].EquipmentImage;

                Instant.gameObject.transform.position = new Vector3(PD.PositionsOfSlime[i].x, PD.PositionsOfSlime[i].y, PD.PositionsOfSlime[i].z);
                Instant.gameObject.GetComponent<SlimeState>().slimeState.SlimeSprite = SlimeDBOB.GetComponent<SlimeDB>().InstantSlime.GetComponent<SlimeState>().slimeState.SlimeSprite;

                Instant.gameObject.GetComponent<SlimeState>().AuraIndex = PD.SLimeOtherStates[i].AuraIndex;
                Instant.gameObject.GetComponent<SlimeState>().AuraEquipped = PD.SLimeOtherStates[i].AuraEquipped;
                Instant.gameObject.GetComponent<SlimeWork>().WorkIndex = PD.SLimeOtherStates[i].WorkIndex;

                if (Instant.gameObject.GetComponent<SlimeState>().slimeState.SlimePlaceIndex != -1)
                {
                    CasUICOPY.GetComponent<SlimeInventoryCopy>().SlimeList1[Instant.gameObject.GetComponent<SlimeState>().slimeState.SlimePlaceIndex] = Instant;
                    CasUI.GetComponent<SlimeInventory>().SlimeList[Instant.gameObject.GetComponent<SlimeState>().slimeState.SlimePlaceIndex] = Instant;
                    
                }

            }



            PlayerInfor.Money = PD.Money;
            PlayerInfor.Diamond = PD.Dia;
            PlayerInfor.Stage = PD.StageLevel;


            for (int i = 0; i < MaterialInv.GetComponent<MaterialInventory>().materials.Count; i++)
            {
                MaterialInv.GetComponent<MaterialInventory>().materials[i].materialID = PD.Material[i].MaterialID;
                MaterialInv.GetComponent<MaterialInventory>().materials[i].Amount = PD.Material[i].Amount;

            }

            for (int i = 0; i < EquipmentInv.GetComponent<EquipmentInventory>().eqs.Count; i++)
            {
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].EquipmentID = PD.Equipment[i].EquipmentID;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].AttackPoint = PD.Equipment[i].AttackPoint;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].CriticalPoint = PD.Equipment[i].CriticalPoint;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].dark = PD.Equipment[i].dark;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].Description = PD.Equipment[i].Description;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].EqLevel = PD.Equipment[i].EqLevel;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].EQPositionIndex = PD.Equipment[i].EQPositionIndex;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].EquipmentName = PD.Equipment[i].EquipmentName;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].EquipmentRank = PD.Equipment[i].EquipmentRank;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].fire = PD.Equipment[i].fire;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].ice = PD.Equipment[i].ice;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].IsItDescOnly = PD.Equipment[i].IsItDescOnly;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].IsItEquipped = PD.Equipment[i].IsItEquipped;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].IsThisDesc = PD.Equipment[i].IsThisDesc;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].light = PD.Equipment[i].light;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].MagicalAttack = PD.Equipment[i].MagicalAttack;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].MagicalAttackOrigin = PD.Equipment[i].MagicalAttackOrigin;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].MovementSpeed = PD.Equipment[i].MovementSpeed;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].originaldark = PD.Equipment[i].originaldark;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].originalfire = PD.Equipment[i].originalfire;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].originalice = PD.Equipment[i].originalice;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].originallight = PD.Equipment[i].originallight;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].PhysicalAttack = PD.Equipment[i].PhysicalAttack;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].PhysicalAttackOrigin = PD.Equipment[i].PhysicalAttackOrigin;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].Price = PD.Equipment[i].Price;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].PriceToUpgrade = PD.Equipment[i].PriceToUpgrade;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].typeOfAttack = PD.Equipment[i].typeOfAttack;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].typeOfEQ = PD.Equipment[i].typeOfEQ;
                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].WorkingPoint = PD.Equipment[i].WorkingPoint;


                EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].EquipmentImage = OriginalEQDB.GetComponent<EquipmentInventory>().eqs[EquipmentInv.GetComponent<EquipmentInventory>().eqs[i].EquipmentID].EquipmentImage;

            }

            for (int i = 0; i < CoreInv.GetComponent<CoreInventory>().cores.Count; i++)
            {

                CoreInv.GetComponent<CoreInventory>().cores[i].CoreDescription = PD.Core[i].CoreDescription;
                CoreInv.GetComponent<CoreInventory>().cores[i].coreID = PD.Core[i].coreID;
                CoreInv.GetComponent<CoreInventory>().cores[i].coreLevel = PD.Core[i].coreLevel;
                CoreInv.GetComponent<CoreInventory>().cores[i].coreName = PD.Core[i].coreName;
                CoreInv.GetComponent<CoreInventory>().cores[i].corePower = PD.Core[i].corePower;
                CoreInv.GetComponent<CoreInventory>().cores[i].coreRank = PD.Core[i].coreRank;
                CoreInv.GetComponent<CoreInventory>().cores[i].dark = PD.Core[i].dark;
                CoreInv.GetComponent<CoreInventory>().cores[i].DEX = PD.Core[i].DEX;
                CoreInv.GetComponent<CoreInventory>().cores[i].DEXOri = PD.Core[i].DEXOri;
                CoreInv.GetComponent<CoreInventory>().cores[i].fire = PD.Core[i].fire;
                CoreInv.GetComponent<CoreInventory>().cores[i].ice = PD.Core[i].ice;
                CoreInv.GetComponent<CoreInventory>().cores[i].INT = PD.Core[i].INT;
                CoreInv.GetComponent<CoreInventory>().cores[i].INTOri = PD.Core[i].INTOri;
                CoreInv.GetComponent<CoreInventory>().cores[i].IsItDescOnly = PD.Core[i].IsItDescOnly;
                CoreInv.GetComponent<CoreInventory>().cores[i].IsItEquipped = PD.Core[i].IsItEquipped;
                CoreInv.GetComponent<CoreInventory>().cores[i].IsThisDesc = PD.Core[i].IsThisDesc;
                CoreInv.GetComponent<CoreInventory>().cores[i].light = PD.Core[i].light;
                CoreInv.GetComponent<CoreInventory>().cores[i].LUK = PD.Core[i].LUK;
                CoreInv.GetComponent<CoreInventory>().cores[i].LUKOri = PD.Core[i].LUKOri;
                CoreInv.GetComponent<CoreInventory>().cores[i].OriginalcorePower = PD.Core[i].OriginalcorePower;
                CoreInv.GetComponent<CoreInventory>().cores[i].Originaldark = PD.Core[i].Originaldark;
                CoreInv.GetComponent<CoreInventory>().cores[i].Originalfire = PD.Core[i].Originalfire;
                CoreInv.GetComponent<CoreInventory>().cores[i].Originalice = PD.Core[i].Originalice;
                CoreInv.GetComponent<CoreInventory>().cores[i].Originallight = PD.Core[i].Originallight;
                CoreInv.GetComponent<CoreInventory>().cores[i].price = PD.Core[i].price;
                CoreInv.GetComponent<CoreInventory>().cores[i].priceToUpgrade = PD.Core[i].priceToUpgrade;
                CoreInv.GetComponent<CoreInventory>().cores[i].STR = PD.Core[i].STR;
                CoreInv.GetComponent<CoreInventory>().cores[i].STROri = PD.Core[i].STROri;

                CoreInv.GetComponent<CoreInventory>().cores[i].itemImage = OriginalCoreDB.GetComponent<CoreInventory>().cores[CoreInv.GetComponent<CoreInventory>().cores[i].coreID].itemImage;

            }


            for (int i = 0; i < Skills.GetComponent<SkillDatabase>().SkillDB.Count; i++)
            {
                Skills.GetComponent<SkillDatabase>().SkillDB[i].SkillLevel = PD.LevelOfSkills[i].Level;
            }
        }

        if(SaveSystem.Load(realPath) == null)
        {
            PlayerInfor.Money = 0;
            PlayerInfor.Diamond = 0;
            PlayerInfor.Stage = 1;


            SlimeDBOB.transform.GetChild(0).GetComponent<SlimeState>().slimeState.UsedCore = OriginalCoreDB.GetComponent<CoreInventory>().DeepCopyCore(OriginalCoreDB.GetComponent<CoreInventory>().cores[1]);
            SlimeDBOB.transform.GetChild(1).GetComponent<SlimeState>().slimeState.UsedCore = OriginalCoreDB.GetComponent<CoreInventory>().DeepCopyCore(OriginalCoreDB.GetComponent<CoreInventory>().cores[1]);
            SlimeDBOB.transform.GetChild(0).GetComponent<SlimeState>().slimeState.Weapon = OriginalEQDB.GetComponent<EquipmentInventory>().DeepCopyEQ(OriginalEQDB.GetComponent<EquipmentInventory>().eqs[1]);
            SlimeDBOB.transform.GetChild(1).GetComponent<SlimeState>().slimeState.Weapon = OriginalEQDB.GetComponent<EquipmentInventory>().DeepCopyEQ(OriginalEQDB.GetComponent<EquipmentInventory>().eqs[50]);
            SlimeDBOB.transform.GetChild(1).GetComponent<SlimeState>().slimeState.Aura = OriginalEQDB.GetComponent<EquipmentInventory>().DeepCopyEQ(OriginalEQDB.GetComponent<EquipmentInventory>().eqs[106]);

            SlimeDBOB.transform.GetChild(1).GetComponent<SlimeState>().slimeState.Weapon.EqLevel = 7;
            ItemRefactorizing.ChangingCore(SlimeDBOB.transform.GetChild(0).GetComponent<SlimeState>().slimeState.UsedCore);
            ItemRefactorizing.ChangingCore(SlimeDBOB.transform.GetChild(1).GetComponent<SlimeState>().slimeState.UsedCore);
            ItemRefactorizing.ChaningEQ(SlimeDBOB.transform.GetChild(0).GetComponent<SlimeState>().slimeState.Weapon);
            ItemRefactorizing.ChaningEQ(SlimeDBOB.transform.GetChild(1).GetComponent<SlimeState>().slimeState.Weapon);
            ItemRefactorizing.ChaningEQ(SlimeDBOB.transform.GetChild(1).GetComponent<SlimeState>().slimeState.Aura);


            for (int i = 0; i < GateWay.GetComponent<GateWayHP>().GateWayStat.Count; i++)
            {
                GateWay.GetComponent<GateWayHP>().GateWayStat[i] = 1;
            }

            for (int i = 0; i < Skills.GetComponent<SkillDatabase>().SkillDB.Count; i++)
            {
                Skills.GetComponent<SkillDatabase>().SkillDB[i].SkillLevel = 0;
            }
            Skills.GetComponent<SkillDatabase>().SkillDB[0].SkillLevel = 1;



        }








    }

    public Equipment EQSet  (EquipmentModified EQM)
    {
        Equipment EQ = new Equipment();

        EQ.EquipmentID = EQM.EquipmentID;
        EQ.AttackPoint = EQM.AttackPoint;
        EQ.CriticalPoint = EQM.CriticalPoint;
        EQ.dark = EQM.dark;
        EQ.Description = EQM.Description;
        EQ.EqLevel = EQM.EqLevel;
        EQ.EQPositionIndex = EQM.EQPositionIndex;
        EQ.EquipmentName = EQM.EquipmentName;
        EQ.EquipmentRank = EQM.EquipmentRank;
        EQ.fire = EQM.fire;
        EQ.ice = EQM.ice;
        EQ.IsItDescOnly = EQM.IsItDescOnly;
        EQ.IsItEquipped = EQM.IsItEquipped;
        EQ.IsThisDesc = EQM.IsThisDesc;
        EQ.light = EQM.light;
        EQ.MagicalAttack = EQM.MagicalAttack;
        EQ.MagicalAttackOrigin = EQM.MagicalAttackOrigin;
        EQ.MovementSpeed = EQM.MovementSpeed;
        EQ.originaldark = EQM.originaldark;
        EQ.originalfire = EQM.originalfire;
        EQ.originalice = EQM.originalice;
        EQ.originallight = EQM.originallight;
        EQ.PhysicalAttack = EQM.PhysicalAttack;
        EQ.PhysicalAttackOrigin = EQM.PhysicalAttackOrigin;
        EQ.Price = EQM.Price;
        EQ.PriceToUpgrade = EQM.PriceToUpgrade;
        EQ.typeOfAttack = EQM.typeOfAttack;
        EQ.typeOfEQ = EQM.typeOfEQ;
        EQ.WorkingPoint = EQM.WorkingPoint;

        return EQ;
    }

    public EquipmentModified EQSetM (Equipment EQ)
    {
        EquipmentModified EQM = new EquipmentModified();

        EQM.EquipmentID = EQ.EquipmentID;
        EQM.AttackPoint = EQ.AttackPoint;
        EQM.CriticalPoint = EQ.CriticalPoint;
        EQM.dark = EQ.dark;
        EQM.Description = EQ.Description;
        EQM.EqLevel = EQ.EqLevel;
        EQM.EQPositionIndex = EQ.EQPositionIndex;
        EQM.EquipmentName = EQ.EquipmentName;
        EQM.EquipmentRank = EQ.EquipmentRank;
        EQM.fire = EQ.fire;
        EQM.ice = EQ.ice;
        EQM.IsItDescOnly = EQ.IsItDescOnly;
        EQM.IsItEquipped = EQ.IsItEquipped;
        EQM.IsThisDesc = EQ.IsThisDesc;
        EQM.light = EQ.light;
        EQM.MagicalAttack = EQ.MagicalAttack;
        EQM.MagicalAttackOrigin = EQ.MagicalAttackOrigin;
        EQM.MovementSpeed = EQ.MovementSpeed;
        EQM.originaldark = EQ.originaldark;
        EQM.originalfire = EQ.originalfire;
        EQM.originalice = EQ.originalice;
        EQM.originallight = EQ.originallight;
        EQM.PhysicalAttack = EQ.PhysicalAttack;
        EQM.PhysicalAttackOrigin = EQ.PhysicalAttackOrigin;
        EQM.Price = EQ.Price;
        EQM.PriceToUpgrade = EQ.PriceToUpgrade;
        EQM.typeOfAttack = EQ.typeOfAttack;
        EQM.typeOfEQ = EQ.typeOfEQ;
        EQM.WorkingPoint = EQ.WorkingPoint;
    
        return EQM;
    }



    public Slime SlimeSet(SlimeStateModified SlimeM)
    {
        Slime Sl = new Slime();
        Sl.AtimeNeed = SlimeM.AtimeNeed;
        Sl.AtimeNow = SlimeM.AtimeNow;
        Sl.AttackPoint = SlimeM.AttackPoint;
        Sl.AttackReady = SlimeM.AttackReady;
        Sl.AttackSpeed = SlimeM.AttackSpeed;
        Sl.AttackSpeedNow = SlimeM.AttackSpeedNow;
        Sl.AttackSpeedOriginal = SlimeM.AttackSpeedOriginal;
        Sl.AttackType = SlimeM.AttackType;
        Sl.CriticalPoint = SlimeM.CriticalPoint;
        Sl.Dark = SlimeM.Dark;
        Sl.DEX = SlimeM.DEX;
        Sl.Fire = SlimeM.Fire;
        Sl.Ice = SlimeM.Ice;
        Sl.INT = SlimeM.INT;
        Sl.INTBuff = SlimeM.INTBuff;
        Sl.Level = SlimeM.Level;
        Sl.Light = SlimeM.Light;
        Sl.LUK = SlimeM.LUK;
        Sl.MagicalATK = SlimeM.MagicalATK;
        Sl.ManaAmple = SlimeM.ManaAmple;
        Sl.MiningAbility = SlimeM.MiningAbility;
        Sl.MovementSpeed = SlimeM.MovementSpeed;
        Sl.PhysicalATK = SlimeM.PhysicalATK;
        Sl.PriceToLevelUP = SlimeM.PriceToLevelUP;
        Sl.SlimeEggMode = SlimeM.SlimeEggMode;
        Sl.SlimeID = SlimeM.SlimeID;
        Sl.SlimeName = SlimeM.SlimeName;
        Sl.SlimePlaceIndex = SlimeM.SlimePlaceIndex;
        Sl.SlimeRank = SlimeM.SlimeRank;
        Sl.SlimeSpecialAbility = SlimeM.SlimeSpecialAbility;
        Sl.SlimeTypeID = SlimeM.SlimeTypeID;
        Sl.Sprafe = SlimeM.Sprafe;
        Sl.STR = SlimeM.STR;
        Sl.STRBuff = SlimeM.STRBuff;
        Sl.Strengthening = SlimeM.Strengthening;
        Sl.WorkSpeedNow = SlimeM.WorkSpeedNow;
        Sl.WorkDone = SlimeM.WorkDone;
        Sl.WorkSpeed = SlimeM.WorkSpeed;
        Sl.WorkSpeedOriginal = SlimeM.WorkSpeedOriginal;
        Sl.WorkTimeNeed = SlimeM.WorkTimeNeed;
        Sl.WorkTimeNow = SlimeM.WorkTimeNow;

        return Sl;
    }


    public SlimeStateModified SlimeSetM(Slime SlimeOri)
    {
        SlimeStateModified SlimeModi = new SlimeStateModified();

        SlimeModi.AtimeNeed = SlimeOri.AtimeNeed;
        SlimeModi.AtimeNow = SlimeOri.AtimeNow;
        SlimeModi.AttackPoint = SlimeOri.AttackPoint;
        SlimeModi.AttackReady = SlimeOri.AttackReady;
        SlimeModi.AttackSpeed = SlimeOri.AttackSpeed;
        SlimeModi.AttackSpeedNow = SlimeOri.AttackSpeedNow;
        SlimeModi.AttackSpeedOriginal = SlimeOri.AttackSpeedOriginal;
        SlimeModi.AttackType = SlimeOri.AttackType;
        SlimeModi.CriticalPoint = SlimeOri.CriticalPoint;
        SlimeModi.Dark = SlimeOri.Dark;
        SlimeModi.DEX = SlimeOri.DEX;
        SlimeModi.Fire = SlimeOri.Fire;
        SlimeModi.Ice = SlimeOri.Ice;
        SlimeModi.INT = SlimeOri.INT;
        SlimeModi.INTBuff = SlimeOri.INTBuff;
        SlimeModi.Level = SlimeOri.Level;
        SlimeModi.Light = SlimeOri.Light;
        SlimeModi.LUK = SlimeOri.LUK;
        SlimeModi.MagicalATK = SlimeOri.MagicalATK;
        SlimeModi.ManaAmple = SlimeOri.ManaAmple;
        SlimeModi.MiningAbility = SlimeOri.MiningAbility;
        SlimeModi.MovementSpeed = SlimeOri.MovementSpeed;
        SlimeModi.PhysicalATK = SlimeOri.PhysicalATK;
        SlimeModi.PriceToLevelUP = SlimeOri.PriceToLevelUP;
        SlimeModi.SlimeEggMode = SlimeOri.SlimeEggMode;
        SlimeModi.SlimeID = SlimeOri.SlimeID;
        SlimeModi.SlimeName = SlimeOri.SlimeName;
        SlimeModi.SlimePlaceIndex = SlimeOri.SlimePlaceIndex;
        SlimeModi.SlimeRank = SlimeOri.SlimeRank;
        SlimeModi.SlimeSpecialAbility = SlimeOri.SlimeSpecialAbility;
        SlimeModi.SlimeTypeID = SlimeOri.SlimeTypeID;
        SlimeModi.Sprafe = SlimeOri.Sprafe;
        SlimeModi.STR = SlimeOri.STR;
        SlimeModi.STRBuff = SlimeOri.STRBuff;
        SlimeModi.Strengthening = SlimeOri.Strengthening;
        SlimeModi.WorkSpeedNow = SlimeOri.WorkSpeedNow;
        SlimeModi.WorkDone = SlimeOri.WorkDone;
        SlimeModi.WorkSpeed = SlimeOri.WorkSpeed;
        SlimeModi.WorkSpeedOriginal = SlimeOri.WorkSpeedOriginal;
        SlimeModi.WorkTimeNeed = SlimeOri.WorkTimeNeed;
        SlimeModi.WorkTimeNow = SlimeOri.WorkTimeNow;

        return SlimeModi;
    }





    public Core CoreSet (CoreModified CoreM)
    {
        Core Cor = new Core();

        Cor.CoreDescription = CoreM.CoreDescription;
        Cor.coreID = CoreM.coreID;
        Cor.coreLevel = CoreM.coreLevel;
        Cor.coreName = CoreM.coreName;
        Cor.corePower = CoreM.corePower;
        Cor.coreRank = CoreM.coreRank;
        Cor.dark = CoreM.dark;
        Cor.DEX = CoreM.DEX;
        Cor.DEXOri = CoreM.DEXOri;
        Cor.fire = CoreM.fire;
        Cor.ice = CoreM.ice;
        Cor.INT = CoreM.INT;
        Cor.INTOri = CoreM.INTOri;
        Cor.IsItDescOnly = CoreM.IsItDescOnly;
        Cor.IsItEquipped = CoreM.IsItEquipped;
        Cor.IsThisDesc = CoreM.IsThisDesc;
        Cor.light = CoreM.light;
        Cor.LUK = CoreM.LUK;
        Cor.LUKOri = CoreM.LUKOri;
        Cor.OriginalcorePower = CoreM.OriginalcorePower;
        Cor.Originaldark = CoreM.Originaldark;
        Cor.Originalfire = CoreM.Originalfire;
        Cor.Originalice = CoreM.Originalice;
        Cor.Originallight = CoreM.Originallight;
        Cor.price = CoreM.price;
        Cor.priceToUpgrade = CoreM.priceToUpgrade;
        Cor.STR = CoreM.STR;
        Cor.STROri = CoreM.STROri;

        return Cor;
    }

    public CoreModified CoreSetM(Core CorO)
    {
        CoreModified CoreM = new CoreModified();

        CoreM.CoreDescription = CorO.CoreDescription;
        CoreM.coreID = CorO.coreID;
        CoreM.coreLevel = CorO.coreLevel;
        CoreM.coreName = CorO.coreName;
        CoreM.corePower = CorO.corePower;
        CoreM.coreRank = CorO.coreRank;
        CoreM.dark = CorO.dark;
        CoreM.DEX = CorO.DEX;
        CoreM.DEXOri = CorO.DEXOri;
        CoreM.fire = CorO.fire;
        CoreM.ice = CorO.ice;
        CoreM.INT = CorO.INT;
        CoreM.INTOri = CorO.INTOri;
        CoreM.IsItDescOnly = CorO.IsItDescOnly;
        CoreM.IsItEquipped = CorO.IsItEquipped;
        CoreM.IsThisDesc = CorO.IsThisDesc;
        CoreM.light = CorO.light;
        CoreM.LUK = CorO.LUK;
        CoreM.LUKOri = CorO.LUKOri;
        CoreM.OriginalcorePower = CorO.OriginalcorePower;
        CoreM.Originaldark = CorO.Originaldark;
        CoreM.Originalfire = CorO.Originalfire;
        CoreM.Originalice = CorO.Originalice;
        CoreM.Originallight = CorO.Originallight;
        CoreM.price = CorO.price;
        CoreM.priceToUpgrade = CorO.priceToUpgrade;
        CoreM.STR = CorO.STR;
        CoreM.STROri = CorO.STROri;

        return CoreM;
    }


}
