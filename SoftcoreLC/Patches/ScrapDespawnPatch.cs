using HarmonyLib;

namespace SoftcoreLC.Patches
{
    [HarmonyPatch(typeof(RoundManager), "DespawnPropsAtEndOfRound")]
    public class ScrapDespawnPatch
    {
        private static void Prefix()
        {
            Plugin.AllPlayersDead = StartOfRound.Instance.allPlayersDead;
        }
    }
}
