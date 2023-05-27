using HarmonyLib;
using NeosModLoader;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Collections.Generic;
using FrooxEngine;

namespace TrackerModelSwapper
{
    public class TrackerModelSwapper : NeosMod
    {
        public override string Name => "TrackerModelSwapper";
        public override string Author => "art0007i";
        public override string Version => "1.0.0";
        public override string Link => "https://github.com/art0007i/TrackerModelSwapper/";

        [AutoRegisterConfigKey]
        public static ModConfigurationKey<string> KEY_TRACKER_MODEL = new("tracker_model", "The URL pointing towards your tracker model.", () => "neosdb:///a421748d183ed60f8ea767b85ff7d0c7351b3a611ab04887aac4b5f2a0a500d3.7zbson", false, (s) => Uri.TryCreate(s, UriKind.Absolute, out var _));

        public static FieldInfo vive_model = AccessTools.Field(typeof(NeosAssets.DeviceModels.SteamVR), "__uri_vr_tracker_vive_1_0");

        public override void OnEngineInit()
        {
            //Harmony harmony = new Harmony("me.art0007i.TrackerModelSwapper");
            var config = GetConfiguration();
            vive_model.SetValue(null, new Uri(config.GetValue(KEY_TRACKER_MODEL), UriKind.Absolute));

            config.OnThisConfigurationChanged += e =>
            {
                if(e.Key == KEY_TRACKER_MODEL)
                {
                    vive_model.SetValue(null, new Uri(e.Config.GetValue(KEY_TRACKER_MODEL), UriKind.Absolute));
                }
            };
        }
    }
}