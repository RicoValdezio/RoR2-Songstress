using BepInEx;
using R2API.Utils;

namespace SongstressPlugin
{
    [BepInDependency("com.bepis.r2api", BepInDependency.DependencyFlags.HardDependency)]
    [R2APISubmoduleDependency(new string[] { "ItemAPI", "ItemDropAPI", "ResourcesAPI", "LanguageAPI", "SurvivorAPI", "LoadoutAPI" })]
    [BepInPlugin(modGuid, modName, modVer)]
    public sealed class SongstressPlugin : BaseUnityPlugin
    {
        private const string modName = "Songstress";
        private const string modGuid = "com.RicoValdezio." + modName;
        private const string modVer = "0.0.1";
        internal static SongstressPlugin Instance;

        private void Awake()
        {
            if (Instance == null) Instance = this;
            ColorLibrary.Init();
            Songstress.Init();
        }
    }
}
