using R2API;
using RoR2;
using System;
using UnityEngine;

namespace SongstressPlugin
{
    internal class SongstressSurvivor
    {
        internal static GameObject magePrefab;
        internal static GameObject bodyPrefab;
        internal static GameObject displayPrefab;

        internal static void Init()
        {
            SetupPrefab();
            SetupTokens();
            RegisterSurvivor();
        }

        private static void SetupPrefab()
        {
            magePrefab = Resources.Load<GameObject>("prefabs/characterbodies/MageBody");
            //bodyPrefab = PrefabAPI.InstantiateClone(magePrefab, "Songstress");
            bodyPrefab = magePrefab; //Use this until a proper model is created
            displayPrefab = bodyPrefab;
        }

        private static void SetupTokens()
        {
            LanguageAPI.Add("SONGSTRESS_NAME", "Songstress");
            string desc = "The Songstress is a hybrid support character who excels in fighting large groups and buffing their team."
                        + ColorMaster.DescGreyString
                        + Environment.NewLine + Environment.NewLine
                        + "< ! > Something about Star Power/In-Tune."
                        + Environment.NewLine + Environment.NewLine
                        + "< ! > Something about basic abilities that make spacing."
                        + Environment.NewLine + Environment.NewLine
                        + "< ! > Something about Utility that debuffs nearby enemies/buffs nearby allies."
                        + Environment.NewLine + Environment.NewLine
                        + "< ! > Something about special that consumes Star Power/In-Tune to provide major buff."
                        + Environment.NewLine + Environment.NewLine
                        + ColorMaster.EndString;
            LanguageAPI.Add("SONGSTRESS_DESC", desc);
        }

        private static void RegisterSurvivor()
        {
            SurvivorDef survivorDef = new SurvivorDef
            {
                name = "SONGSTRESS_NAME",
                descriptionToken = "SONGSTRESS_DESC",
                bodyPrefab = bodyPrefab,
                displayPrefab = displayPrefab,
                primaryColor = ColorMaster.ZeroColor,
                unlockableName = ""
            };
            SurvivorAPI.AddSurvivor(survivorDef);
        }
    }
}