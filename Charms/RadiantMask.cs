using Modding;
using Satchel;
using SFCore;
using System.Collections.Generic;
using UnityEngine;

namespace BeyondHallownest
{
    public class RadiantMask : EasyCharm
    {
        protected override string GetName() => "Radiant Mask";
        protected override string GetDescription() => "
        A magnificent mask made by the alliance of two true masters.\n\n
        Allows you to survive in the extrem sun of the outer kingdom, \n\n
        but at the cost of being forced to overcharm.";
        protected override int GetCharmCost() => 21;
        protected override Sprite GetSpriteInternal()=> AssemblyUtils.GetSpriteFromResources("RadiantMask.png");
    }
}