using HarmonyLib;
using SoftcoreLC;

namespace ApparatusRetrieval.Patches
{
    [HarmonyPatch(typeof(TimeOfDay), "UpdateProfitQuotaCurrentTime")]
    public class UpdateQuotaPatch
    {
        private static void Prefix(TimeOfDay __instance)
        {
            if (!StartOfRound.Instance.isChallengeFile && Plugin.AllPlayersDead && __instance.timeUntilDeadline > 0)
            {
                __instance.timeUntilDeadline = __instance.timeUntilDeadline - __instance.timeUntilDeadline % __instance.totalTime + __instance.totalTime + 1;
            }
        }
    }
}
