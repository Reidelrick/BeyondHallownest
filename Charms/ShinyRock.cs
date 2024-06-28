using Modding;
using Satchel;
using SFCore;
using System.Collections.Generic;
using UnityEngine;

namespace BeyondHallownest
{
    public class ShinyRock : EasyCharm
    {
        protected override string GetName() => "Shiny Rock";
        protected override string GetDescription() => "A shiny pebble.\n\nYou shine and your make parasites flee.";
        protected override int GetCharmCost() => 1;
        protected override Sprite GetSpriteInternal()=> AssemblyUtils.GetSpriteFromResources("ShinyRock.png");
    }
}