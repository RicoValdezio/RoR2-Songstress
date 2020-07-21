using R2API;
using RoR2;
using UnityEngine;

namespace SongstressPlugin
{
    class BuffLibrary
    {
        internal static BuffIndex ChargeIndex, EncoreIndex, SoloIndex;

        public static void Init()
        {
            RegisterChargeBuff();
            RegisterEncoreBuff();
            RegisterSoloBuff();
            RegisterHooks();
        }

        private static void RegisterChargeBuff()
        {
            BuffDef def = new BuffDef
            {
                name = "SongstressCharge",
                iconPath = null,
                buffColor = ColorLibrary.ChosenColor,
                isDebuff = false,
                canStack = true,
                eliteIndex = EliteIndex.None
            };
            CustomBuff buff = new CustomBuff(def);
            ChargeIndex = BuffAPI.Add(buff);
        }

        private static void RegisterEncoreBuff()
        {
            BuffDef def = new BuffDef
            {
                name = "SongstressEncore",
                iconPath = null,
                buffColor = ColorLibrary.ChosenColor,
                isDebuff = false,
                canStack = false,
                eliteIndex = EliteIndex.None
            };
            CustomBuff buff = new CustomBuff(def);
            EncoreIndex = BuffAPI.Add(buff);
        }

        private static void RegisterSoloBuff()
        {
            BuffDef def = new BuffDef
            {
                name = "SongstressSolo",
                iconPath = null,
                buffColor = ColorLibrary.ChosenColor,
                isDebuff = false,
                canStack = false,
                eliteIndex = EliteIndex.None
            };
            CustomBuff buff = new CustomBuff(def);
            SoloIndex = BuffAPI.Add(buff);
        }

        private static void RegisterHooks()
        {
            On.RoR2.CharacterMaster.OnBodyDeath += CharacterMaster_OnBodyDeath; ;
        }

        private static void CharacterMaster_OnBodyDeath(On.RoR2.CharacterMaster.orig_OnBodyDeath orig, CharacterMaster self, CharacterBody body)
        {
            orig(self, body);
            if (self.IsDeadAndOutOfLivesServer() && body.teamComponent.teamIndex == TeamIndex.Monster)
            {
                BullseyeSearch search = new BullseyeSearch
                {
                    searchOrigin = body.corePosition,
                    teamMaskFilter = TeamMask.none,
                    filterByLoS = false,
                    sortMode = BullseyeSearch.SortMode.Distance,
                    searchDirection = Vector3.zero
                };
                search.teamMaskFilter.AddTeam(TeamIndex.Player);
                search.RefreshCandidates();
                foreach (HurtBox hurtBox in search.GetResults())
                {
                    //Chat.AddMessage("BaseNameToken: " + hurtBox.healthComponent.body.baseNameToken); //This will show the prefabName
                    if (hurtBox.healthComponent.body.baseNameToken == "MAGE_BODY_NAME") //This should reflect the prefabName
                    {
                        hurtBox.healthComponent.body.AddBuff(ChargeIndex);
                    }
                }
            }
        }
    }
}
