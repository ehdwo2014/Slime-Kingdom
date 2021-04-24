using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialInventory : MonoBehaviour
{
    public List<Material> materials = new List<Material>();
    public delegate void OnChangeMaterial();
    public OnChangeMaterial onChangeMaterial;
    public Material TempMaterial;
    public bool IsThisInventoryForUser;
    public bool AddMaterial(Material _material)

    {
        if (IsThereSuchMaterial(_material.materialID))
        {
            materials[IsThereSuchMaterialReturnIndex(_material.materialID)].Amount++;
            return true;
        }

        else if (IsThereSuchMaterial(_material.materialID) == false)
        {

            if (FindEmptyFirstIndex() == -1)
            {
                return false;
            }
            _material.Amount = 1;
            materials[FindEmptyFirstIndex()] = DeepCopyMT(_material);
            _material.Amount = 0;

            return true;
        }
        return false;
    }

    public bool AddMaterialAmount(Material _material)

    {
        if (IsThereSuchMaterial(_material.materialID))
        {
            materials[IsThereSuchMaterialReturnIndex(_material.materialID)].Amount += _material.Amount;
            return true;
        }

        else if (IsThereSuchMaterial(_material.materialID) == false)
        {

            if (FindEmptyFirstIndex() == -1)
            {
                return false;
            }
            materials[FindEmptyFirstIndex()] = DeepCopyMT(_material);

            return true;
        }
        return false;
    }















    void Update()
    {
        for(int i=0; i < materials.Count; i++)
        {
            if(materials[i].Amount ==0)
            {
                materials[i].materialID = 0;
                materials[i].MaterialImage = null;
            }
            if (IsThisInventoryForUser == true)
            {
                materials[i].IsThisDesc = false;
            }
        }
    }

    void Start()
    {




    }





    public bool RemoveMaterial(Material _material, int AmountOfRe)
    {
        if (IsThereSuchMaterial(_material.materialID))
        {
            if(materials[IsThereSuchMaterialReturnIndex(_material.materialID)].Amount > AmountOfRe)
            {
                materials[IsThereSuchMaterialReturnIndex(_material.materialID)].Amount -= AmountOfRe;
                return true;
            }
            else if(materials[IsThereSuchMaterialReturnIndex(_material.materialID)].Amount == AmountOfRe)
            {
                materials[IsThereSuchMaterialReturnIndex(_material.materialID)] = new Material();
                return true;
            }
            else if(materials[IsThereSuchMaterialReturnIndex(_material.materialID)].Amount < AmountOfRe)
            {
                return false;
            }
        }

        else if (IsThereSuchMaterial(_material.materialID) == false)
        {
            return false;
        }
        return false;
    }

    public int HowManyItems(int MaterialID)
    {
        if(IsThereSuchMaterial(MaterialID) == false)
        {
            return 0;
        }
        else
        {
           return materials[IsThereSuchMaterialReturnIndex(MaterialID)].Amount;
        }
    }



    public int FindEmptyFirstIndex()
    {
        for (int i = 0; i < materials.Count; i++)
        {
            if (materials[i].materialID == 0)
            {
                return i;

            }
        }
        return -1;
    }

    public Material ReturnIndexMaterial(int Index)
    {

        return materials[Index];

    }

    public Material ReturnMaterialByID(int ID)
    {
        for (int i = 0; i < materials.Count; i++)
        {
            if (materials[i].materialID == ID)
            {
                return materials[i];
            }
        }
        return new Material();
    }



    public int ReturnLength()
    {
        return materials.Count;
    }
    public void MaterialSort(int Index1, int Index2)
    {
        TempMaterial = materials[Index1];
        materials[Index1] = materials[Index2];
        materials[Index2] = TempMaterial;
    }

    public bool IsThereSuchMaterial(int ID)
    {
        for (int i = 0; i < materials.Count; i++)
        {
            if (materials[i].materialID == ID)
            {
                return true;
            }
        }
        return false;
    }

    public int IsThereSuchMaterialReturnIndex(int ID)
    {
        for (int i = 0; i < materials.Count; i++)
        {
            if (materials[i].materialID == ID)
            {
                return i;
            }
        }
        return -1;

    }

    public Material DeepCopyMT(Material MT)
    {
        Material NEWMT = new Material();
        NEWMT.Amount = MT.Amount;
        NEWMT.Description = MT.Description;
        NEWMT.IsItForDescOnly = MT.IsItForDescOnly;
        NEWMT.materialID = MT.materialID;
        NEWMT.MaterialImage = MT.MaterialImage;
        NEWMT.MaterialName = MT.MaterialName;
        NEWMT.MaterialRank = MT.MaterialRank;
        NEWMT.Price = MT.Price;
        
        return NEWMT;
    }

}
