using UnityEngine;

/// The eight stages, described by the knobs the generator understands. Everything is
/// built inside instance methods: a static readonly table would become a runtime
/// initializer after string encryption and could be ordered after its first reader
/// (CLAUDE-unity.md C.52).
public sealed class _0xbcadf24b
{
    /// Spare turns on top of the minimum: generous early, tight at the end.
    public float _0x2bd1d11e(int _0xef3504a1)
    {
        switch (this._0xfa6a6d7f(_0xef3504a1))
        {
            case 0:
                return 2.0f;
            case 1:
                return 1.9f;
            case 2:
                return 1.8f;
            case 3:
                return 1.7f;
            case 4:
                return 1.6f;
            case 5:
                return 1.5f;
            case 6:
                return 1.4f;
            default:
                return 1.35f;
        }
    }

    public int _0xb29ba43a
    {
        get
        {
            return 8;
        }
    }

    public int _0x19cc4843(int _0x19bfb8d4, int _0x9c4626b5)
    {
        float _0x11f23e3a = this._0x2bd1d11e(_0x19bfb8d4);
        return Mathf.Clamp(Mathf.CeilToInt(_0x9c4626b5 * _0x11f23e3a) + 6, 18, 140);
    }

    public string _0xb3e6655a(int _0x8a3a7ddc)
    {
        switch (this._0xfa6a6d7f(_0x8a3a7ddc))
        {
            case 0:
                return _0xc29af37f._0x8200906e(new byte[11] { 29, 18, 9, 8, 15, 123, 23, 18, 28, 19, 15 }, 91);
            case 1:
                return _0xc29af37f._0x8200906e(new byte[10] { 74, 69, 70, 92, 77, 41, 78, 72, 93, 76 }, 9);
            case 2:
                return _0xc29af37f._0x8200906e(new byte[13] { 160, 164, 181, 169, 164, 179, 193, 163, 179, 168, 165, 166, 164 }, 225);
            case 3:
                return _0xc29af37f._0x8200906e(new byte[13] { 47, 40, 51, 46, 49, 92, 40, 57, 46, 46, 61, 63, 57 }, 124);
            case 4:
                return _0xc29af37f._0x8200906e(new byte[13] { 222, 214, 213, 221, 220, 215, 185, 202, 201, 208, 203, 216, 213 }, 153);
            case 5:
                return _0xc29af37f._0x8200906e(new byte[13] { 154, 134, 155, 128, 138, 139, 156, 238, 141, 156, 129, 153, 128 }, 206);
            case 6:
                return _0xc29af37f._0x8200906e(new byte[14] { 44, 47, 58, 46, 51, 42, 34, 45, 67, 53, 34, 54, 47, 55 }, 99);
            default:
                return _0xc29af37f._0x8200906e(new byte[13] { 128, 152, 138, 149, 146, 159, 159, 243, 132, 150, 146, 133, 150 }, 211);
        }
    }

    /// How far a stone may be turned away from its home position. This is the real
    /// difficulty dial: it bounds the minimum number of taps a perfect player needs.
    public int _0xc9538c89(int _0x5f1bf082)
    {
        switch (this._0xfa6a6d7f(_0x5f1bf082))
        {
            case 0:
                return 1;
            case 1:
                return 1;
            case 2:
                return 2;
            case 3:
                return 2;
            case 4:
                return 3;
            case 5:
                return 3;
            case 6:
                return 4;
            default:
                return 4;
        }
    }

    public int _0x6f9753a4(int _0xa85e76e0)
    {
        switch (this._0xfa6a6d7f(_0xa85e76e0))
        {
            case 0:
                return 0;
            case 1:
                return 1;
            case 2:
                return 1;
            case 3:
                return 2;
            case 4:
                return 2;
            case 5:
                return 3;
            case 6:
                return 4;
            default:
                return 5;
        }
    }

    public int _0x7e933b78(int _0xd5fdcf12)
    {
        return this._0xfa6a6d7f(_0xd5fdcf12) <= 1 ? 1 : 2;
    }

    public int _0xfa6a6d7f(int _0x028a08f6)
    {
        int _0xf583e16a = this._0xb29ba43a;
        int _0x41c27762 = _0x028a08f6 % _0xf583e16a;
        return _0x41c27762 < 0 ? _0x41c27762 + _0xf583e16a : _0x41c27762;
    }
}

internal static class _0xc29af37f
{
    internal static string _0x8200906e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}