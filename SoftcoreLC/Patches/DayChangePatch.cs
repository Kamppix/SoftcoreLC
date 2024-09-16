using HarmonyLib;
using SoftcoreLC;

namespace ApparatusRetrieval.Patches
{
    [HarmonyPatch(typeof(TimeOfDay), "OnDayChanged")]
    public class DayChangePatch
    {
        private static bool Prefix(TimeOfDay __instance)
        {
            if (!StartOfRound.Instance.isChallengeFile && Plugin.AllPlayersDead && __instance.timeUntilDeadline > 0) return false;
            else return true;
        }
    }
}
