using HarmonyLib;
using SoftcoreLC;
using Unity.Netcode;

namespace ApparatusRetrieval.Patches
{
    [HarmonyPatch(typeof(NetworkObject), "Despawn")]
    public class DespawnPatch
    {
        private static bool Prefix(NetworkObject __instance)
        {
            if (!StartOfRound.Instance.isChallengeFile && Plugin.AllPlayersDead && TimeOfDay.Instance.timeUntilDeadline > 0 && __instance.GetComponent<GrabbableObject>() != null && ((GrabbableObject)__instance.GetComponent<GrabbableObject>()).scrapPersistedThroughRounds) return false;
            return true;
        }
    }
}
