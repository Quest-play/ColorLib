# Introduction
### This library was originally intended for use in Gatekeeper mods. Due to the lack of colors in the API. <br/> So the examples here are for Gatekeeper mods.

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