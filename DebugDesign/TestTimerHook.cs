using RoR2;
using UnityEngine;

namespace SongstressPlugin
{
    class TestTimerHook
    {
        //Looking at Aatrox, there's an InvokeRepeating to drain, maybe look at that
        private static float runningTimer = 0f, timeSinceUpdate = 0f;
        internal static void Init()
        {
            On.RoR2.Run.FixedUpdate += Run_FixedUpdate;
        }

        private static void Run_FixedUpdate(On.RoR2.Run.orig_FixedUpdate orig, RoR2.Run self)
        {
            orig(self);
            runningTimer += Time.deltaTime;
            timeSinceUpdate += Time.deltaTime;
            if(timeSinceUpdate >= 5f)
            {
                timeSinceUpdate = 0f;
                Chat.AddMessage("It's been " + runningTimer.ToString("F4") + " seconds.");
            }
        }
    }
}
