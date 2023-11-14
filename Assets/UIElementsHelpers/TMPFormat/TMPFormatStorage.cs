using System.Collections.Generic;
using UnityEngine;

public static class TMPFormatStorage
{
    public static List<TMPFormat> Data = new List<TMPFormat>()
    {
        new TMPFormat()
        {
            Name = "Default",
            FontSize = 42,
            AutoSize = true,
            TextAlignment = TMPro.TextAlignmentOptions.Center,
        },
         new TMPFormat()
        {
            Name = "SmallRightSide",
            FontSize = 34,
            AutoSize = false,
            FontStyle = TMPro.FontStyles.Italic,
            TextAlignment = TMPro.TextAlignmentOptions.MidlineRight,
        },
          new TMPFormat()
        {
            Name = "SmallBoldLeftSide",
            FontSize = 34,
            AutoSize = false,
            FontStyle = TMPro.FontStyles.Bold,
            TextAlignment = TMPro.TextAlignmentOptions.MidlineLeft,
        },
    };
}