using HarmonyLib;
using InnerNet;
using UnityEngine;

namespace BetterAirship.Patch {

    [HarmonyPatch(typeof(PingTracker), nameof(PingTracker.Update))]
    [HarmonyPriority(Priority.First)]
    public static class PingTrackerPatch {
        private static Vector3 lastDist = Vector3.zero;

        public static void Postfix(ref PingTracker __instance) {
            if (!(AmongUsClient.Instance.GameState == InnerNetClient.GameStates.Started)) {
                AspectPosition aspect = __instance.text.gameObject.GetComponent<AspectPosition>();
                if (aspect.DistanceFromEdge != lastDist) {
                    aspect.DistanceFromEdge += new Vector3(0.6f, 0);
                    aspect.AdjustPosition();

                    lastDist = aspect.DistanceFromEdge;
                }
                __instance.text.text += $"\n<color=#2294E6FF>BetterAirship by Boss_GamerYT#0001</color> \nThanks for downloading!";
            }
        }
    }
}