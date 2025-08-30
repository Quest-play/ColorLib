public class ExampleItems
{
    public static void CreateExampleItems(ItemAPI itemAPI)
    {
        // Create example items using the ColorLib
        var testItem = itemAPI.AddItem(new GkItem.Builder("Test Item", "Test item description", $"<color={TextColor.DarkGreen}>Some Text</color> <color={TextColor.Blue}>Some Text</color> <color={TextColor.Purple}>Some Text</color>.")
            .SetUnlocked(true)
            .SetHidden(false)
            .AsModifier()
        );

        var testItem2 = itemAPI.AddItem(new GkItem.Builder("Test Item", "Test item description", $"<color={Brown}>Some Text</color> <color={Navy}>Some Text</color> <color={Magenta}>Some Text</color>.")
            .SetUnlocked(true)
            .SetHidden(false)
            .AsModifier()
        );

        var testItem = itemAPI.AddItem(new GkItem.Builder("Test Item", "Test item description", $"<color={TextColor.FromRgb(199, 21, 133)}>Some Text</color> <color={TextColor.FromRgb(255, 99, 71)}>Some Text</color> <color={TextColor.FromRgb(225, 215, 0)}>Some Text</color>.")
            .SetUnlocked(true)
            .SetHidden(false)
            .AsModifier()
        );

        // Or without using the library
        var testItem = itemAPI.AddItem(new GkItem.Builder("Test Item", "Test item description", "<color=#4B0082>Some Text</color> <color=#800000>Some Text</color> <color=#000000>Some Text</color>.")
            .SetUnlocked(true)
            .SetHidden(false)
            .AsModifier()
            );
    }
}