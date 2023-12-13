using System;
using BepInEx;
using HarmonyLib;
using ReservedItemSlotCore;

namespace CWX_LethalCompany
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    [BepInDependency("FlipMods.ReservedItemSlotCore")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            Plugin.instance = this;
            this._harmony = new Harmony("CWX-LethalCompany");
            this._harmony.PatchAll();
            Log("CWX-LethalCompany Loaded");
        }

        public static void Log(string message)
        {
            Plugin.instance.Logger.LogInfo(message);
        }

        public static Plugin instance;

        private Harmony _harmony;

        public static ReservedItemInfo boomBoxInfo = new ReservedItemInfo("Boombox", 120, true, true, true, true);
    }
}
