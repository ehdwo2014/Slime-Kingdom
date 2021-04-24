using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class ItemRefactorizing
{
    public static float ElementFactor = 0.2f;
    public static float PriceToUpFactor = 300;
    public static float PriceUpAlpha = 50;
    public static float priceAlphaEQ = 150;
    
    public static Core ChangingCore(Core core)
    {
        core.fire = Mathf.Round(core.Originalfire + core.Originalfire * ElementFactor * (core.coreLevel * core.coreLevel));
        core.ice = Mathf.Round(core.Originalice + core.Originalice * ElementFactor * (core.coreLevel * core.coreLevel));
        core.light = Mathf.Round(core.Originallight + core.Originallight * ElementFactor * (core.coreLevel *core.coreLevel));
        core.dark = Mathf.Round(core.Originaldark + core.Originaldark * ElementFactor * (core.coreLevel * core.coreLevel));
        core.STR = core.STROri + core.STROri * core.coreLevel * core.coreLevel * 0.2f;
        core.DEX = core.DEXOri + core.DEXOri * core.coreLevel * core.coreLevel * 0.2f;
        core.INT = core.INTOri + core.INTOri * core.coreLevel * core.coreLevel * 0.2f;
        core.LUK = core.LUKOri + core.LUKOri * core.coreLevel * core.coreLevel * 0.2f;


        core.corePower = core.fire + core.ice + core.light + core.dark + core.STR + core.DEX + core.INT + core.LUK;
        core.OriginalcorePower = core.Originalfire + core.Originalice + core.Originallight + core.Originaldark + core.STROri + core.INTOri + core.LUKOri + core.DEXOri;
        core.priceToUpgrade = core.corePower * PriceUpAlpha * Mathf.Pow(core.coreLevel+1, 2);
        core.price = System.Convert.ToInt64(Mathf.RoundToInt(core.priceToUpgrade / 5));


        return core;
    }

    public static Equipment ChaningEQ(Equipment eq)
    {
        eq.fire = Mathf.Round(eq.originalfire + eq.originalfire * ElementFactor * (eq.EqLevel * eq.EqLevel));
        eq.ice = Mathf.Round(eq.originalice + eq.originalice * ElementFactor * (eq.EqLevel * eq.EqLevel));
        eq.light = Mathf.Round(eq.originallight + eq.originallight * ElementFactor * (eq.EqLevel * eq.EqLevel));
        eq.dark = Mathf.Round(eq.originaldark + eq.originaldark * ElementFactor * (eq.EqLevel * eq.EqLevel));

        eq.PhysicalAttack = eq.PhysicalAttackOrigin + (eq.PhysicalAttackOrigin * eq.EqLevel * 0.2f)   + eq.PhysicalAttackOrigin * (eq.EqLevel * eq.EqLevel) * 0.05f;
        eq.MagicalAttack = eq.MagicalAttackOrigin + (eq.MagicalAttackOrigin * eq.EqLevel * 0.2f)+ eq.MagicalAttackOrigin * (eq.EqLevel * eq.EqLevel) * 0.05f;

        eq.PriceToUpgrade = Mathf.RoundToInt(Mathf.Pow(eq.EqLevel + 1, 2) * ((eq.fire + eq.ice + eq.light+eq.dark) + eq.PhysicalAttack + eq.MagicalAttack) * priceAlphaEQ);


        return eq;
    }



    public static float RankToNumber(string Rank)
    {

        if (Rank.Equals("D"))
        {
            return 1;
        }
        if (Rank.Equals("C"))
        {
            return 2;
        }
        if(Rank.Equals("B"))
        {
            return 3;
        }
        if(Rank.Equals("A"))
        {
            return 5;
        }
        if(Rank.Equals("S"))
        {
            return 10;
        }

        else return 1;
    }


}
