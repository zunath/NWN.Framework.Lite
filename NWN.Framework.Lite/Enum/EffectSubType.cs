using System;

namespace NWN.Framework.Lite.Enum
{
    [Flags]
    public enum EffectSubType
    {
        Magical = 8,
        Supernatural = 16,
        Extraordinary = 24,
        Mask = 0x18
    }
}