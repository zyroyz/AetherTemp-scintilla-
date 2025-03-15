using GorillaTag.Cosmetics.Summer;
using StupidTemplate.Classes;
using StupidTemplate.Menu;
using StupidTemplate.Mods;
using static StupidTemplate.Settings;
using UnityEngine;
using GorillaTag.Cosmetics;


namespace AetherTemp.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.MainSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "advantages", method =() => SettingsMods.advantages(), isTogglable = false, toolTip = "Opens the advantages page for the menu."},
                new ButtonInfo { buttonText = "visuals", method =() => SettingsMods.visuals(), isTogglable = false, toolTip = "Opens the visuals page for the menu."},
                new ButtonInfo { buttonText = "movement", method =() => SettingsMods.movement(), isTogglable = false, toolTip = "Opens the movement page for the menu."},
                new ButtonInfo { buttonText = "overpowered", method =() => SettingsMods.overpowered(), isTogglable = false, toolTip = "Opens the overpowered page for the menu."},
                new ButtonInfo { buttonText = "safety", method =() => SettingsMods.safety(), isTogglable = false, toolTip = "Opens the safety page for the menu."},
                new ButtonInfo { buttonText = "fun", method =() => SettingsMods.fun(), isTogglable = false, toolTip = "Opens the fun page for the menu."},
                new ButtonInfo { buttonText = "guardian", method =() => SettingsMods.guardian(), isTogglable = false, toolTip = "Opens the guardian page for the menu."},
            },

            new ButtonInfo[] { // Main Settings
                new ButtonInfo { buttonText = "Menu Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the Menu settings for the menu."},
                new ButtonInfo { buttonText = "GunLib Settings", method =() => SettingsMods.GunLib(), isTogglable = false, toolTip = "Opens the GunLib settings for the menu."},
                new ButtonInfo { buttonText = "Notifications Settings", method =() => SettingsMods.Notification(), isTogglable = false, toolTip = "Opens the GunLib settings for the menu."},
            },

            new ButtonInfo[] { // Advantages
                new ButtonInfo { buttonText = "placeholder", method =() => mods.placeholder(), isTogglable = false, toolTip = "placeholder."},
                new ButtonInfo { buttonText = "Gun Temp", method =() => mods.GunTemplate(), isTogglable = true, toolTip = "placeholder."},
            },

            new ButtonInfo[] { // Movement
                new ButtonInfo { buttonText = "placeholder", method =() => mods.placeholder(), isTogglable = false, toolTip = "placeholder."},
            },

            new ButtonInfo[] { // visuals
                new ButtonInfo { buttonText = "placeholder", method =() => mods.placeholder(), isTogglable = false, toolTip = "placeholder."},
            },

            new ButtonInfo[] { // overpowered
                new ButtonInfo {buttonText = "placeholder", method =() => mods.placeholder(), isTogglable = false, toolTip = "placeholder."},
            },

            new ButtonInfo[] { // safety
                 new ButtonInfo { buttonText = "placeholder", method =() => mods.placeholder(), isTogglable = false, toolTip = "placeholder."},
            },

            new ButtonInfo[] { // fun
                 new ButtonInfo { buttonText = "placeholder", method =() => mods.placeholder(), isTogglable = false, toolTip = "placeholder."},
            },

            new ButtonInfo[] { // guardian
                new ButtonInfo { buttonText = "placeholder", method =() => mods.placeholder(), isTogglable = false, toolTip = "placeholder."},
            },


            new ButtonInfo[] { // GunLib
                new ButtonInfo { buttonText = "Equip Gun", method =() => mods.GunTemplate(), isTogglable = true, toolTip = "Equips a gun."},
                new ButtonInfo { buttonText = $"Smoothness: {(mods.num == 5f ? "Very Fast" : mods.num == 10f ? "Normal" : "Super Smooth")}", method = () => { mods.GunSmoothNess(); foreach (var category in Buttons.buttons) foreach (var button in category) if (button.buttonText.StartsWith("Smoothness")) button.buttonText = $"Smoothness: {(mods.num == 5f ? "Super Smooth" : mods.num == 10f ? "Normal" : "No Smooth")}"; }, isTogglable = false, toolTip = "Changes gun smoothness." },
                new ButtonInfo { buttonText = $"Gun Color: {mods.currentGunColor.name}", method = () => { mods.CycleGunColor(); Buttons.buttons.ForEach(category => category.ForEach(button => { if (button.buttonText.StartsWith("Gun Color")) button.buttonText = $"Gun Color: {mods.currentGunColor.name}"; })); }, isTogglable = false, toolTip = "Cycles through gun colors." },
                new ButtonInfo { buttonText = $"Toggle Sphere Size: {(mods.isSphereEnabled ? "Enabled" : "Disabled")}", method = () => { mods.isSphereEnabled = !mods.isSphereEnabled; if (mods.GunSphere != null) mods.GunSphere.transform.localScale = mods.isSphereEnabled ? new Vector3(0.1f, 0.1f, 0.1f) : new Vector3(0f, 0f, 0f); foreach (var category in Buttons.buttons) foreach (var button in category) if (button.buttonText.StartsWith("Toggle Sphere Size")) button.buttonText = $"Toggle Sphere Size: {(mods.isSphereEnabled ? "Enabled" : "Disabled")}"; }, isTogglable = false, toolTip = "Toggles the size of the gun sphere." }
            },

            new ButtonInfo[] { // MenuSettings
                new ButtonInfo { buttonText = "Right/Left Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Notifications
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
            },



            //always keep this at the bottom if you add another tab (by going to categories) make sure you put that section above this one:

             new ButtonInfo[] {
                 new ButtonInfo { buttonText = "Disconnect", method =() => mods.Disconnect(), isTogglable = false, toolTip = "Opens the settings for the menu."},
             },
            new ButtonInfo[] {
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },

        };
    }
}
