using HarmonyLib;

namespace SoftcoreLC.Patches
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
