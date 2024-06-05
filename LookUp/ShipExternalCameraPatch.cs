using Gameplay.Helm;
using HarmonyLib;

namespace LookUp
{
    [HarmonyPatch(typeof(ShipExternalCamera), "OnShipExternalViewToggle")]
    internal class ShipExternalCameraPatch
    {
        //Unlock pilot view pitch
        static void Postfix(ShipExternalCamera __instance)
        {
            __instance.XRotationLimit = 89f;
        }
    }
}
