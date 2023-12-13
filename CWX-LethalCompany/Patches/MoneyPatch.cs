using HarmonyLib;

namespace CWX_LethalCompany.Patches
{
    [HarmonyPatch(typeof(Terminal), "Update")]
    internal class MoneyPatch
    {
        static void Prefix(Terminal __instance)
        {
            __instance.groupCredits = 9999;
        }
    }
}
