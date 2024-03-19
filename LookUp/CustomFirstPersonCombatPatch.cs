using HarmonyLib;

namespace LookUp
{
    [HarmonyPatch(typeof(CustomFirstPersonCombat), "UseLocalRotation", MethodType.Setter)]
    internal class CustomFirstPersonCombatPatch
    {
        //Unlock first person yaw
        static void Prefix(ref bool value)
        {
            value = false;
        }
    }
}
