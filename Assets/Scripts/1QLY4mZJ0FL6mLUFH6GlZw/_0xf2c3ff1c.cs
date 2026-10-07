/// The seven tile shapes the art ships, described the way the sprites are drawn.
/// Pure functions only - no static fields, because Plana's string encryption turns a
/// static readonly table into a runtime initializer whose order it is free to move
/// (CLAUDE-unity.md C.52).
public static class _0xf2c3ff1c
{
    /// How many clockwise turns bring the shape back onto itself.
    public static int Period(int _0xb38fb954)
    {
        switch (_0xb38fb954)
        {
            case Line:
                return 3;
            case Fork:
                return 2;
            case Blank:
                return 1;
            default:
                return 6;
        }
    }

    public const int Count = 9;
    /// Edge mask of each shape as the PNG is drawn (0 NE, 1 E, 2 SE, 3 SW, 4 W, 5 NW).
    public static int BaseMask(int _0xfddf75d4)
    {
        switch (_0xfddf75d4)
        {
            case CapCloud:
                return 1; // one arm leaving the UPPER-RIGHT edge
            case CapBolt:
                return 1;
            case CapRosette:
                return 1;
            case Line:
                return (1 << 1) | (1 << 4); // straight bar, LEFT <-> RIGHT
            case Bend:
                return (1 << 4) | 1; // LEFT <-> UPPER-RIGHT
            case Fork:
                return 1 | (1 << 2) | (1 << 4); // Y: UPPER-RIGHT, LOWER-RIGHT, LEFT
            case Elbow:
                return 1 | (1 << 1); // short turn, UPPER-RIGHT <-> RIGHT
            case Tee:
                return 1 | (1 << 1) | (1 << 3); // UPPER-RIGHT, RIGHT, LOWER-LEFT
            default:
                return 0;
        }
    }

    /// A mask is drawable only if some shape, turned some number of steps, equals it.
    public static bool TryResolve(int _0x61a1ef61, out int _0x1fa0e3e9, out int _0xf818c57a)
    {
        for (int _0xeb8a916f = 0; _0xeb8a916f < Count; _0xeb8a916f++)
        {
            int _0x7277fa8a = BaseMask(_0xeb8a916f);
            for (int _0x17815702 = 0; _0x17815702 < 6; _0x17815702++)
            {
                if (_0x6ef3ea18.RotateMask(_0x7277fa8a, _0x17815702) == _0x61a1ef61)
                {
                    _0x1fa0e3e9 = _0xeb8a916f;
                    _0xf818c57a = _0x17815702;
                    return true;
                }
            }
        }

        _0x1fa0e3e9 = Blank;
        _0xf818c57a = 0;
        return false;
    }

    public const int CapBolt = 2;
    /// Shortest number of clockwise turns from one mask of this shape to another.
    public static int TurnsBetween(int _0xf8ae262a, int _0x49ec161a, int _0x24255f4f)
    {
        int _0x910d7fdf = Period(_0xf8ae262a);
        for (int _0x4f4a137b = 0; _0x4f4a137b < _0x910d7fdf; _0x4f4a137b++)
            if (_0x6ef3ea18.RotateMask(_0x49ec161a, _0x4f4a137b) == _0x24255f4f)
                return _0x4f4a137b;
        return 0;
    }

    public const int Elbow = 7;
    public const int Line = 4;
    public const int CapRosette = 3;
    public const int Tee = 8;
    public const int CapCloud = 1;
    public const int Blank = 0;
    public const int Fork = 6;
    public const int Bend = 5;
}