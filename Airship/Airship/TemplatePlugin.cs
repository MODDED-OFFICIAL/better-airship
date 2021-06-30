using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;
using BepInEx.Logging;
using Reactor;
using Reactor.Patches;

namespace Airship
{
    [BepInPlugin(Id)]
    [BepInProcess("Among Us.exe")]
    [BepInDependency(ReactorPlugin.Id)]
    public class Airship : BasePlugin
    {
        public const string Id = "boss.gamer.yt";

        public Harmony Harmony { get; } = new Harmony(Id);
        public static ManualLogSource log;


        public override void Load()
        {
            log = Log;
            
            log.LogMessage("Better Airship Mod loaded");

            ReactorVersionShower.TextUpdated += (text) =>
            {
                int index = text.text.LastIndexOf('\n');
                text.text = text.text.Insert(index == -1 ? text.text.Length - 1 : index, 
                    "\n \n \n \n \n \n \nBetter Airship by Boss_GamerYT & DaNoob \nyoutube.com/BossGamerYTShorts \n<color=#2cdb12>Version: 9.2.3</color> <color=#2cdb12>Stable</color>");
            };
            
            Harmony.PatchAll();
        }
    }
}