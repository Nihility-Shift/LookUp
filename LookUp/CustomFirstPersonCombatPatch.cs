using HarmonyLib;

namespace LookUp
{
    [HarmonyPatch(typeof(CustomFirstPersonCombat), "YawLimit", MethodType.Setter)]
    internal class CustomFirstPersonCombatPatch
    {
        //Unlock first person yaw
        static void Prefix(ref float value)
        {
            if (value < 180)
            {
                value = 180f;
            }
        }
    }
}
