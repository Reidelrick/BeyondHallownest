using Modding;
using Satchel;
using SFCore;
using System.Collections.Generic;
using UnityEngine;

namespace BeyondHallownest
{
    public class SandwormMandibule : EasyCharm
    {
        protected override string GetName() => "Sandworm Mandibule";
        protected override string GetDescription() => "Makes your nail do something... maybe";
        protected override int GetCharmCost() => 2;
        protected override Sprite GetSpriteInternal()=> AssemblyUtils.GetSpriteFromResources("SandwormMandibule.png");
    }
}