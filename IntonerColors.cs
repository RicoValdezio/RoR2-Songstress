using UnityEngine;

namespace SongstressPlugin
{
    class IntonerColors
    {
        internal static Color ZeroEye = new Color(0.988281f, 0.609375f, 0.699218f); //#FD9CB3
        internal static Color OneEye = new Color(0.910156f, 0.3515625f, 0.535156f); //#E95A89
        internal static Color TwoEye = new Color(0.171875f, 0.535156f, 0.738281f); //#2C89BD
        internal static Color ThreeEye = new Color(0.785156f, 0.347656f, 0.921875f); //#C959EC
        internal static Color FourEye = new Color(0.070312f, 0.683593f, 0.593750f); //#12AF98
        internal static Color FiveEye = new Color(0.628906f, 0.593750f, 0.480469f); //#A1987B
        internal static Color ChosenColor;

        internal static void Init()
        {
            if (Random.Range(1, 100) >= 95)
            {
                switch (Random.Range(1, 5))
                {
                    case 1:
                        ChosenColor = OneEye;
                        break;
                    case 2:
                        ChosenColor = TwoEye;
                        break;
                    case 3:
                        ChosenColor = ThreeEye;
                        break;
                    case 4:
                        ChosenColor = FourEye;
                        break;
                    case 5:
                        ChosenColor = FiveEye;
                        break;
                }
            }
            ChosenColor = ZeroEye;
        }
    }
}
