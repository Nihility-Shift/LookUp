using HarmonyLib;

namespace LookUp
{
    [HarmonyPatch(typeof(CustomFirstPersonCombat), "set_UseLocalRotation")]
    internal class CustomFirstPersonCombatPatch
    {
        //Unlock first person yaw
        static void Prefix(ref bool value)
        {
            value = false;
        }
    }
}
