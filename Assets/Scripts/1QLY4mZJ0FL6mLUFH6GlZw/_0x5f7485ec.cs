using DG.Tweening;
using UnityEngine;

/// Runs one attempt at one trial: build the field, spend turns on taps, decide the
/// ending. Nothing here is on a clock - the only resource is turns and only the player
/// spends them, so an untouched run lasts forever and always outlives the review
/// capture window (CLAUDE-unity.md C.5).
public sealed class _0x5f7485ec : MonoBehaviour
{
    private readonly _0xbcadf24b _0xc099b698 = new _0xbcadf24b();
    private int _0x459d11bd;
    private void _0x6bb623d2()
    {
        this._0xc54d205a = true;
        int _0x63b1d154 = this._0xbab07b0c - this._0x459d11bd;
        int _0x5e305d08 = 10 + (_0x63b1d154 < 0 ? 0 : _0x63b1d154) * 2;
        this._0x4c22b490._0x3b28ada5(this._0x86b35a50, this._0x459d11bd);
        this._0x4c22b490._0x40266852(this._0x86b35a50);
        _0xb39a7050._0xf9f3518f._0xcbf50c6c = _0xb39a7050._0xf9f3518f._0xcbf50c6c + _0x5e305d08;
        if (this._motes != null && this._boardView != null && this._boardView._0xd9c16682 != null)
            this._motes._0x088bd569(new Vector2(0f, this._boardView._0xd9c16682._0x6031651a), this._boardView._0xd9c16682._0xe9f620d0);
        if (this._boardView != null)
            this._boardView._0x29321f6e();
        string _0x2be0b98e = this._0xc099b698._0xb3e6655a(this._0x86b35a50);
        // the next stage becomes the selected one, so the pop's right-hand button
        // (the template's reload-this-scene driver) reads as NEXT TRIAL
        this._0x4c22b490._0x2fbb40ce = this._0xc099b698._0xfa6a6d7f(this._0x86b35a50 + 1);
        if (this._pops != null)
        {
            this._pops._0x9f1b2a5d(_0x2be0b98e, this._0x459d11bd);
        }

        DOVirtual.DelayedCall(0.6f, () => this._0x82929aa8());
    }

    private void _0x68c1c2e2(int _0xf819af61)
    {
        this._0xc54d205a = true;
        string _0x5ce1f707 = this._0xc099b698._0xb3e6655a(this._0x86b35a50);
        if (this._pops != null)
        {
            this._pops._0x423843e3(_0x5ce1f707, _0xf819af61, this._0x72ec0983);
        }

        DOVirtual.DelayedCall(0.5f, () => this._0x47252c55());
    }

    [SerializeField]
    private _0x2ade6594 _hud;
    private int _0x72ec0983;
    /// A tap on the field. A stone with a path spends a turn; a bare stone only spins,
    /// so every tap answers visibly but the budget is honest (C.7).
    public void _0x4b2edb76(Vector2 _0xe949cfef)
    {
        if (this._0xc54d205a || this._boardView == null || this._0x69f99aa7 == null)
            return;
        int _0x527b2cd0 = this._boardView._0x96072316(_0xe949cfef);
        if (_0x527b2cd0 < 0)
            return;
        this._boardView._0xf0bef678(_0x527b2cd0);
        if (this._0x69f99aa7._0xbc62c423(_0x527b2cd0) == 0)
        {
            this._boardView._0x49c77f6b(_0x527b2cd0);
            return;
        }

        this._0x69f99aa7._0xfcc2abb4(_0x527b2cd0, 1);
        this._0x459d11bd++;
        this._boardView._0xa55e52c9(_0x527b2cd0);
        this._boardView._0xbf856c74();
        int _0xc23d15cb = this._0x69f99aa7._0x769e9bf2();
        int _0x75b64a63 = this._0xbab07b0c - this._0x459d11bd;
        if (this._hud != null)
        {
            this._hud._0x194542e9(_0x75b64a63 < 0 ? 0 : _0x75b64a63);
            this._hud._0x326e996e(_0xc23d15cb, this._0x72ec0983);
        }

        if (this._0x69f99aa7._0xdf1a7bc1())
            this._0x6bb623d2();
        else if (_0x75b64a63 <= 0)
            this._0x68c1c2e2(_0xc23d15cb);
    }

    private int _0x86b35a50;
    [SerializeField]
    private _0x211a08a6 _pops;
    [SerializeField]
    private _0xa6e06634 _motes;
    [SerializeField]
    private _0xf863743c _boardView;
    private readonly _0x6064955d _0x4c22b490 = new _0x6064955d();
    private bool _0xc54d205a;
    private _0x389ad784 _0xac9d9721;
    private void _0x47252c55()
    {
        _0x3a079d26.Instance._0x5c679b5d(false);
        _0xd6f6ef07.Instance._0x4753ff38(_0xb39a7050._0x5d80e5e2.LOSE);
    }

    public void _0x2b09ae91()
    {
        if (this._0xc54d205a)
            return;
        int _0xaa3ce462 = this._0xbab07b0c - this._0x459d11bd;
        if (this._pops != null)
        {
            this._pops._0xc77afd80(_0xaa3ce462 < 0 ? 0 : _0xaa3ce462, this._0x69f99aa7._0x769e9bf2(), this._0x72ec0983);
        }

        _0x3a079d26.Instance._0x5c679b5d(false);
        _0xd6f6ef07.Instance._0x4753ff38(_0xb39a7050._0x5d80e5e2.PAUSE);
    }

    public bool _0x3472dc8c
    {
        get
        {
            return !this._0xc54d205a;
        }
    }

    private void Start()
    {
        this._0x86b35a50 = this._0xc099b698._0xfa6a6d7f(this._0x4c22b490._0x2fbb40ce);
        int _0x7e0d5a5d = (System.Environment.TickCount & 0x7FFFFFFF) % 100003;
        this._0xac9d9721 = new _0x389ad784();
        this._0xac9d9721._0xc607c090(this._0x86b35a50, _0x7e0d5a5d, this._0xc099b698._0x7e933b78(this._0x86b35a50), this._0xc099b698._0x6f9753a4(this._0x86b35a50), this._0xc099b698._0xc9538c89(this._0x86b35a50));
        this._0x69f99aa7 = this._0xac9d9721._0xc0be3e16;
        this._0xbab07b0c = this._0xc099b698._0x19cc4843(this._0x86b35a50, this._0xac9d9721._0x3fc639d9);
        this._0x459d11bd = 0;
        this._0xc54d205a = false;
        this._0x72ec0983 = this._0x69f99aa7._0x28aa9d50();
        if (this._boardView != null)
            this._boardView._0x835d4844(this._0x69f99aa7);
        if (this._hud != null)
        {
            this._hud._0xb41bdfeb(this._0x86b35a50 + 1, this._0xc099b698._0xb3e6655a(this._0x86b35a50));
            this._hud._0x194542e9(this._0xbab07b0c);
            this._hud._0x326e996e(this._0x69f99aa7._0x769e9bf2(), this._0x72ec0983);
        }
    }

    private int _0xbab07b0c;
    private void _0x82929aa8()
    {
        _0x3a079d26.Instance._0x5c679b5d(false);
        _0xd6f6ef07.Instance._0x4753ff38(_0xb39a7050._0x5d80e5e2.WIN);
    }

    private _0x6ef3ea18 _0x69f99aa7;
}