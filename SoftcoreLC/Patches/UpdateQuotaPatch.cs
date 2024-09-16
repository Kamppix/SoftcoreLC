using HarmonyLib;
using SoftcoreLC;

namespace ApparatusRetrieval.Patches
{
    [HarmonyPatch(typeof(StartOfRound), "ResetShip")]
    public class ResetShipPatch
    {
        private static void Prefix()
        {
            Plugin.AllPlayersDead = false;
        }
    }
}
