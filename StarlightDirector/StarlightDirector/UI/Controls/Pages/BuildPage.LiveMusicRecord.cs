﻿using StarlightDirector.Entities.Gaming;

namespace StarlightDirector.UI.Controls.Pages {
    partial class BuildPage {

        private class LiveMusicRecord {

            public int LiveID { get; set; }
            public int MusicID { get; set; }
            public string MusicName { get; set; }
            public bool[] DifficultyExists { get; internal set; }
            public MusicAttribute Attribute { get; set; }

        }

    }
}
