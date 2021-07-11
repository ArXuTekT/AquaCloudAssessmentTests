using System;

namespace AquaCloudTestApp2.Classes
{
    [Flags]
    public enum EDirections
    {
        None    = 0,
        Top     = 1 << 0,
        Bottom  = 1 << 1,
        Left    = 1 << 2,
        Right   = 1 << 3

    }
}
