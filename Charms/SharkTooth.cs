using Modding;
using Satchel;
using SFCore;
using System.Collections.Generic;
using UnityEngine;

namespace BeyondHallownest
{
    public class SharkTooth : EasyCharm
    {
        protected override string GetName() => "Shark Tooth";
        protected override string GetDescription() => "The tooth of an invincible predator.\n\nTurns you into a furious killer that toys with his preys.";
        protected override int GetCharmCost() => 2;
        protected override Sprite GetSpriteInternal()=> AssemblyUtils.GetSpriteFromResources("SharkTooth.png");
    }
}