﻿using System;

namespace ManagedBass.Dynamics
{
    /// <summary>
    /// Initialization flags to be used with <see cref="Bass.Init" />
    /// </summary>
    [Flags]
    public enum DeviceInitFlags
    {
        /// <summary>
        /// 0 = 16 bit, stereo, no 3D, no Latency calc, no Speaker Assignments
        /// </summary>
        Default = 0,

        /// <summary>
        /// Use 8 bit resolution, else 16 bit.
        /// </summary>
        Byte = 1,

        /// <summary>
        /// Use mono, else stereo.
        /// </summary>
        Mono = 2,

        /// <summary>
        /// Enable 3D functionality.
        /// Note: If this is not specified when initilizing BASS,
        /// then the <see cref="BassFlags.Bass3D"/> is ignored when loading/creating a sample/stream/music.
        /// </summary>
        Device3D = 4,

        /// <summary>
        /// Calculate device latency (<see cref="BassInfo"/> struct).
        /// </summary>
        Latency = 256,

        /// <summary>
        /// Use the Windows control panel setting to detect the number of speakers.
        /// Only use this option if BASS doesn't detect the correct number of supported
        /// speakers automatically and you want to force BASS to use the number of speakers
        /// as configured in the windows control panel.
        /// </summary>
        CPSpeakers = 1024,

        /// <summary>
        /// Force enabling of speaker assignment (always 8 speakers will be used regardless if the soundcard supports them).
        /// Only use this option if BASS doesn't detect the correct number of supported
        /// speakers automatically and you want to force BASS to use 8 speakers.
        /// </summary>
        ForcedSpeakerAssignment = 2048,

        /// <summary>
        /// Ignore speaker arrangement
        /// </summary>
        NoSpeakerAssignment = 4096,

        /// <summary>
        /// Linux-only: Initialize the device using the ALSA "dmix" plugin, else initialize the device for exclusive access.
        /// </summary>
        DMix = 8192,

        /// <summary>
        /// Set the device's output rate to freq, otherwise leave it as it is.
        /// </summary>
        Frequency = 16384,
    }
}