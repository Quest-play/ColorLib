# ColorLib

A library that allows you to use HEX and RGB colors in mods. Also has built-in colors.

# Dependancy

- [BeepInEx - ThunderStore Link](https://thunderstore.io/c/gatekeeper/p/BepInEx/BepInExPack_IL2CPP/)
- [GKAPI](https://thunderstore.io/c/gatekeeper/p/GatekeeperModding/GKAPI/)

# Current State

- Not published in Nuget

# Using the Library

### Build from source
- Clone this repository with ``git clone https://github.com/Quest-play/ColorLib.git`` 
- Navigate into the directory (if using the zip you have to unzip it first)
- Build with the command ``dotnet build`` (requires .NET SDK 6)
- The built dll is in the folder ``bin/Debug/net6.0/ColorLib.dll``


# Examples of use

<pre>
using Gatekeeper.Items;
using GKAPI.Items;
using GKAPI.Lang;

using static ColorLib.ColorLib; // ColorLib - colors

namespace ColorLib.Example
    public static class ItemRegister
    {
        private static object itemAPI;

        public static void RegisterItems(ItemAPI itemAPI)
        {

            var testItem = itemAPI.AddItem(new GkItem.Builder("Test Item", "Test item description", $"{ColorHelper.WrapInColor("Some Text", DarkGreen)} {ColorHelper.WrapInColor("Some Text", Blue)} {ColorHelper.WrapInColor("Some Text", Purple) }.") // {ColorHelper.WrapInColor("Any Text", COLOR FROM COLORLIB)}
            .SetUnlocked(true)
            .SetHidden(false)
            .AsModifier()
            );
        }
    }
}
</pre>