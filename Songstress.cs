using R2API;
using RoR2;
using SongstressPlugin;
using UnityEngine;

namespace Songstress_Plugin
{
    internal class Songstress
    {
        internal static void Init()
        {
            GameObject bodyPrefab = Resources.Load<GameObject>("prefabs/characterbodies/MageBody");
            GameObject displayPrefab = Resources.Load<GameObject>("prefabs/characters/MageDisplay");
            LanguageAPI.Add("SONGSTRESS_NAME", "Songstress");
            LanguageAPI.Add("SONGSTRESS_DESC", "Something something placeholder.");

            SurvivorDef survivorDef = new SurvivorDef
            {
                name = "SONGSTRESS_NAME",
                descriptionToken = "SONGSTRESS_DESC",
                bodyPrefab = bodyPrefab,
                displayPrefab = displayPrefab,
                primaryColor = IntonerColors.ChosenColor,
                unlockableName = ""
            };
            SurvivorAPI.AddSurvivor(survivorDef);
        }
    }
}