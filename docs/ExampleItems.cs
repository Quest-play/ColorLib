public class ExampleItems
{
    public static void CreateExampleItems(ItemAPI itemAPI)
    {
        // Create example items using the ColorLib
        var testItem = itemAPI.AddItem(new GkItem.Builder("Test Item", "Test item description", $"{LibColorHelper.WrapInColor("SomeText.", DarkGreen)} {LibColorHelper.WrapInColor("SomeText", Blue)}, {LibColorHelper.WrapInColor("SomeText", Purple)}")
            .SetUnlocked(true)
            .SetHidden(false)
            .AsModifier()
        );

        var testItem2 = itemAPI.AddItem(new GkItem.Builder("Test Item", "Test item description", $"{LibColorHelper.WrapInColor("Some Text", Brown)} {LibColorHelper.WrapInColor("Some Text", Navy)} {LibColorHelper.WrapInColor("Some Text", Magenta)}.")
            .SetUnlocked(true)
            .SetHidden(false)
            .AsModifier()
        );

        var testItem3 = itemAPI.AddItem(new GkItem.Builder("Test Item", "Test item description", $"{LibColorHelper.FromRgb(199, 21, 133, "Some Text")}, {LibColorHelper.FromRgb(255, 99, 71, "Some Text")}, {LibColorHelper.FromRgb(225, 215, 0, "Some Text")}.")
            .SetUnlocked(true)
            .SetHidden(false)
            .AsModifier()
        );

        var testItem4 = itemAPI.AddItem(new GkItem.Builder("Test Item", "Test item description", $"{LibColorHelper.FromHex("4B0082", "Some Text")}, {LibColorHelper.FromHex("800000", "Some Text")}, {LibColorHelper.FromHex("000000", "Some Text")}.")
            .SetUnlocked(true)
            .SetHidden(false)
            .AsModifier()
        );
    }
}