using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Slime
{
    public string SlimeName;
    public string SlimeRank;
    public int SlimeTypeID;
    public int SlimeID;
    public Sprite SlimeSprite;
    public Sprite SlimeSkill;
    public bool  SlimeEggMode;
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
    public Equipment Weapon;
    public Equipment Accessory;
    public Equipment Aura;
    public Core UsedCore;
}
