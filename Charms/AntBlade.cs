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
        protected override string GetDescription() => "An amalgam of metal and unidentifyable body parts.\n\nMakes your parries stagger, and makes you deal increased damaged to staggered enemies.";
        protected override int GetCharmCost() => 2;
        protected override Sprite GetSpriteInternal()=> AssemblyUtils.GetSpriteFromResources("assets/AntBlade.png");

        public void Hook()
        {
            ModHooks.GetPlayerIntHook += BuffNail;
            ModHooks.SetPlayerBoolHook += UpdateNailDamageOnEquip;
        }

        private int BuffNail(string intName, int damage)
        {
            if (intName == "nailDamage" && IsEquipped)
            {
                damage *= 100;
            }
            return damage;
        }

        private bool UpdateNailDamageOnEquip(string boolName, bool value)
        {
            if (IsEquipped)
            {
                BeyondHallownest.UpdateNailDamage();
            }
            return value;
        }
    }
}