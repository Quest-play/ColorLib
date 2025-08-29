# ColorLib

A library that allows you to use HEX and RGB colors in mods. Also has built-in colors.

# Dependancy

- [BeepInEx - ThunderStore Link](https://thunderstore.io/c/gatekeeper/p/BepInEx/BepInExPack_IL2CPP/)
- [GKAPI](https://thunderstore.io/c/gatekeeper/p/GatekeeperModding/GKAPI/)

# Current State

- Published on [Nuget](https://www.nuget.org/packages/ColorLib/1.0.0). The dll can be [built from source](https://github.com/Quest-play/ColorLib?tab=readme-ov-file#build-from-source) though

# Using the Library

### Build from source
- Clone this repository with ``git clone https://github.com/Quest-play/ColorLib.git`` 
- Navigate into the directory (if using the zip you have to unzip it first)
- Build with the command ``dotnet build`` (requires .NET SDK 6)
- The built dll is in the folder ``bin/Debug/net6.0/ColorLib.dll``


# Examples of use

```csharp
namespace ColorLib.Example
{
    public static class Example
    {

        public static void RegisterItems(ItemAPI itemAPI)
        {

            var testItem = itemAPI.AddItem(new GkItem.Builder("Test Item", "Test item description", $"<color={TextColor.DarkGreen}>Some Text</color> <color={TextColor.Blue}>Some Text</color> <color={TextColor.Purple}>Some Text</color>.")
            .SetUnlocked(true)
            .SetHidden(false)
            .AsModifier()
            );
        }
    }
}
```

```csharp
using GKAPI.Items;
using static ColorLib.TextColor; // No need to use TextColor.<COLOR> before each color

namespace ColorLib.Example
{
    public static class Example
    {

        public static void RegisterItems(ItemAPI itemAPI)
        {

            var testItem = itemAPI.AddItem(new GkItem.Builder("Test Item", "Test item description", $"<color={Brown}>Some Text</color> <color={Navy}>Some Text</color> <color={Magenta}>Some Text</color>.")
            .SetUnlocked(true)
            .SetHidden(false)
            .AsModifier()
            );
        }
    }
}
```

```csharp

using GKAPI.Items;

namespace ColorLib.Example
{
    public static class Example
    {

        public static void RegisterItems(ItemAPI itemAPI)
        {

            var testItem = itemAPI.AddItem(new GkItem.Builder("Test Item", "Test item description", $"<color={TextColor.FromRgb(199, 21, 133)}>Some Text</color> <color={TextColor.FromRgb(255, 99, 71)}>Some Text</color> <color={TextColor.FromRgb(225, 215, 0)}>Some Text</color>.")
            .SetUnlocked(true)
            .SetHidden(false)
            .AsModifier()
            );
        }
    }
}
```
### Or without using the library
```csharp
using GKAPI.Items;

namespace ColorLib.Example
{
    public static class Example
    {

        public static void RegisterItems(ItemAPI itemAPI)
        {

            var testItem = itemAPI.AddItem(new GkItem.Builder("Test Item", "Test item description", "<color=#4B0082>Some Text</color> <color=#800000>Some Text</color> <color=#000000>Some Text</color>.")
            .SetUnlocked(true)
            .SetHidden(false)
            .AsModifier()
            );
        }
    }
}
```

### Result

![result](https://raw.githubusercontent.com/Quest-play/ColorLib/main/docs/example.png)
![result1](https://raw.githubusercontent.com/Quest-play/ColorLib/main/docs/example1.png)
![result2](https://raw.githubusercontent.com/Quest-play/ColorLib/main/docs/example2.png)
![result3](https://raw.githubusercontent.com/Quest-play/ColorLib/main/docs/example3.png)