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
    public class ShinyRock : EasyCharm
    {
        protected override string GetName() => "Shiny Rock";
        protected override string GetDescription() => "Makes your nail do something... maybe";
        protected override int GetCharmCost() => 1;
        protected override Sprite GetSpriteInternal()=> AssemblyUtils.GetSpriteFromResources("ShinyRock.png");
    }
    public class SandwormMandibule : EasyCharm
    {
        protected override string GetName() => "Sandworm Mandibule";
        protected override string GetDescription() => "Makes your nail do something... maybe";
        protected override int GetCharmCost() => 2;
        protected override Sprite GetSpriteInternal()=> AssemblyUtils.GetSpriteFromResources("SandwormMandibule.png");
    }
    public class SharkTooth : EasyCharm
    {
        protected override string GetName() => "Shark Tooth";
        protected override string GetDescription() => "Makes your nail do something... maybe";
        protected override int GetCharmCost() => 2;
        protected override Sprite GetSpriteInternal()=> AssemblyUtils.GetSpriteFromResources("SharkTooth.png");
    }
    public class RadiantMask : EasyCharm
    {
        protected override string GetName() => "Radiant Mask";
        protected override string GetDescription() => "Makes your nail do something... maybe";
        protected override int GetCharmCost() => 12;
        protected override Sprite GetSpriteInternal()=> AssemblyUtils.GetSpriteFromResources("RadiantMask.png");
    }
}