using BepInEx;
using System;
using UnityEngine;
using UnityEngine.XR;
using Utilla;

namespace CustomGamemodesTemplate
{
    /// <summary>
    /// This is your mod's main class.
    /// </summary>

    /* This attribute tells Utilla to look for [ModdedGameJoin] and [ModdedGameLeave] */
    [ModdedGamemode]
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    [ModdedGamemode("CasInExampleID",  "Example CASUAL", Utilla.Models.BaseGamemode.Casual)]
    [ModdedGamemode("TagInExampleID",  "Example INFECTION", Utilla.Models.BaseGamemode.Infection)]
    [ModdedGamemode("HUNIInExampleID", "Example HUNT", Utilla.Models.BaseGamemode.Hunt)]
    public class Plugin : BaseUnityPlugin
    {
        bool inRoom;
        int RoomGameModeType;

        void OnEnable()
        {
            /* Set up your mod here */
            /* Code here runs at the start and whenever your mod is enabled*/

            HarmonyPatches.ApplyHarmonyPatches();
            Utilla.Events.GameInitialized += OnGameInitialized;
        }

        void OnDisable()
        {
            /* Undo mod setup here */
            /* This provides support for toggling mods with ComputerInterface, please implement it :) */
            /* Code here runs whenever your mod is disabled (including if it disabled on startup)*/

            HarmonyPatches.RemoveHarmonyPatches();
            Utilla.Events.GameInitialized -= OnGameInitialized;
        }

        void OnGameInitialized(object sender, EventArgs e)
        {
            /* Code here runs after the game initializes (i.e. GorillaLocomotion.Player.Instance != null) */
        }

        void Update()
        {
            /* Code here runs every frame when the mod is enabled */
        }

        /* This attribute tells Utilla to call this method when a modded room is joined */
        [ModdedGamemodeJoin]
        public void OnJoin(string gamemode)
        {
            /* Activate your mod here */
            /* This code will run regardless of if the mod is enabled*/
            print(gamemode);
            if (gamemode == "forestDEFAULTMODDED_CasInExampleIDCASUAL")
            {
                RoomGameModeType = 1;
                inRoom = true;
            }
            if (gamemode == "canyonDEFAULTMODDED_CasInExampleIDCASUAL")
            {
                RoomGameModeType = 1;
                inRoom = true;
            }
            if (gamemode == "caveDEFAULTMODDED_CasInExampleIDCASUAL")
            {
                RoomGameModeType = 1;
                inRoom = true;
            }
            // infection
            if (gamemode == "forestDEFAULTMODDED_TagInExampleIDINFECTION")
            {
                RoomGameModeType = 2;
                inRoom = true;
            }
            if (gamemode == "canyonDEFAULTMODDED_TagInExampleIDINFECTION")
            {
                RoomGameModeType = 2;
                inRoom = true;
            }
            if (gamemode == "caveDEFAULTMODDED_TagInExampleIDINFECTION")
            {
                RoomGameModeType = 2;
                inRoom = true;
            }
            // hunt
            if (gamemode == "forestDEFAULTMODDED_HUNIInExampleIDHUNT")
            {
                RoomGameModeType = 3;
                inRoom = true;
            }
            if (gamemode == "canyonDEFAULTMODDED_HUNIInExampleIDHUNT")
            {
                RoomGameModeType = 3;
                inRoom = true;
            }
            if (gamemode == "caveDEFAULTMODDED_HUNIInExampleIDHUNT")
            {
                RoomGameModeType = 3;
                inRoom = true;
            }
        }

        /* This attribute tells Utilla to call this method when a modded room is left */
        [ModdedGamemodeLeave]
        public void OnLeave(string gamemode)
        {
            /* Deactivate your mod here */
            /* This code will run regardless of if the mod is enabled*/

            inRoom = false;
        }
    }
}