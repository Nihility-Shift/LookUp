using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System.Reflection;

namespace LookUp
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.USERS_PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    [BepInProcess("Void Crew.exe")]
    [BepInDependency(VoidManager.MyPluginInfo.PLUGIN_GUID)]
    public class Plugin : BaseUnityPlugin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:Remove unused private members", Justification = "N/A")]
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