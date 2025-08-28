using System.Globalization;
using BepInEx;
using BepInEx.Logging;
using GKAPI;
using GKAPI.Lang;

namespace ColorLib;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
[BepInDependency(GKAPI.Plugin.PluginGuid)]
public class Plugin : GkPlugin
{
    public const string PluginGuid = "ua.quest_play.СolorLib";
    public const string PluginName = "ColorLib";
    private const string PluginVersion = "1.0.0";

    internal new static ManualLogSource Log;

    public override void Load()
    {
        base.Load();
        // Plugin startup logic
        Log = base.Log;
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    public override void AddContent()
    {

    }
    
    public static class ColorLib
    {
        public static readonly Colors LightGreen  = (Colors)0x6AFF6A;
        public static readonly Colors Green       = (Colors)0x26C026;
        public static readonly Colors DarkGreen   = (Colors)0x368936;
        public static readonly Colors Blue        = (Colors)0x6A6AFF;
        public static readonly Colors Yellow      = (Colors)0xFFFF6A;
        public static readonly Colors Orange      = (Colors)0xFFA500;
        public static readonly Colors Purple      = (Colors)0xA020F0;
        public static readonly Colors White       = (Colors)0xFFFFFF;
        public static readonly Colors Black       = (Colors)0x000000;

        // Quickly create color from int hex (0xRRGGBB)
        public static Colors FromHex(int hex) => (Colors)hex;

        // Quickly create color from RGB components
        public static Colors FromRgb(byte r, byte g, byte b)
            => (Colors)((r << 16) | (g << 8) | b);

        // Try to parse HEX strings like "#RRGGBB" or "RRGGBB"
        public static bool TryFromHexString(string hexString, out Colors color)
        {
            color = default;
            if (string.IsNullOrWhiteSpace(hexString)) return false;

            var s = hexString.Trim();
            if (s.StartsWith("#")) s = s.Substring(1);
            if (int.TryParse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var v))
            {
                color = (Colors)v;
                return true;
            }

            return false;
        }
    }
}
