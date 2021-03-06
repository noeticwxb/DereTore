﻿namespace StarlightDirector.Exchange.Deleste {
    internal static class Constants {

        public static readonly string[] BeatmapCommands = {
            "#changeattribute",
            "#measure",
            "@group_flick"
        };

        public static readonly string BpmCommand = "#bpm";
        public static readonly string ChangeBpmCommand = "#changebpm";
        public static readonly string OffsetCommand = "#offset";
        // Not supported for now. May be integrated in future versions.
        public static readonly string DifficultyCommand = "#difficulty";

        public static readonly int DefaultSignature = 4;

        // We avoid using Environment.NewLine, for format consistency.
        public static readonly string NewLine = "\n";

    }
}
