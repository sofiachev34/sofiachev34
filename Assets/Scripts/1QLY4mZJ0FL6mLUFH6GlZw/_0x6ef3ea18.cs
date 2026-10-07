using System.Collections.Generic;

/// The puzzle itself: a hexagonal field of cells, each holding a 6-bit edge mask.
/// Edge order is clockwise from the upper-right: 0 NE, 1 E, 2 SE, 3 SW, 4 W, 5 NW,
/// so one clockwise turn is a single-bit rotate and the opposite edge is (e + 3) % 6.
public sealed class _0x6ef3ea18
{
    public int _0x25b5e108(int _0x54bb5e5f)
    {
        return this._0x0bf77fdb[_0x54bb5e5f];
    }

    private readonly int[] _0xaa9cf84c = new int[]
    {
        -1,
        0,
        1,
        1,
        0,
        -1
    };
    private readonly List<int> _0xfc491ee8 = new List<int>();
    public int _0xf94c1b7e
    {
        get
        {
            return this._0x0bf77fdb.Count;
        }
    }

    public int _0x28aa9d50()
    {
        int _0xdbb0c005 = 0;
        for (int _0xe6825d3c = 0; _0xe6825d3c < this._0xfc491ee8.Count; _0xe6825d3c++)
            _0xdbb0c005 += PopCount(this._0xfc491ee8[_0xe6825d3c]);
        return _0xdbb0c005 / 2;
    }

    private readonly List<int> _0x045ca04c = new List<int>();
    public int _0xc52a22cc(int _0xb616b2cb)
    {
        return this._0x045ca04c[_0xb616b2cb];
    }

    public _0x6ef3ea18(int _0x3622378f)
    {
        this._0x421ff97b = _0x3622378f;
        for (int _0xb4376714 = -_0x3622378f; _0xb4376714 <= _0x3622378f; _0xb4376714++)
        {
            int _0x1bfdee05 = -_0x3622378f > -_0x3622378f - _0xb4376714 ? -_0x3622378f : -_0x3622378f - _0xb4376714;
            int _0xbc7355fe = _0x3622378f < _0x3622378f - _0xb4376714 ? _0x3622378f : _0x3622378f - _0xb4376714;
            for (int _0x17a879ac = _0x1bfdee05; _0x17a879ac <= _0xbc7355fe; _0x17a879ac++)
            {
                this._0x96360293[Key(_0x17a879ac, _0xb4376714)] = this._0x0bf77fdb.Count;
                this._0x0bf77fdb.Add(_0x17a879ac);
                this._0x7976a310.Add(_0xb4376714);
                this._0xfc491ee8.Add(0);
                this._0x045ca04c.Add(0);
            }
        }
    }

    /// Ends that currently meet an end on the far side, counted as pairs.
    public int _0x769e9bf2()
    {
        int _0x9028f2fd = 0;
        for (int _0x0f9d0b3e = 0; _0x0f9d0b3e < this._0xfc491ee8.Count; _0x0f9d0b3e++)
        {
            for (int _0xd1fa96ce = 0; _0xd1fa96ce < EdgeCount; _0xd1fa96ce++)
            {
                if ((this._0xfc491ee8[_0x0f9d0b3e] & (1 << _0xd1fa96ce)) == 0)
                    continue;
                int _0x1d5eb84b = this._0xf3f4f447(_0x0f9d0b3e, _0xd1fa96ce);
                if (_0x1d5eb84b >= 0 && (this._0xfc491ee8[_0x1d5eb84b] & (1 << Opposite(_0xd1fa96ce))) != 0)
                    _0x9028f2fd++;
            }
        }

        return _0x9028f2fd / 2;
    }

    private readonly List<int> _0x7976a310 = new List<int>();
    private readonly int _0x421ff97b;
    private readonly List<int> _0x0bf77fdb = new List<int>();
    public static int PopCount(int _0x8ed8a1b0)
    {
        int _0x019bc7ca = 0;
        for (int _0x522d5fd8 = 0; _0x522d5fd8 < EdgeCount; _0x522d5fd8++)
            if ((_0x8ed8a1b0 & (1 << _0x522d5fd8)) != 0)
                _0x019bc7ca++;
        return _0x019bc7ca;
    }

    public void _0x930fc51e(int _0x66cada7a, int _0x16645a52)
    {
        this._0x045ca04c[_0x66cada7a] = _0x16645a52;
    }

    public void _0x73920ce5(int _0xd76b1259, int _0x7b6bb5a3)
    {
        this._0xfc491ee8[_0xd76b1259] = _0x7b6bb5a3 & MaskAll;
    }

    private readonly Dictionary<int, int> _0x96360293 = new Dictionary<int, int>();
    public const int EdgeCount = 6;
    private static int Key(int _0xa29a5aac, int _0x30275723)
    {
        return (_0xa29a5aac + 64) * 256 + (_0x30275723 + 64);
    }

    public int _0xf3f4f447(int _0xd64d9f79, int _0x78f46116)
    {
        int _0x6a181ad3 = Key(this._0x0bf77fdb[_0xd64d9f79] + this._0xa547e87a[_0x78f46116], this._0x7976a310[_0xd64d9f79] + this._0xaa9cf84c[_0x78f46116]);
        int _0xdefc5acf;
        if (this._0x96360293.TryGetValue(_0x6a181ad3, out _0xdefc5acf))
            return _0xdefc5acf;
        return -1;
    }

    private readonly int[] _0xa547e87a = new int[]
    {
        1,
        1,
        0,
        -1,
        -1,
        0
    };
    public void _0xfcc2abb4(int _0xc70a11ea, int _0x94015c47)
    {
        this._0xfc491ee8[_0xc70a11ea] = RotateMask(this._0xfc491ee8[_0xc70a11ea], _0x94015c47);
    }

    public bool _0xdf1a7bc1()
    {
        for (int _0x4852b2da = 0; _0x4852b2da < this._0xfc491ee8.Count; _0x4852b2da++)
        {
            for (int _0x696746aa = 0; _0x696746aa < EdgeCount; _0x696746aa++)
            {
                if ((this._0xfc491ee8[_0x4852b2da] & (1 << _0x696746aa)) == 0)
                    continue;
                int _0x89af9cfd = this._0xf3f4f447(_0x4852b2da, _0x696746aa);
                if (_0x89af9cfd < 0 || (this._0xfc491ee8[_0x89af9cfd] & (1 << Opposite(_0x696746aa))) == 0)
                    return false;
            }
        }

        return true;
    }

    public int _0x66019758
    {
        get
        {
            return this._0x421ff97b;
        }
    }

    public int _0xf701af3f(int _0xd0f86362)
    {
        return this._0x7976a310[_0xd0f86362];
    }

    public const int MaskAll = 0x3F;
    public static int Opposite(int _0x7b59f5ce)
    {
        return (_0x7b59f5ce + 3) % EdgeCount;
    }

    public int _0xbc62c423(int _0x588a3d2d)
    {
        return this._0xfc491ee8[_0x588a3d2d];
    }

    public static int RotateMask(int _0x33972767, int _0xc38fe60e)
    {
        int _0x1aa695e7 = _0x33972767 & MaskAll;
        int _0x5975510a = ((_0xc38fe60e % EdgeCount) + EdgeCount) % EdgeCount;
        return ((_0x1aa695e7 << _0x5975510a) | (_0x1aa695e7 >> (EdgeCount - _0x5975510a))) & MaskAll;
    }
}