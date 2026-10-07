using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0x26a006d6 : MonoBehaviour
{
    private static readonly List<_0x26a006d6> _0xa14e5382 = new();
    private static UnityEvent _0x30ede9f6 = new();
    private void Start()
    {
    }

    private static void OrientationChanged()
    {
        _0xdab81dce = Screen.orientation;
        _0xd6c4ef6e.x = Screen.width;
        _0xd6c4ef6e.y = Screen.height;
        _0x26a43c4e = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x30ede9f6.Invoke();
    }

    private void Update()
    {
        if (_0xa14e5382.Count == 0 || _0xa14e5382[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xdab81dce)
            OrientationChanged();
        if (Screen.safeArea != _0x26a43c4e)
            SafeAreaChanged();
        if (Screen.width != _0xd6c4ef6e.x || Screen.height != _0xd6c4ef6e.y)
            ResolutionChanged();
    }

    private CanvasScaler _0xf735c19f;
    private static ScreenOrientation _0xdab81dce = ScreenOrientation.LandscapeLeft;
    private RectTransform _0x72be90ad;
    private Canvas _0x5be624eb;
    private RectTransform _0x7cb5db69;
    private static Vector2 _0xd6c4ef6e = Vector2.zero;
    private void Awake()
    {
        if (!_0xa14e5382.Contains(this))
            _0xa14e5382.Add(this);
        this._0x5be624eb = this.GetComponent<Canvas>();
        this._0xf735c19f = this.GetComponent<CanvasScaler>();
        if (this._0xf735c19f != null)
            this._0x0f8cba4f = this._0xf735c19f.referenceResolution;
        this._0x7cb5db69 = this.GetComponent<RectTransform>();
        this._0x72be90ad = this.transform.Find(_0xb1a25951._0x3cd7ba71(new byte[8] { 207, 253, 250, 249, 221, 238, 249, 253 }, 156)) as RectTransform;
        if (!_0x44fbc8d1)
        {
            _0xdab81dce = Screen.orientation;
            _0xd6c4ef6e.x = Screen.width;
            _0xd6c4ef6e.y = Screen.height;
            _0x26a43c4e = Screen.safeArea;
            _0x44fbc8d1 = true;
        }

        this._0xac18c3df();
    }

    private void _0xac18c3df()
    {
        if (this._0x72be90ad == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x871023a5 = Screen.safeArea;
        Vector2 _0xcd8f2c05 = _0x871023a5.position;
        Vector2 _0x870ecfce = _0x871023a5.position + _0x871023a5.size;
        _0xcd8f2c05.x /= screenWidth;
        _0xcd8f2c05.y /= screenHeight;
        _0x870ecfce.x /= screenWidth;
        _0x870ecfce.y /= screenHeight;
        this._0x72be90ad.anchorMin = _0xcd8f2c05;
        this._0x72be90ad.anchorMax = _0x870ecfce;
        this._0x72be90ad.offsetMin = Vector2.zero;
        this._0x72be90ad.offsetMax = Vector2.zero;
        if (this._0xf735c19f == null)
            return;
        Vector2 _0x5f040bcd = _0x870ecfce - _0xcd8f2c05;
        float _0xd4adb86b = 2f - _0x5f040bcd.x;
        float _0x1a2105e7 = 2f - _0x5f040bcd.y;
        this._0xf735c19f.referenceResolution = this._0x0f8cba4f * new Vector2(_0xd4adb86b, _0x1a2105e7);
    }

    private static void ResolutionChanged()
    {
        _0xd6c4ef6e.x = Screen.width;
        _0xd6c4ef6e.y = Screen.height;
        _0x26a43c4e = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x30ede9f6.Invoke();
    }

    private Vector2 _0x0f8cba4f;
    private static Rect _0x26a43c4e = Rect.zero;
    private void OnDestroy()
    {
        if (_0xa14e5382 != null && _0xa14e5382.Contains(this))
            _0xa14e5382.Remove(this);
    }

    private static void ApplySafeAreaToAll()
    {
        for (int _0xd3d60342 = 0; _0xd3d60342 < _0xa14e5382.Count; _0xd3d60342++)
            _0xa14e5382[_0xd3d60342]._0xac18c3df();
    }

    private static bool _0x44fbc8d1;
    private static void SafeAreaChanged()
    {
        _0x26a43c4e = Screen.safeArea;
        ApplySafeAreaToAll();
    }
}

internal static class _0xb1a25951
{
    internal static string _0x3cd7ba71(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}