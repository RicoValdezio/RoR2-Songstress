using R2API;
using RoR2;
using UnityEngine;

namespace Songstress_Plugin
{
    internal class CharmBuff
    {
        internal static BuffIndex buffIndex;

        internal static void Init()
        {
            BuffDef buffDef = new BuffDef
            {
                name = "Charmed",
                iconPath = null,
                buffColor = new Color(),
                canStack = false,
                isDebuff = false,
                eliteIndex = EliteIndex.None
            };

            buffIndex = BuffAPI.Add(new CustomBuff(buffDef));

            On.RoR2.CharacterBody.AddBuff += CharacterBody_AddCharmBuff;
            On.RoR2.CharacterBody.RemoveBuff += CharacterBody_RemoveCharmBuff;
        }

        private static void CharacterBody_AddCharmBuff(On.RoR2.CharacterBody.orig_AddBuff orig, CharacterBody self, BuffIndex buffType)
        {
            orig(self, buffType);
            if (buffType == buffIndex)
            {

            }
        }

        private static void CharacterBody_RemoveCharmBuff(On.RoR2.CharacterBody.orig_RemoveBuff orig, CharacterBody self, BuffIndex buffType)
        {
            orig(self, buffType);
            if (buffType == buffIndex)
            {

            }
        }
    }
}