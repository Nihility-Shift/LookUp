using HarmonyLib;
using Opsive.UltimateCharacterController.FirstPersonController.Camera.ViewTypes;

namespace LookUp
{
    [HarmonyPatch(typeof(FirstPerson), nameof(FirstPerson.MaxPitch), MethodType.Setter)]
    internal class FirstPersonMaxPitchPatch
    {
        //Unlock first person pitch
        static void Prefix(ref float value)
        {
            value = 89.999f;
        }
    }

    [HarmonyPatch(typeof(FirstPerson), nameof(FirstPerson.MinPitch), MethodType.Setter)]
    internal class FirstPersonMinPitchPatch
    {
        //Unlock first person pitch
        static void Prefix(ref float value)
        {
            value = -89.999f;
        }
    }
}
