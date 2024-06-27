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
        protected override string GetDescription() => "
        The mandibule of a dried wyrm.\n\n
        Your spells deal minimal damage, but blinds enemies.";
        protected override int GetCharmCost() => 2;
        protected override Sprite GetSpriteInternal()=> AssemblyUtils.GetSpriteFromResources("SandwormMandibule.png");
    }
}