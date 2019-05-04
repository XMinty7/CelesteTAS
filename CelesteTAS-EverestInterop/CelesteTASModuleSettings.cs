﻿using Celeste;
using Celeste.Mod;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TAS.EverestInterop {
    public class CelesteTASModuleSettings : EverestModuleSettings {

        public bool Enabled { get; set; } = true;

		public bool SimplifiedGraphics { get; set; } = false;
		public List<Buttons> ButtonGraphics { get; set; } = new List<Buttons>();
		public List<Keys> KeyGraphics { get; set; } = new List<Keys>();

		public bool ShowHitboxes {
			get => GameplayRendererExt.RenderDebug;
			set => GameplayRendererExt.RenderDebug = value;
		}
		public List<Buttons> ButtonHitboxes { get; set; } = new List<Buttons>();
        public List<Keys> KeyHitboxes { get; set; } = new List<Keys>();

        public bool ShowPathfinding { get; set; } = false;
        public List<Buttons> ButtonPathfinding { get; set; } = new List<Buttons>();
        public List<Keys> KeyPathfinding { get; set; } = new List<Keys>();

		public bool DisableAchievements { get; set; } = false;

		[SettingIgnore]
        public bool FastForwardCallBase { get; set; } = false;
        [SettingIgnore]
        public int FastForwardThreshold { get; set; } = 10;

    }
}
