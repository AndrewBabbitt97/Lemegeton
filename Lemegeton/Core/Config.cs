﻿using Dalamud.Configuration;
using FFXIVClientStructs.FFXIV.Common.Math;
using System.IO;

namespace Lemegeton.Core
{

    public class Config : IPluginConfiguration
    {

        public enum TimelineBarStyleEnum
        {
            Solid,
            Fancy,
        }

        public enum TextAlignmentEnum
        {
            Left,
            Center,
            Right,
        }

        public int Version { get; set; } = 0;
        public string Language { get; set; } = "English";
        public string PlogonVersion { get; set; } = "1.0.0.0";
        public bool Opened { get; set; } = true;
        public bool ShowShortcut { get; set; } = true;
        public int ShortcutScale { get; set; } = 100;
        public bool FirstRun { get; set; } = true;
        public bool AdvancedOptions { get; set; } = false;

        public string OpcodeUrl { get; set; } = @"https://raw.githubusercontent.com/AndrewBabbitt97/Lemegeton/master/Data/blueprint.xml";
        public string OpcodeRegion { get; set; } = "EN/DE/FR/JP";
        public bool LogUnhandledOpcodes { get; set; } = false;
        public bool QueueFramework { get; set; } = true;

        public bool QuickToggleAutomarkers { get; set; } = true;
        public bool QuickToggleOverlays { get; set; } = false;
        public bool QuickToggleSound { get; set; } = false;
#if !SANS_GOETIA
        public bool QuickToggleHacks { get; set; } = false;
        public bool QuickToggleAutomation { get; set; } = false;
#endif

        public bool NagAboutStreaming { get; set; } = true;

        public bool AutomarkerSoft { get; set; } = false;
        public bool AutomarkerCommands { get; set; } = false;
        public int AutomarkersServed { get; set; } = 0;
        public bool RemoveMarkersAfterCombatEnd { get; set; } = true;
        public bool RemoveMarkersAfterWipe { get; set; } = true;

        public Vector4 SoftmarkerTint { get; set; } = new Vector4(1.0f, 1.0f, 1.0f, 1.0f);
        public bool SoftmarkerBounce { get; set; } = true;
        public bool SoftmarkerBlink { get; set; } = false;
        public float SoftmarkerScale { get; set; } = 1.0f;
        public float SoftmarkerOffsetWorldX { get; set; } = 0.0f;
        public float SoftmarkerOffsetWorldY { get; set; } = 2.0f;
        public float SoftmarkerOffsetWorldZ { get; set; } = 0.0f;
        public float SoftmarkerOffsetScreenX { get; set; } = 0.0f;
        public float SoftmarkerOffsetScreenY { get; set; } = 0.0f;

        public Rectangle TimelineOverlayLocation { get; set; } = new Rectangle() { Left = 100.0f, Top = 100.0f, Bottom = 300.0f, Right = 400.0f };
        public float TimelineOverlayBarHeight { get; set; } = 40.0f;
        public Vector4 TimelineOverlayBarColor { get; set; } = new Vector4(0.145f, 0.506f, 0.653f, 1.0f);
        public Vector4 TimelineOverlayBarTextColor { get; set; } = new Vector4(1.0f, 1.0f, 1.0f, 1.0f);
        public Vector4 TimelineOverlayBarSoonColor { get; set; } = new Vector4(0.722f, 0.146f, 0.146f, 1.0f);
        public Vector4 TimelineOverlayBarSoonTextColor { get; set; } = new Vector4(1.0f, 1.0f, 0.0f, 1.0f);
        public Vector4 TimelineOverlayBarActiveColor { get; set; } = new Vector4(0.726f, 0.488f, 0.085f, 1.0f);
        public Vector4 TimelineOverlayBarActiveTextColor { get; set; } = new Vector4(1.0f, 1.0f, 0.0f, 1.0f);
        public Vector4 TimelineOverlayBarBgColor { get; set; } = new Vector4(0.0f, 0.0f, 0.0f, 0.3f);
        public float TimelineOverlayBarTextScale { get; set; } = 1.5f;
        public float TimelineOverlayBarSoonThreshold { get; set; } = 5.0f;
        public float TimelineOverlayBarTimeThreshold { get; set; } = 20.0f;
        public float TimelineOverlayBarPastThreshold { get; set; } = 2.0f;
        public bool TimelineOverlayBarHead { get; set; } = true;
        public bool TimelineOverlayBarName { get; set; } = true;
        public bool TimelineOverlayBarTime { get; set; } = true;
        public bool TimelineOverlayBarCaps { get; set; } = false;
        public bool TimelineOverlayVisible { get; set; } = false;
        public bool TimelineOverlayDebug { get; set; } = false;        
        public TimelineBarStyleEnum TimelineOverlayBarStyle { get; set; } = TimelineBarStyleEnum.Fancy;
        public bool TimelineLocalAllowed { get; set; } = true;
        public string TimelineLocalFolder { get; set; } = "";
        public bool TimelineTabVisible { get; set; } = false;
        
        public Rectangle NotificationOverlayLocation { get; set; } = new Rectangle() { Left = 100.0f, Top = 350.0f, Bottom = 550.0f, Right = 400.0f };
        public float NotificationOverlayEntryHeight { get; set; } = 40.0f;
        public float NotificationOverlayEntryMargin { get; set; } = 10.0f;
        public bool NotificationOverlayVisible { get; set; } = false;
        public bool NotificationOrderReverse { get; set; } = false;
        public float NotificationOverlayTextScale { get; set; } = 1.5f;
        public TextAlignmentEnum NotificationEntryAlignment { get; set; } = TextAlignmentEnum.Center;
        public Vector4 NotificationOverlayCriticalTextColor { get; set; } = new Vector4(1.0f, 1.0f, 0.0f, 1.0f);
        public Vector4 NotificationOverlayCriticalBgColor { get; set; } = new Vector4(1.0f, 0.0f, 0.0f, 0.5f);
        public Vector4 NotificationOverlayImportantTextColor { get; set; } = new Vector4(1.0f, 1.0f, 1.0f, 1.0f);
        public Vector4 NotificationOverlayImportantBgColor { get; set; } = new Vector4(1.0f, 1.0f, 0.0f, 0.5f);
        public Vector4 NotificationOverlayNormalTextColor { get; set; } = new Vector4(0.3922f, 0.9098f, 1.0f, 1.0f);
        public Vector4 NotificationOverlayNormalBgColor { get; set; } = new Vector4(0.0f, 0.0f, 0.0f, 1.0f);

        public bool DebugOnlyLogAutomarkers { get; set; } = false;

        public bool TTSEnabled { get; set; } = true;
        public bool TTSAllNotifications { get; set; } = false;
        public int TTSSpeed { get; set; } = 0;
        public int TTSVolume { get; set; } = 50;

        public string PropertyBlob { get; set; } = "";

        internal AutomarkerTiming DefaultAutomarkerTiming = new AutomarkerTiming();

        public Config() 
        {
            TimelineLocalFolder = Path.GetTempPath();
        }

        public float AutomarkerIniDelayMin
        {
            get
            {
                return DefaultAutomarkerTiming.IniDelayMin;
            }
            set
            {
                DefaultAutomarkerTiming.IniDelayMin = value;
            }
        }

        public float AutomarkerIniDelayMax
        {
            get
            {
                return DefaultAutomarkerTiming.IniDelayMax;
            }
            set
            {
                DefaultAutomarkerTiming.IniDelayMax = value;
            }
        }

        public float AutomarkerSubDelayMin
        {
            get
            {
                return DefaultAutomarkerTiming.SubDelayMin;
            }
            set
            {
                DefaultAutomarkerTiming.SubDelayMin = value;
            }
        }

        public float AutomarkerSubDelayMax
        {
            get
            {
                return DefaultAutomarkerTiming.SubDelayMax;
            }
            set
            {
                DefaultAutomarkerTiming.SubDelayMax = value;
            }
        }

    }

}
