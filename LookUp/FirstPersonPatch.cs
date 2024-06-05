using HarmonyLib;
using Opsive.Shared.Utility;
using Opsive.UltimateCharacterController.FirstPersonController.Camera.ViewTypes;

namespace LookUp
{
    [HarmonyPatch(typeof(FirstPerson), "PitchLimit", MethodType.Setter)]
    internal class FirstPersonPatch
    {
        //Unlock first person pitch
        static void Prefix(ref MinMaxFloat value)
        {
            value = new MinMaxFloat(-89.999f, 89.999f);
        }
    }
}
