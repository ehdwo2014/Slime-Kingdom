using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Material
{
    public int materialID;
    public int Amount;
    public string MaterialRank;
    public string MaterialName;
    public int Price;
    public string Description;
    public Sprite MaterialImage;
    public bool IsItForDescOnly = true;
    public bool IsThisDesc = true;
}
