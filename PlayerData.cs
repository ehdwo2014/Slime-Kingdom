using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerData
{
    public int StageLevel;
    public long Money;
    public int Dia;
    public int NumberOfSlime;
    public List<MaterialModified> Material;
    public List<EquipmentModified> Equipment;
    public List<CoreModified> Core;
    public List<PositionOfSlimes> PositionsOfSlime;

    public List<EquipmentModified> SlimeWeapon;
    public List<EquipmentModified> SlimeAura;
    public List<EquipmentModified> SlimeAcc;
    public List<CoreModified> SlimeCore;
    public List<SlimeStateModified> SlimeStates;
    public List<SlimeOtherState> SLimeOtherStates;

    public List<SkillLevels> LevelOfSkills;
    public List<GateLevels> LevelOfGates;


}


[System.Serializable]
public class PositionOfSlimes
{
    public float x, y, z;
}
[System.Serializable]
public class SkillLevels
{
    public int Level;
}
[System.Serializable]
public class GateLevels
{
    public int Level;
}




[System.Serializable]
public class MaterialModified
{
    public int MaterialID;
    public int Amount;
}

[System.Serializable]
public class EquipmentModified
{
    public int EquipmentID;
    public string EquipmentName = "";
    public string EquipmentRank = "";
    public string Description = "";
    public int EqLevel;
    public float PhysicalAttackOrigin;
    public float MagicalAttackOrigin;
    public float originalfire;
    public float originalice;
    public float originallight;
    public float originaldark;
    public string typeOfEQ = "";
    public string typeOfAttack = "";
    public float CriticalPoint;
    public float WorkingPoint;
    public float MovementSpeed;
    public long Price;
    public float AttackPoint;
    public float PhysicalAttack;
    public float MagicalAttack;
    public float fire;
    public float ice;
    public float light;
    public float dark;
    public bool IsItEquipped;
    public int EQPositionIndex = -1;
    public long PriceToUpgrade;
    public bool IsItDescOnly = true;
    public bool IsThisDesc = true;

}

[System.Serializable]
public class CoreModified
{
    public int coreID;
    public string coreName;
    public string coreRank;
    public string CoreDescription;
    public int coreLevel;
    public float corePower;
    public float OriginalcorePower;
    public float fire;
    public float ice;
    public float light;
    public float dark;
    public long price;
    public float Originalfire;
    public float Originalice;
    public float Originallight;
    public float Originaldark;
    public bool IsItEquipped;
    public float STROri;
    public float INTOri;
    public float DEXOri;
    public float LUKOri;
    public float STR;
    public float INT;
    public float DEX;
    public float LUK;
    public float priceToUpgrade;
    public bool IsItDescOnly = true;
    public bool IsThisDesc = true;
}

[System.Serializable]
public class SlimeStateModified
{
    public string SlimeName;
    public string SlimeRank;
    public int SlimeTypeID;
    public int SlimeID;
    public bool SlimeEggMode;
    public string AttackType;
    public float SlimeSpecialAbility;
    public float AttackPoint;
    public float PhysicalATK;
    public float MagicalATK;
    public float MiningAbility;
    public float Fire;
    public float Ice;
    public float Light;
    public float Dark;
    public int Level = 1;
    public float MovementSpeed;
    public int SlimePlaceIndex = -1;
    public float STR;
    public float INT;
    public float DEX;
    public float LUK;
    public float CriticalPoint;
    public long PriceToLevelUP;
    public bool Sprafe;
    public bool ManaAmple;
    public bool Strengthening;
    public float AttackSpeedOriginal;
    public float AttackSpeed;
    public float AtimeNow;
    public float AtimeNeed;
    public float AttackSpeedNow;
    public float WorkTimeNow;
    public float WorkTimeNeed;
    public float WorkSpeedNow;
    public float WorkSpeedOriginal;
    public float WorkSpeed;
    public bool WorkDone;
    public bool AttackReady;
    public float INTBuff;
    public float STRBuff;
}

[System.Serializable]
public class SlimeOtherState
{
    public int AuraIndex;
    public bool AuraEquipped;
    public int WorkIndex;
}