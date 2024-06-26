using Modding;
using Satchel;
using SFCore;
using System.Collections.Generic;
using UnityEngine;

namespace BeyondHallownest
{
    public class AntBlade : EasyCharm
    {
        protected override int get_charm_cost() => 2;
        protected override string GetDescription() => "Makes your nail do something... maybe";
        protected override string GetName() => "Ant Blade";
        protected override Sprite GetSpriteInternal()=> AssemblyUtils.GetSpriteFromResources("assets/AntBlade.png");
    }
    public class settings {
        public Dictionary<string,EasyCharmState> Charms; 
    }
    public class EasyCharmTest : Mod, ILocalSettings<settings>
    {
        internal static EasyCharmTest Instance;
        internal settings localSettings = new settings();
        internal Dictionary<string, EasyCharm> Charms = new Dictionary<string, EasyCharm>{ 
            {"AntBlade",new AntBlade()},
        };
        public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects)
        {
            Log("Initializing");
            Instance = this;
            Log("Initialized");
            On.HeroController.Update += HeroController_Update;
        }
        private void HeroController_Update(On.HeroController.orig_Update orig, HeroController self)
        {
            orig(self);
            if(Charms["AntBlade"].GotCharm && Charms["AntBlade"].IsEquipped)
            {
                Log("Dandy");
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                Log("Giving AntBlade");
                Charms["AntBlade"].GiveCharm(true);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                Log("Taking AntBlade");
                Charms["AntBlade"].TakeCharm();
            }
        }
    }
}