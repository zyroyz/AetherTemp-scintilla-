﻿using StupidTemplate.Classes;
using UnityEngine;
using static StupidTemplate.Menu.Main;

namespace StupidTemplate
{
    internal class Settings
    {
        public static ExtGradient backgroundColor = new ExtGradient { isRainbow = false };
        public static ExtGradient[] buttonColors = new ExtGradient[]
        {
            new ExtGradient{colors = GetSolidGradient(new Color(176f / 255f, 153f / 255f, 128f / 255f)) }, // Disabled
            new ExtGradient{isRainbow = false} // Enabled
        };
        public static Color[] textColors = new Color[]
        {
            Color.white, // Disabled
            Color.white // Enabled
        };

        public static Font currentFont = (Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font);

        public static bool fpsCounter = false;
        public static bool disconnectButton = true;
        public static bool rightHanded = false;
        public static bool disableNotifications = false;

        public static KeyCode keyboardButton = KeyCode.Q;

        public static Vector3 menuSize = new Vector3(0.1f, 1f, 1f); // Depth, Width, Height
        public static int buttonsPerPage = 5;
    }
}
