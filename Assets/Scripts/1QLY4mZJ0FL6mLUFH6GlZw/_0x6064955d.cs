using UnityEngine;

/// Persistence for stage progress. Every key is built inside the method that uses it:
/// a compile-time string constant becomes a decrypted runtime field after
/// obfuscation, and its initializer can be reordered below its first reader (C.52).
public sealed class _0x6064955d
{
    public int _0xc0dde847(int _0x8e59522c)
    {
        string _0xf9986b15 = _0x2ff34b48._0x193414a9(new byte[6] { 124, 107, 68, 99, 117, 114 }, 6) + _0x8e59522c.ToString();
        return PlayerPrefs.GetInt(_0xf9986b15, 0);
    }

    public bool _0xc978a968(int _0x984d8697)
    {
        string _0x658c6e36 = _0x2ff34b48._0x193414a9(new byte[6] { 175, 184, 145, 186, 187, 176 }, 213) + _0x984d8697.ToString();
        return PlayerPrefs.GetInt(_0x658c6e36, 0) == 1;
    }

    public int _0x37047479(int _0xfad31acb)
    {
        int _0xcc3ded8f = 0;
        for (int _0x88add0c5 = 0; _0x88add0c5 < _0xfad31acb; _0x88add0c5++)
            if (this._0xc978a968(_0x88add0c5))
                _0xcc3ded8f++;
        return _0xcc3ded8f;
    }

    public int _0x2fbb40ce
    {
        get
        {
            string _0x98fb806a = _0x2ff34b48._0x193414a9(new byte[5] { 12, 27, 37, 19, 26 }, 118);
            return PlayerPrefs.GetInt(_0x98fb806a, 2);
        }

        set
        {
            string _0xf1b77bd9 = _0x2ff34b48._0x193414a9(new byte[5] { 253, 234, 212, 226, 235 }, 135);
            PlayerPrefs.SetInt(_0xf1b77bd9, value);
            PlayerPrefs.Save();
        }
    }

    public void _0x3b28ada5(int _0xc71201ab, int _0xd1e556f7)
    {
        string _0x9817bfeb = _0x2ff34b48._0x193414a9(new byte[6] { 71, 80, 127, 88, 78, 73 }, 61) + _0xc71201ab.ToString();
        int _0x934cf663 = PlayerPrefs.GetInt(_0x9817bfeb, 0);
        if (_0x934cf663 <= 0 || _0xd1e556f7 < _0x934cf663)
        {
            PlayerPrefs.SetInt(_0x9817bfeb, _0xd1e556f7);
            PlayerPrefs.Save();
        }
    }

    public void _0x40266852(int _0x43258169)
    {
        string _0xb28e48ee = _0x2ff34b48._0x193414a9(new byte[6] { 141, 154, 179, 152, 153, 146 }, 247) + _0x43258169.ToString();
        PlayerPrefs.SetInt(_0xb28e48ee, 1);
        PlayerPrefs.Save();
    }
}

internal static class _0x2ff34b48
{
    internal static string _0x193414a9(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}