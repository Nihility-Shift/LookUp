using BepInEx;
using HarmonyLib;
using System.Reflection;

namespace LookUp
{
    static class MyPluginInfo
    {
        public const string PLUGIN_GUID = "id107.lookup";
        public const string PLUGIN_NAME = "LookUp";
        public const string PLUGIN_VERSION = "0.0.2";
    }

    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    [BepInProcess("Void Crew.exe")]
    public class Plugin : BaseUnityPlugin
    {
        public static Plugin Instance { get; private set; }

        private void Awake()
        {
            Instance = this;
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), MyPluginInfo.PLUGIN_GUID);
            Log($"{MyPluginInfo.PLUGIN_NAME} loaded");
        }

        public void Log(string message)
        {
            base.Logger.LogInfo(message);
        }
    }
}
