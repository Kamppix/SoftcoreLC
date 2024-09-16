using HarmonyLib;

namespace SoftcoreLC.Patches
{
    [HarmonyPatch(typeof(StartOfRound), "SetTimeAndPlanetToSavedSettings")]
    public class LoadSavePatch
    {
        private static void Prefix()
        {
            Plugin.AllPlayersDead = false;
        }
    }
}
