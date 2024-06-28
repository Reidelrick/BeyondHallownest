using System;
using System.Collections;
using UObject = UnityEngine.Object;
using Modding;
using Satchel;
using SFCore;
using System.Collections.Generic;
using UnityEngine;

namespace BeyondHallownest
{
    public class settings {
        public Dictionary<string,EasyCharmState> Charms;
    }
    public class BeyondHallownest : Mod
    {
        internal static BeyondHallownest Instance;
        internal settings localSettings = new settings();
        internal Dictionary<string, EasyCharm> Charms = new Dictionary<string, EasyCharm>{
            {"AntBlade",new AntBlade()},
            {"ShinyRock",new ShinyRock()},
            {"SandwormMandibule",new SandwormMandibule()},
            {"SharkTooth",new SharkTooth()},
            {"RadiantMask",new RadiantMask()},
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
                Log("Giving Charms");
                Charms["AntBlade"].GiveCharm(true);
                Charms["ShinyRock"].GiveCharm(true);
                Charms["SandwormMandibule"].GiveCharm(true);
                Charms["SharkTooth"].GiveCharm(true);
                Charms["RadiantMask"].GiveCharm(true);
            }
        }
        internal static void UpdateNailDamage()
        {
            static IEnumerator WaitThenUpdate()
            {
                yield return null;
                PlayMakerFSM.BroadcastEvent("UPDATE NAIL DAMAGE");
            }
            GameManager.instance.StartCoroutine(WaitThenUpdate());
        }
    }
}