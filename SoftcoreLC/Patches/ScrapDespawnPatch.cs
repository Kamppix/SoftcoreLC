using HarmonyLib;
using SoftcoreLC;

namespace ApparatusRetrieval.Patches
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
