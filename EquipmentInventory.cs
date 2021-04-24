using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class EquipmentInventory : MonoBehaviour
{
    public List<Equipment> eqs = new List<Equipment>();
    public delegate void OnChangeEquipment();
    public OnChangeEquipment onChangeEquipment;
    public Equipment TempEq;
    public bool IsThisInventoryForUser;
    public bool AddEq(Equipment _eq)
    {
        if (FindEmptyFirstIndex() == -1)
        {
            return false;
        }
        eqs[FindEmptyFirstIndex()] = DeepCopyEQ(_eq);
        return true;
    }

    public int FindEmptyFirstIndex()
    {
        for (int i = 0; i < eqs.Count; i++)
        {
            if (eqs[i].EquipmentID == 0)
            {
                return i;

            }
        }
        return -1;
    }

    void Update()
    {
        for (int i = 0; i < eqs.Count; i++)
        {
           
            if (IsThisInventoryForUser == true)
            {
                eqs[i].IsThisDesc = false;
            }

        }
    }
    void Start()
    {

    }




    public Equipment ReturnIndexEquipment(int Index)
    {

        return eqs[Index];

    }
    public int ReturnLength()
    {
        return eqs.Count;
    }
    public void EquipmentSort(int Index1, int Index2)
    {
        TempEq = eqs[Index1];
        eqs[Index1] = eqs[Index2];
        eqs[Index2] = TempEq;
    }

    public Equipment DeepCopyEQ(Equipment EQ)
    {
        Equipment NEWEQ = new Equipment();
        NEWEQ.EquipmentID = EQ.EquipmentID;
        NEWEQ.EqLevel = EQ.EqLevel;
        NEWEQ.AttackPoint = EQ.AttackPoint;
        NEWEQ.CriticalPoint = EQ.CriticalPoint;
        NEWEQ.dark = EQ.dark;
        NEWEQ.Description = EQ.Description;
        NEWEQ.EquipmentImage = EQ.EquipmentImage;
        NEWEQ.fire = EQ.fire;
        NEWEQ.EquipmentName = EQ.EquipmentName;
        NEWEQ.EquipmentRank = EQ.EquipmentRank;
        NEWEQ.ice = EQ.ice;
        NEWEQ.light = EQ.light;
        NEWEQ.MagicalAttack = EQ.MagicalAttack;
        NEWEQ.MagicalAttackOrigin = EQ.MagicalAttackOrigin;
        NEWEQ.MovementSpeed = EQ.MovementSpeed;
        NEWEQ.originaldark = EQ.originaldark;
        NEWEQ.originalfire = EQ.originalfire;
        NEWEQ.originalice = EQ.originalice;
        NEWEQ.originallight = EQ.originallight;
        NEWEQ.PhysicalAttack = EQ.PhysicalAttack;
        NEWEQ.PhysicalAttackOrigin = EQ.PhysicalAttackOrigin;
        NEWEQ.Price = EQ.Price;
        NEWEQ.PriceToUpgrade = EQ.PriceToUpgrade;
        NEWEQ.typeOfAttack = EQ.typeOfAttack;
        NEWEQ.typeOfEQ = EQ.typeOfEQ;
        NEWEQ.WorkingPoint = EQ.WorkingPoint;

        return NEWEQ;
    }


}
