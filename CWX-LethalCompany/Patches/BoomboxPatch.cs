using HarmonyLib;
using System.Collections.Generic;

namespace CWX_LethalCompany.Patches
{
    [HarmonyPatch(typeof(BoomboxItem), "PocketItem")]
    internal class BoomboxPatch
    {
        static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            var test = new List<CodeInstruction>(instructions);

            test.RemoveAt(5);
            test.RemoveAt(4);
            test.RemoveAt(3);
            test.RemoveAt(2);

            return test;
        }
    }
}
