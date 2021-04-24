using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StageCurrent : MonoBehaviour
{
    
    public static float TimeConst = 23f;
    public static float NowTime = 0f;
    public static bool IsItFighting = false;
    public static bool IsThereAnyMonsterLeft = false;
    public GameObject ButtonBattle;
    public GameObject ButtonGiveUp;
    public GameObject DatabasePlayer;
    public GameObject GateWay;
    public GameObject Victorys;
    public GameObject Defeats;
    public List <GameObject> GateOfSlimes;
    public List<GameObject> GateOfSmallOnes;
    public static bool CreateMonsterSwit = false;
    public GameObject EnemyParent;
    public static int MaximumAmountOfMonster = 80;
    public System.Random r = new System.Random();
    private int PlusMinus;
    public int IndexGene;
    public List<int> ThresholdAppearMonster;
    public GameObject SlimeInv;
    public bool IsItBossRaid;

    public bool IsBossCreated;
    public GameObject BossDBS;
    public GameObject BossIndexCaller;
    public GameObject BossRegenPos;
    public GameObject BosPosDB;
    public List<float> BossPosition;
    float BosPosY = 40;
 


    // Start is called before the first frame update
    void Start()
    {
        IndexGene = GateOfSlimes.Count;
        BossPosition = BosPosDB.GetComponent<PositionDBBoss>().PositionXBos;
    }

    // Update is called once per frame
    void Update()
    {

        if(IsItFighting == false)
        {
            GateWay.GetComponent<GateWayHP>().GateWayHPNow = GateWay.GetComponent<GateWayHP>().GateWayHpMax;
            GateWay.GetComponent<GateWayHP>().GateWayMPNow = GateWay.GetComponent<GateWayHP>().GateWayMPMax;


            ButtonBattle.SetActive(true);
            ButtonGiveUp.SetActive(false);
            for(int i =0; i<25; i++)
            {
                if(SlimeInv.GetComponent<SlimeInventoryCopy>().SlimeList1[i] != null)
                {
                    SlimeInv.GetComponent<SlimeInventoryCopy>().SlimeList1[i].GetComponent<SlimeState>().slimeState.Sprafe = false;
                }

            }


        }

        else if(IsItFighting && IsItBossRaid == false)
        {
            ButtonGiveUp.SetActive(true);
            if(ButtonBattle.activeSelf == true)
            {
                ButtonBattle.SetActive(false);
            }

            if(CreateMonsterSwit == true)
            {
                for(int i=0; i< GateOfSlimes.Count; i++)
                {
                    GateOfSlimes[i].GetComponent<GateOfEnemy>().InitiateGate();
                }

                RegenAmountForMonster();
                CreateMonsterSwit = false;
            }


            NowTime += Time.deltaTime;
            if (NowTime > TimeConst && IsThereAnyMonsterLeft == false)
            {
                IsItFighting = false;
                Victorys.gameObject.SetActive(true);
                Victorys.GetComponent<TransFormStageVictory>().ActTheText();
                Invoke("SetFalseIsF", 1.5f);

            }

            if(GateWay.GetComponent<GateWayHP>().GateWayHPNow <= 0)
            {
                IsItFighting = false;
                Defeats.gameObject.SetActive(true);
                Defeats.GetComponent<TransFormStageDefeat>().ActTheText();
                Invoke("SetFalseIsDEF", 1.5f);                
            }

        }

        else if (IsItFighting && IsItBossRaid == true)
        {
            ButtonGiveUp.SetActive(true);
            NowTime += Time.deltaTime;

            if (IsBossCreated == false)
            {
                if (RaidConfirm.BossIndexReal != -1)
                {
                    CreateBossMonster(RaidConfirm.BossIndexReal);
                    //HereMonsterNormal
                    RegenAmountForMonster(RaidConfirm.BossIndexReal);
                    
                }
            }

            if (ButtonBattle.activeSelf == true)
            {
                ButtonBattle.SetActive(false);
            }

            if (IsThereAnyMonsterLeft == false && NowTime > 3)
            {
                RaidConfirm.BossIndexReal = -1;
                IsItFighting = false;
                Victorys.gameObject.SetActive(true);
                Victorys.GetComponent<TransFormStageVictory>().ActTheText();
                Invoke("SetFalseIsRaid", 1.5f);

            }

            if (GateWay.GetComponent<GateWayHP>().GateWayHPNow <= 0)
            {
                RaidConfirm.BossIndexReal = -1;
                IsItFighting = false;
                Defeats.gameObject.SetActive(true);
                Defeats.GetComponent<TransFormStageDefeat>().ActTheText();
                Invoke("SetFalseIsRaid", 1.5f);
            }

        }








    }

    public void SetFalseIsF()
    {
        NowTime = 0;
        GateWay.GetComponent<GateWayHP>().GateWayHPNow = GateWay.GetComponent<GateWayHP>().GateWayHpMax;
        PlayerInfor.Stage += 1;
        ButtonStartBattle.Clickable = true;
    }

    public void SetFalseIsRaid()
    {
        int childs = EnemyParent.transform.childCount;
        for (int i = 0; i < childs; i++)
        {
            Destroy(EnemyParent.transform.GetChild(i).gameObject);
        }
        NowTime = 0;
        GateWay.GetComponent<GateWayHP>().GateWayHPNow = GateWay.GetComponent<GateWayHP>().GateWayHpMax;
        ButtonStartBattle.Clickable = true;
        IsBossCreated = false;
        IsItBossRaid = false;

    }



    public void SetFalseIsDEF()
    {
        NowTime = 0;
        GateWay.GetComponent<GateWayHP>().GateWayHPNow = GateWay.GetComponent<GateWayHP>().GateWayHpMax;
        
        ButtonStartBattle.Clickable = true;

        int childs = EnemyParent.transform.childCount;
        for (int i = 0 ; i < childs; i++)
        {
            Destroy(EnemyParent.transform.GetChild(i).gameObject);
        }

    }

    public void RegenAmountForMonster()
    {


        MaximumAmountOfMonster = PlayerInfor.Stage * 2 + 8;
        if(MaximumAmountOfMonster > 80)
        {
            MaximumAmountOfMonster = 80;
        }

        for (int i = 0; i < MaximumAmountOfMonster; i++)
        {
            IndexGene = ProbAdJustIndexGene();
            GateOfSlimes[IndexGene].GetComponent<GateOfEnemy>().RandomGenerate(1);
        }


    }

    public void RegenAmountForMonster(int bossIndex)
    {


        MaximumAmountOfMonster = 80;
        if (MaximumAmountOfMonster > 80)
        {
            MaximumAmountOfMonster = 80;
        }

        if (GateOfSmallOnes[bossIndex] != null)
        {
            for (int i = 0; i < MaximumAmountOfMonster; i++)
            {
                GateOfSmallOnes[bossIndex].GetComponent<GateOfEnemy>().RandomGenerate(1);
            }
        }

    }



    public int ProbAdJustIndexGene()
    {
        if (PlayerInfor.Stage < ThresholdAppearMonster[0])
        {
            return 0;
        }
        else if (PlayerInfor.Stage >= ThresholdAppearMonster[0] && PlayerInfor.Stage < ThresholdAppearMonster[1])
        {
            return r.Next(0, 1);
        }
        else if (PlayerInfor.Stage >= ThresholdAppearMonster[1] && PlayerInfor.Stage < ThresholdAppearMonster[2])
        {
            return r.Next(0, 2);
        }
        else if (PlayerInfor.Stage >= ThresholdAppearMonster[2] && PlayerInfor.Stage < ThresholdAppearMonster[3])
        {
            return r.Next(0, 3);
        }
        else if (PlayerInfor.Stage >= ThresholdAppearMonster[3] && PlayerInfor.Stage < ThresholdAppearMonster[4])
        {
            return r.Next(0, 4);
        }
        else if (PlayerInfor.Stage >= ThresholdAppearMonster[4] && PlayerInfor.Stage < ThresholdAppearMonster[5])
        {
            return r.Next(0, 5);
        }
        else if (PlayerInfor.Stage >= ThresholdAppearMonster[5] && PlayerInfor.Stage < ThresholdAppearMonster[6])
        {
            return r.Next(0, 6);
        }
        else if (PlayerInfor.Stage >= ThresholdAppearMonster[6] && PlayerInfor.Stage < ThresholdAppearMonster[7])
        {
            return r.Next(0, 7);
        }
        else if (PlayerInfor.Stage >= ThresholdAppearMonster[7] && PlayerInfor.Stage < ThresholdAppearMonster[8])
        {
            return r.Next(0, 8);
        }
        else if (PlayerInfor.Stage >= ThresholdAppearMonster[8] && PlayerInfor.Stage < ThresholdAppearMonster[9])
        {
            return r.Next(0, 9);
        }

        else if (PlayerInfor.Stage >= ThresholdAppearMonster[9] && PlayerInfor.Stage < ThresholdAppearMonster[10])
        {
            return r.Next(0, 10);
        }


        else return r.Next (0, GateOfSlimes.Count);
    }

    public void CreateBossMonster(int IndexBoss)
    {
        Instantiate(BossDBS.GetComponent<BossDB>().Bosses[IndexBoss], new Vector3(BosPosY, BossPosition[IndexBoss], 0), new Quaternion(), EnemyParent.transform);
        IsBossCreated = true;

    }


    public void GiveUp()

    {

        GateWay.GetComponent<GateWayHP>().GateWayHPNow = 0;
    }

}
