using System.Collections.Generic;
using UnityEngine;

/// Builds a fresh, always-solvable field for one attempt at one trial (C.11): a
/// randomised Prim tree over the hex graph, optional extra loops, then a scramble.
/// Because the scrambled field is reached BY TURNING a solved one, turning it back is
/// always possible - solvability is a property of the construction, not a hope.
public sealed class _0x389ad784
{
    private void Join(int[] _0x9fe844c7, int _0xc40c8503, int _0x9c451091, int _0x29715dc1)
    {
        _0x9fe844c7[_0xc40c8503] |= 1 << _0x29715dc1;
        _0x9fe844c7[_0x9c451091] |= 1 << _0x6ef3ea18.Opposite(_0x29715dc1);
    }

    private int[] _0x2eddb6f0;
    public void _0xc607c090(int _0x47a6e888, int _0xcc1398bd, int _0xaa5c2a9f, int _0x7be81238, int _0xdca8c225)
    {
        this._0xc1dc1b4d = (_0x47a6e888 * 7919) ^ (_0xcc1398bd * 104729);
        System.Random _0x9a8c0f5d = new System.Random(this._0xc1dc1b4d);
        this._0x13e86c34 = new _0x6ef3ea18(_0xaa5c2a9f);
        int _0x4b7b5783 = this._0x13e86c34._0xf94c1b7e;
        int[] _0x849b4a04 = new int[_0x4b7b5783];
        int _0x22f67cb1 = this._0xf9d041e0();
        this._0xcaefbd94(_0x9a8c0f5d, _0x849b4a04, _0x22f67cb1);
        this._0x307a5178(_0x9a8c0f5d, _0x849b4a04, _0x7be81238);
        this._0x542a62af(_0x9a8c0f5d, _0x849b4a04);
        this._0x2eddb6f0 = new int[_0x4b7b5783];
        for (int _0x29c1c782 = 0; _0x29c1c782 < _0x4b7b5783; _0x29c1c782++)
        {
            this._0x2eddb6f0[_0x29c1c782] = _0x849b4a04[_0x29c1c782];
            this._0x13e86c34._0x73920ce5(_0x29c1c782, _0x849b4a04[_0x29c1c782]);
        }

        this._0x576e629b = this._0x559c5d2e(_0x9a8c0f5d, _0xdca8c225);
        {
#if B_LOGS
            {
                Debug.Log(_0x22699e7b._0x261843a3(new byte[13] { 128, 175, 169, 178, 186, 183, 134, 251, 168, 190, 190, 191, 230 }, 219) + this._0xc1dc1b4d + _0x22699e7b._0x261843a3(new byte[8] { 129, 211, 192, 197, 200, 212, 210, 156 }, 161) + _0xaa5c2a9f + _0x22699e7b._0x261843a3(new byte[10] { 29, 80, 84, 83, 105, 72, 79, 83, 78, 0 }, 61) + this._0x576e629b);
            }
#endif
        }
    }

    public _0x6ef3ea18 _0xc0be3e16
    {
        get
        {
            return this._0x13e86c34;
        }
    }

    /// A mask is usable only if one of the drawn shapes, turned some number of steps,
    /// is exactly it. Defining it this way keeps the generator and the art in step by
    /// construction instead of by a second hand-written table.
    private bool _0x4e37a901(int _0xaf35411b)
    {
        int _0x61555a9b;
        int _0xd810c37b;
        return _0xf2c3ff1c.TryResolve(_0xaf35411b, out _0x61555a9b, out _0xd810c37b);
    }

    private int _0x576e629b;
    public int[] _0xf4c2f015
    {
        get
        {
            return this._0x2eddb6f0;
        }
    }

    private int _0xc1dc1b4d;
    private int _0xf9d041e0()
    {
        for (int _0xd1a130a9 = 0; _0xd1a130a9 < this._0x13e86c34._0xf94c1b7e; _0xd1a130a9++)
            if (this._0x13e86c34._0x25b5e108(_0xd1a130a9) == 0 && this._0x13e86c34._0xf701af3f(_0xd1a130a9) == 0)
                return _0xd1a130a9;
        return 0;
    }

    private void _0x307a5178(System.Random _0x12d593d4, int[] _0xb034e43f, int _0x261faa92)
    {
        int _0xa7cff0cb = this._0x13e86c34._0xf94c1b7e;
        int _0x9f6d1ca7 = 0;
        int _0x69e12599 = 0;
        while (_0x9f6d1ca7 < _0x261faa92 && _0x69e12599 < 400)
        {
            _0x69e12599++;
            int _0x62189280 = _0x12d593d4.Next(_0xa7cff0cb);
            int _0x264b08d5 = _0x12d593d4.Next(_0x6ef3ea18.EdgeCount);
            int _0xd2487f70 = this._0x13e86c34._0xf3f4f447(_0x62189280, _0x264b08d5);
            if (_0xd2487f70 < 0 || _0xb034e43f[_0x62189280] == 0 || _0xb034e43f[_0xd2487f70] == 0)
                continue;
            if ((_0xb034e43f[_0x62189280] & (1 << _0x264b08d5)) != 0)
                continue;
            if (!this._0x8e68ea10(_0xb034e43f, _0x62189280, _0xd2487f70, _0x264b08d5))
                continue;
            this.Join(_0xb034e43f, _0x62189280, _0xd2487f70, _0x264b08d5);
            _0x9f6d1ca7++;
        }
    }

    private void _0xcaefbd94(System.Random _0xf6864c26, int[] _0xac118be2, int _0xf6f465b8)
    {
        int _0x19a81b24 = this._0x13e86c34._0xf94c1b7e;
        bool[] _0xe9051c70 = new bool[_0x19a81b24];
        _0xe9051c70[_0xf6f465b8] = true;
        List<int> _0x1a02642b = new List<int>();
        _0x1a02642b.Add(_0xf6f465b8);
        while (_0x1a02642b.Count > 0)
        {
            int _0x64af9d74 = _0xf6864c26.Next(_0x1a02642b.Count);
            int _0x4af5b3f9 = _0x1a02642b[_0x64af9d74];
            List<int> _0x46d942be = new List<int>();
            for (int _0x99e6d3c6 = 0; _0x99e6d3c6 < _0x6ef3ea18.EdgeCount; _0x99e6d3c6++)
            {
                int _0x09b7be58 = this._0x13e86c34._0xf3f4f447(_0x4af5b3f9, _0x99e6d3c6);
                if (_0x09b7be58 < 0 || _0xe9051c70[_0x09b7be58])
                    continue;
                if (this._0x8e68ea10(_0xac118be2, _0x4af5b3f9, _0x09b7be58, _0x99e6d3c6))
                    _0x46d942be.Add(_0x99e6d3c6);
            }

            if (_0x46d942be.Count == 0)
            {
                _0x1a02642b.RemoveAt(_0x64af9d74);
                continue;
            }

            int _0xb6b17bd7 = _0x46d942be[_0xf6864c26.Next(_0x46d942be.Count)];
            int _0x5179030d = this._0x13e86c34._0xf3f4f447(_0x4af5b3f9, _0xb6b17bd7);
            this.Join(_0xac118be2, _0x4af5b3f9, _0x5179030d, _0xb6b17bd7);
            _0xe9051c70[_0x5179030d] = true;
            _0x1a02642b.Add(_0x5179030d);
        }

        // Sweep again until nothing more can be attached: a cell the walk could not
        // reach still deserves a path, and attaching one opens options for the next.
        // Only a cell boxed in by shapes that cannot take another arm stays bare.
        bool _0x36f9bbfa = true;
        while (_0x36f9bbfa)
        {
            _0x36f9bbfa = false;
            for (int _0x72dc2181 = 0; _0x72dc2181 < _0x19a81b24; _0x72dc2181++)
            {
                if (_0xe9051c70[_0x72dc2181])
                    continue;
                int _0xb07804f7 = _0xf6864c26.Next(_0x6ef3ea18.EdgeCount);
                for (int _0x4fb66e07 = 0; _0x4fb66e07 < _0x6ef3ea18.EdgeCount; _0x4fb66e07++)
                {
                    int _0x27dd767a = (_0x4fb66e07 + _0xb07804f7) % _0x6ef3ea18.EdgeCount;
                    int _0x0b3f7bfe = this._0x13e86c34._0xf3f4f447(_0x72dc2181, _0x27dd767a);
                    if (_0x0b3f7bfe < 0 || !_0xe9051c70[_0x0b3f7bfe] || !this._0x8e68ea10(_0xac118be2, _0x72dc2181, _0x0b3f7bfe, _0x27dd767a))
                        continue;
                    this.Join(_0xac118be2, _0x72dc2181, _0x0b3f7bfe, _0x27dd767a);
                    _0xe9051c70[_0x72dc2181] = true;
                    _0x36f9bbfa = true;
                    break;
                }
            }
        }
    }

    private void _0x542a62af(System.Random _0x8e268eb1, int[] _0x0f541918)
    {
        int _0x52c9abc1 = _0x8e268eb1.Next(3);
        for (int _0x5befa74a = 0; _0x5befa74a < this._0x13e86c34._0xf94c1b7e; _0x5befa74a++)
        {
            int _0x5fee016a = _0x6ef3ea18.PopCount(_0x0f541918[_0x5befa74a]);
            int _0x0c113c86;
            if (_0x5fee016a == 1)
            {
                _0x0c113c86 = _0xf2c3ff1c.CapCloud + (_0x52c9abc1 % 3);
                _0x52c9abc1++;
            }
            else
            {
                int _0xc4fefad6;
                int _0xabb7a613;
                if (!_0xf2c3ff1c.TryResolve(_0x0f541918[_0x5befa74a], out _0xc4fefad6, out _0xabb7a613))
                {
                    _0x0f541918[_0x5befa74a] = 0;
                    _0xc4fefad6 = _0xf2c3ff1c.Blank;
                }

                _0x0c113c86 = _0xc4fefad6;
            }

            this._0x13e86c34._0x930fc51e(_0x5befa74a, _0x0c113c86);
        }
    }

    public int _0x787fae4e
    {
        get
        {
            return this._0xc1dc1b4d;
        }
    }

    /// Turn each stone back by at most `maxBack` steps, which is both the scramble and
    /// the difficulty dial: the reported number is exactly how many taps a perfect
    /// player needs, so the budget in TrialCatalog can be checked against it.
    private int _0x559c5d2e(System.Random _0x6b274482, int _0xc0c01044)
    {
        int _0xa1cd08a4 = 0;
        for (int _0x5767e5b8 = 0; _0x5767e5b8 < 20; _0x5767e5b8++)
        {
            int _0xcc1e11cf = 0;
            for (int _0xe3533bbd = 0; _0xe3533bbd < this._0x13e86c34._0xf94c1b7e; _0xe3533bbd++)
            {
                int _0xbdcebe68 = _0xf2c3ff1c.Period(this._0x13e86c34._0xc52a22cc(_0xe3533bbd));
                int _0xb7b68ad0 = _0xbdcebe68 - 1;
                if (_0xb7b68ad0 > _0xc0c01044)
                    _0xb7b68ad0 = _0xc0c01044;
                int back = _0xb7b68ad0 <= 0 ? 0 : _0x6b274482.Next(_0xb7b68ad0 + 1);
                this._0x13e86c34._0x73920ce5(_0xe3533bbd, _0x6ef3ea18.RotateMask(this._0x2eddb6f0[_0xe3533bbd], back == 0 ? 0 : _0xbdcebe68 - back));
                _0xcc1e11cf += back;
            }

            _0xa1cd08a4 = _0xcc1e11cf;
            if (_0xcc1e11cf >= 4)
                return _0xcc1e11cf;
        }

        if (_0xa1cd08a4 > 0)
            return _0xa1cd08a4;
        // a field that starts solved would end the moment it is touched
        for (int _0xf6b6e0b4 = 0; _0xf6b6e0b4 < this._0x13e86c34._0xf94c1b7e; _0xf6b6e0b4++)
        {
            int _0x61693768 = _0xf2c3ff1c.Period(this._0x13e86c34._0xc52a22cc(_0xf6b6e0b4));
            if (_0x61693768 <= 1)
                continue;
            this._0x13e86c34._0x73920ce5(_0xf6b6e0b4, _0x6ef3ea18.RotateMask(this._0x2eddb6f0[_0xf6b6e0b4], _0x61693768 - 1));
            return 1;
        }

        return 0;
    }

    private _0x6ef3ea18 _0x13e86c34;
    private bool _0x8e68ea10(int[] _0x27ff8157, int _0x995c4fe4, int _0xd23b1ad0, int _0x21614275)
    {
        return this._0x4e37a901(_0x27ff8157[_0x995c4fe4] | (1 << _0x21614275)) && this._0x4e37a901(_0x27ff8157[_0xd23b1ad0] | (1 << _0x6ef3ea18.Opposite(_0x21614275)));
    }

    public int _0x3fc639d9
    {
        get
        {
            return this._0x576e629b;
        }
    }
}

internal static class _0x22699e7b
{
    internal static string _0x261843a3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}