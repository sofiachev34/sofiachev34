using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x7b7ad723 : MonoBehaviour
{
    private void _0x1ba064e0(Touch? _0x88069221)
    {
        if (!_0x3a079d26.Instance._0x70fe20e5)
        {
            _0x88069221 = null;
            return;
        }

        int _0xd9d2ded8 = _0x88069221.Value.touchId;
        _0x88069221 = Touch.activeTouches.FirstOrDefault(_0xfe5e3f21 => _0xfe5e3f21.touchId == _0xd9d2ded8);
        if (!this._0x565aec18(_0x88069221.Value))
            _0x88069221 = null;
    }

    private bool _0x565aec18(Touch? _0x572f9191)
    {
        if (!_0x572f9191.HasValue)
            return false;
        Vector3 _0xbecaf9cd = Camera.main.ScreenToWorldPoint(_0x572f9191.Value.screenPosition);
        Vector3 _0x6cb29a62 = _0xbecaf9cd;
        _0x6cb29a62.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0x6cb29a62))
            return true;
        _0x572f9191 = null;
        return false;
    }

    public BoxCollider2D CameraTouchBounds;
    private Touch? _0x118f34ce()
    {
        if (!_0x3a079d26.Instance._0x70fe20e5)
            return null;
        foreach (Touch _0x749a73e8 in Touch.activeTouches)
            if (!_0x749a73e8.ended)
                if (this._0x565aec18(_0x749a73e8))
                    return _0x749a73e8;
        return null;
    }

    private Touch? _0xee7f0a6c(Bounds _0x42def733)
    {
        if (!_0x3a079d26.Instance._0x70fe20e5)
            return null;
        foreach (Touch _0xe98ac48d in Touch.activeTouches)
            if (!_0xe98ac48d.ended)
            {
                Vector3 _0xc5d1dc1a = Camera.main.ScreenToWorldPoint(_0xe98ac48d.screenPosition);
                Vector3 _0x9c4fa9f9 = new(_0xc5d1dc1a.x, _0xc5d1dc1a.y, _0x42def733.center.z);
                if (_0x42def733.Contains(_0x9c4fa9f9) && this._0x565aec18(_0xe98ac48d))
                    return _0xe98ac48d;
            }

        return null;
    }

    private bool _0x5502ae54(Touch? _0x57c72243, Bounds _0xd3e46f72, TouchPhase _0xbeeecd3e)
    {
        if (!_0x3a079d26.Instance._0x70fe20e5)
        {
            _0x57c72243 = null;
            return false;
        }

        if (_0x57c72243 != null)
            if (_0x57c72243.Value.phase == _0xbeeecd3e)
            {
                Vector3 _0x39d1d0d9 = Camera.main.ScreenToWorldPoint(_0x57c72243.Value.screenPosition);
                Vector3 _0x93519320 = new(_0x39d1d0d9.x, _0x39d1d0d9.y, _0xd3e46f72.center.z);
                if (_0xd3e46f72.Contains(_0x93519320) && this._0x565aec18(_0x57c72243.Value))
                    return true;
            }

        return false;
    }

    private Touch? _0x12592a59(Bounds _0x2356662d)
    {
        if (!_0x3a079d26.Instance._0x70fe20e5)
            return null;
        foreach (Touch _0x129827f6 in Touch.activeTouches)
            if (_0x129827f6.ended)
            {
                Vector3 _0xa27bad0a = Camera.main.ScreenToWorldPoint(_0x129827f6.screenPosition);
                Vector3 _0x2f1f7027 = new(_0xa27bad0a.x, _0xa27bad0a.y, _0x2356662d.center.z);
                if (_0x2356662d.Contains(_0x2f1f7027) && this._0x565aec18(_0x129827f6))
                    return _0x129827f6;
            }

        return null;
    }

    private Touch? _0x82343fb4()
    {
        if (!_0x3a079d26.Instance._0x70fe20e5)
            return null;
        foreach (Touch _0x74637569 in Touch.activeTouches)
            if (_0x74637569.ended)
                if (this._0x565aec18(_0x74637569))
                    return _0x74637569;
        return null;
    }

    private static _0x7b7ad723 _0xe686a5c3;
    private Touch? _0x715bbd40(Bounds _0x774785ee, TouchPhase _0x88c6d89c)
    {
        if (!_0x3a079d26.Instance._0x70fe20e5)
            return null;
        foreach (Touch _0xfd18820b in Touch.activeTouches)
            if (_0xfd18820b.phase == _0x88c6d89c)
            {
                Vector3 _0x79cf8c73 = Camera.main.ScreenToWorldPoint(_0xfd18820b.screenPosition);
                Vector3 _0x8c755d6c = new(_0x79cf8c73.x, _0x79cf8c73.y, _0x774785ee.center.z);
                if (_0x774785ee.Contains(_0x8c755d6c) && this._0x565aec18(_0xfd18820b))
                    return _0xfd18820b;
            }

        return null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0xe686a5c3 = this.gameObject.GetComponent<_0x7b7ad723>();
    }
}