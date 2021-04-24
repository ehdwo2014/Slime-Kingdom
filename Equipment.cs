using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Equipment
{
    public int EquipmentID;
    public string EquipmentName ="";
    public string EquipmentRank ="";
    public string Description = "";
    public Sprite EquipmentImage;
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


    public void EQRESET(Equipment EQ)
    {
        EQ = new Equipment();
    }

}
