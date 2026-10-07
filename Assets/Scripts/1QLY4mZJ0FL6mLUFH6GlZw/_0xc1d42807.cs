using UnityEngine;

/// Board metrics for a pointy-top hex field, derived ONLY from the scene camera
/// (CLAUDE-unity.md C.0): nothing here is a hand-picked constant, so the field keeps
/// its proportions on any aspect, including the landscape sides autorotation allows.
public sealed class _0xc1d42807
{
    private readonly float _0xde9bb227;
    private const float Sqrt3 = 1.7320508f;
    private readonly float _0x5e73ad2c;
    private readonly float _0xc2ddb6bd;
    private readonly float _0xdcbf8f49;
    private readonly float _0x2399373f;
    public float _0x3c349734
    {
        get
        {
            return this._0xc2ddb6bd;
        }
    }

    public float _0x6031651a
    {
        get
        {
            return this._0x5e73ad2c;
        }
    }

    public int _0x75d71c29
    {
        get
        {
            return this._0x24fd4296;
        }
    }

    public _0xc1d42807(float _0xa7b3e3a6, float _0xfc719dda, int _0x860c3938, float _0x75e17a5a)
    {
        this._0x24fd4296 = _0x860c3938 < 1 ? 1 : _0x860c3938;
        float _0x6811974a = _0xa7b3e3a6;
        float _0xb16adc38 = _0xa7b3e3a6 * _0xfc719dda;
        int _0xce551deb = 2 * this._0x24fd4296 + 1;
        // clamp by BOTH axes: in landscape the height budget is the binding one
        float _0xee52028f = 0.86f * 2f * _0xb16adc38;
        float _0x074b66ba = 0.62f * 2f * _0x6811974a;
        float _0xb0ace245 = 2f * this._0x24fd4296 * 0.8660254f + 1.1547005f;
        this._0xde9bb227 = Mathf.Min(_0xee52028f / _0xce551deb, _0x074b66ba / _0xb0ace245);
        this._0x6b0d32b6 = this._0xde9bb227 / Sqrt3;
        this._0xd59cc9ad = 2f * this._0x6b0d32b6;
        this._0xc2ddb6bd = 1.5f * this._0x6b0d32b6;
        this._0x5e73ad2c = _0x75e17a5a;
        this._0xdcbf8f49 = _0xce551deb * this._0xde9bb227;
        this._0x2399373f = 2f * this._0x24fd4296 * this._0xc2ddb6bd + this._0xd59cc9ad;
    }

    private readonly float _0xd59cc9ad;
    public float _0x69336897
    {
        get
        {
            return this._0x6b0d32b6;
        }
    }

    public float _0x4b311a29
    {
        get
        {
            return this._0x2399373f;
        }
    }

    public float _0x0aca3214
    {
        get
        {
            return this._0xde9bb227;
        }
    }

    public float _0x83079a50
    {
        get
        {
            return this._0xdcbf8f49;
        }
    }

    public float _0xe9f620d0
    {
        get
        {
            return this._0xd59cc9ad;
        }
    }

    private readonly int _0x24fd4296;
    /// Axial (q, r) -> world position. r grows downwards, q along the row.
    public Vector2 _0xbdd4da31(int _0x50d6bc42, int _0x214112cf)
    {
        float _0xb53aeb84 = this._0xde9bb227 * (_0x50d6bc42 + _0x214112cf * 0.5f);
        float _0x3a1beda0 = this._0x5e73ad2c - this._0xc2ddb6bd * _0x214112cf;
        return new Vector2(_0xb53aeb84, _0x3a1beda0);
    }

    private readonly float _0x6b0d32b6;
}