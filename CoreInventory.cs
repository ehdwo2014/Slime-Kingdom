using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreInventory : MonoBehaviour
{
	public List<Core> cores = new List<Core>();	
	public delegate void OnChangeCore();
	public OnChangeCore onChangeCore;
    public Core TempCore;
    public bool IsThisInventoryForUser;

	public bool AddCore(Core _core)
	{
        if (FindEmptyFirstIndex() == -1)
        {
            return false;
        }
        cores[FindEmptyFirstIndex()] = DeepCopyCore(_core);
        return true;
    }

    public int FindEmptyFirstIndex()
    {
        for(int i=0; i < cores.Count; i++)
        {
            if(cores[i].coreID==0)
            {
                return i;
                
            }
        }
        return -1;
    }

    void Update()
    {
        for (int i = 0; i < cores.Count; i++)
        {
           
            if (IsThisInventoryForUser == true)
            {
                cores[i].IsThisDesc = false;
            }
        }
    }
    void Start()
    {

    }




    public Core ReturnIndexCore(int Index)
    {
       
            return cores[Index];
       
    }
    public int ReturnLength()
    {
        return cores.Count; 
    }
    public void CoreSort(int Index1, int Index2)
    {
        TempCore = cores[Index1];
        cores[Index1] = cores[Index2];
        cores[Index2] = TempCore;
    }


    public Core DeepCopyCore(Core CORE)
    {
        Core NEWCO = new Core();
        NEWCO.coreID = CORE.coreID;
        NEWCO.CoreDescription = CORE.CoreDescription;
        NEWCO.coreLevel = CORE.coreLevel;
        NEWCO.coreName = CORE.coreName;
        NEWCO.corePower = CORE.corePower;
        NEWCO.coreRank = CORE.coreRank;
        NEWCO.dark = CORE.dark;
        NEWCO.DEX = CORE.DEX;
        NEWCO.DEXOri = CORE.DEXOri;
        NEWCO.fire = CORE.fire;
        NEWCO.ice = CORE.ice;
        NEWCO.INT = CORE.INT;
        NEWCO.INTOri = CORE.INTOri;
        NEWCO.itemImage = CORE.itemImage;
        NEWCO.light = CORE.light;
        NEWCO.LUK = CORE.LUK;
        NEWCO.LUKOri = CORE.LUKOri;
        NEWCO.OriginalcorePower = CORE.OriginalcorePower;
        NEWCO.Originaldark = CORE.Originaldark;
        NEWCO.Originalfire = CORE.Originalfire;
        NEWCO.Originalice = CORE.Originalice;
        NEWCO.Originallight = CORE.Originallight;
        NEWCO.price = CORE.price;
        NEWCO.priceToUpgrade = CORE.priceToUpgrade;
        NEWCO.STR = CORE.STR;
        NEWCO.STROri = CORE.STROri;
        
        return NEWCO;
    }


}

    

