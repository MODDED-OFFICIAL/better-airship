using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;
using InnerNet;
using UnhollowerBaseLib;
using UnityEngine;

namespace Airship.Colors
{
    [BepInPlugin("en.bossgamer.excolors", "ExtraColors", "1.3")]
	public class ExtraColors : BasePlugin {
		public override void Load() {
			var array = new[] {
				StringNames.VitalsRED,
				StringNames.VitalsBLUE,
				StringNames.VitalsGRN,
				StringNames.VitalsPINK,
				StringNames.VitalsORGN,
				StringNames.VitalsYLOW,
				StringNames.VitalsBLAK,
				StringNames.VitalsWHTE,
				StringNames.VitalsPURP,
				StringNames.VitalsBRWN,
				StringNames.VitalsCYAN,
				StringNames.VitalsLIME,
				(StringNames)999991,
				(StringNames)999992,
				(StringNames)999993,
				(StringNames)999994,
				(StringNames)999995,
				(StringNames)999996,
				(StringNames)999997,
				(StringNames)999998,
				(StringNames)999999,
				(StringNames)1000000,
			};
			Color32[] array2 = new Color32[] {
				new Color32(198, 17, 17, byte.MaxValue),
				new Color32(19, 46, 210, byte.MaxValue),
				new Color32(27, 145, 62, byte.MaxValue),
				new Color32(238, 84, 187, byte.MaxValue),
				new Color32(240, 125, 13, byte.MaxValue),
				new Color32(246, 246, 87, byte.MaxValue),
				new Color32(63, 71, 78, byte.MaxValue),
				new Color32(215, 225, 241, byte.MaxValue),
				new Color32(107, 47, 188, byte.MaxValue),
				new Color32(113, 73, 30, byte.MaxValue),
				new Color32(56, byte.MaxValue, 221, byte.MaxValue),
				new Color32(80, 240, 57, byte.MaxValue),
				new Color32(108, 43, 61, byte.MaxValue),
				new Color32(255, 255, 190, byte.MaxValue),
				new Color32(131, 151, 167, byte.MaxValue),
				new Color32(159, 153, 137, byte.MaxValue),
				new Color32(236, 117, 120, byte.MaxValue),
				new Color32(97, 114, 24, byte.MaxValue),
				new Color32(38, 166, 98, byte.MaxValue),
				new Color32(0, 0, 255, byte.MaxValue),
				new Color32(255, 0, 0, byte.MaxValue)
			};
			Color32[] array3 = new Color32[] {
				new Color32(122, 8, 56, byte.MaxValue),
				new Color32(9, 21, 142, byte.MaxValue),
				new Color32(10, 77, 46, byte.MaxValue),
				new Color32(172, 43, 174, byte.MaxValue),
				new Color32(180, 62, 21, byte.MaxValue),
				new Color32(195, 136, 34, byte.MaxValue),
				new Color32(30, 31, 38, byte.MaxValue),
				new Color32(132, 149, 192, byte.MaxValue),
				new Color32(59, 23, 124, byte.MaxValue),
				new Color32(94, 38, 21, byte.MaxValue),
				new Color32(36, 169, 191, byte.MaxValue),
				new Color32(21, 168, 66, byte.MaxValue),
				new Color32(108, 43, 61, byte.MaxValue),
				new Color32(255, 255, 190, byte.MaxValue),
				new Color32(131, 151, 167, byte.MaxValue),
				new Color32(159, 153, 137, byte.MaxValue),
				new Color32(236, 117, 120, byte.MaxValue),
				new Color32(97, 114, 24, byte.MaxValue),
				new Color32(38, 166, 98, byte.MaxValue),
				new Color32(255, 0, 0, byte.MaxValue),
				new Color32(0, 0, 255, byte.MaxValue)
			};

			Palette.ColorNames = array;
			Palette.PlayerColors = array2;
			Palette.ShadowColors = array3;
		}
	};

	[HarmonyPatch(typeof(TranslationController), nameof(TranslationController.GetString),
		new[] { typeof(StringNames), typeof(Il2CppReferenceArray<Il2CppSystem.Object>) })]
	public class PatchColours {
		public static bool Prefix(ref string __result, [HarmonyArgument(0)] StringNames name) {
			switch ((int)name) {
				case 999991:
					__result = "MAROON";
					return false;
				case 999992:
					__result = "ROSE";
					return false;
				case 999993:
					__result = "BANANA";
					return false;
				case 999994:
					__result = "GRAY";
					return false;
				case 999995:
					__result = "TAN";
					return false;
				case 999996:
					__result = "CORAL";
					return false;
				case 999997:
					__result = "FGREEN";
					return false;
				case 999998:
					__result = "OLIVE";
					return false;
				case 999999:
					__result = "ABASE";
					return false;
				case 1000000:
					__result = "BBASE";
					return false;
			}
			return true;
		}
	}
}