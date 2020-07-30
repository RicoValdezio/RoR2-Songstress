using System.Collections.Generic;
using UnityEngine;

namespace SongstressPlugin
{
    class ColorLibrary
    {
        //Intoner-Specific UnityEngine Colors
        internal static Color ZeroColor = new Color(0.988281f, 0.609375f, 0.699218f);
        internal static Color OneColor = new Color(0.910156f, 0.3515625f, 0.535156f);
        internal static Color TwoColor = new Color(0.171875f, 0.535156f, 0.738281f);
        internal static Color ThreeColor = new Color(0.785156f, 0.347656f, 0.921875f);
        internal static Color FourColor = new Color(0.070312f, 0.683593f, 0.593750f);
        internal static Color FiveColor = new Color(0.628906f, 0.593750f, 0.480469f);
        internal static Color ChosenColor;

        //Intoner-Specific HexString Colors
        internal static string ZeroString = "<color=#FD9CB3>";
        internal static string OneString = "<color=#E95A89>";
        internal static string TwoString = "<color=#2C89BD>";
        internal static string ThreeString = "<color=#C959EC>";
        internal static string FourString = "<color=#12AF98>";
        internal static string FiveString = "<color=#A1987B>";
        internal static string ChosenString;

        //General Purpose HexString Colors
        internal static string EndString = "</color>";
        internal static string DescGreyString = "<color=#CCD3E0>";
    }
}
