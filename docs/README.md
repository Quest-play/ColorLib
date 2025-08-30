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

            var testItem = itemAPI.AddItem(new GkItem.Builder("Test Item", "Test item description", $"{LibColorHelper.WrapInColor("SomeText.", Colors.DarkGreen)} {LibColorHelper.WrapInColor("SomeText", Colors.Blue)}, {LibColorHelper.WrapInColor("SomeText", Colors.Purple)}")
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

            var testItem2 = itemAPI.AddItem(new GkItem.Builder("Test Item", "Test item description", $"{LibColorHelper.WrapInColor("Some Text", Brown)} {LibColorHelper.WrapInColor("Some Text", Navy)} {LibColorHelper.WrapInColor("Some Text", Magenta)}.")
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

            var testItem3 = itemAPI.AddItem(new GkItem.Builder("Test Item", "Test item description", $"{LibColorHelper.FromRgb(199, 21, 133, "Some Text")}, {LibColorHelper.FromRgb(255, 99, 71, "Some Text")}, {LibColorHelper.FromRgb(225, 215, 0, "Some Text")}.")
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

            var testItem4 = itemAPI.AddItem(new GkItem.Builder("Test Item", "Test item description", $"{LibColorHelper.FromHex("4B0082", "Some Text")}, {LibColorHelper.FromHex("800000", "Some Text")}, {LibColorHelper.FromHex("000000", "Some Text")}.")
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