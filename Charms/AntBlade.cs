using Modding;
using Satchel;
using SFCore;
using System.Collections.Generic;
using UnityEngine;

namespace BeyondHallownest
{
    public class AntBlade : EasyCharm
    {
        protected override string GetName() => "Ant Blade";
        protected override string GetDescription() => "Makes your nail do something... maybe";
        protected override int GetCharmCost() => 2;
        protected override Sprite GetSpriteInternal()=> AssemblyUtils.GetSpriteFromResources("AntBlade.png");
    }
    
    public override void Hook()
    {
        ModHooks.GetPlayerIntHook += BuffNail;
        ModHooks.SetPlayerBoolHook += UpdateNailDamageOnEquip;
    }

    private int BuffNail(string intName, int damage)
    {
        if (intName == "nailDamage" && Equipped())
        {
            damage *= 2;
        }
        return damage;
    }

    private bool UpdateNailDamageOnEquip(string boolName, bool value)
    {
        if (boolName == $"equippedCharm_{Num}")
        {
            BeyondHallownest.UpdateNailDamage();
        }
        return value;
    }
}