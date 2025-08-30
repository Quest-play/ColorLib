namespace ColorLib;

public class LibColorHelper
{
    public static string WrapInColor(string text, Colors color)
    {
        return $"<color=#{(int)color:X6}><b>{text}</b></color>";
    }

    public static string FromHex(string hex, string text) => $"<color=#{hex}><b>{text}</b></color>";

    public static string FromRgb(byte r, byte g, byte b, string text) => $"<color=#{r:X2}{g:X2}{b:X2}><b>{text}</b></color>";
}