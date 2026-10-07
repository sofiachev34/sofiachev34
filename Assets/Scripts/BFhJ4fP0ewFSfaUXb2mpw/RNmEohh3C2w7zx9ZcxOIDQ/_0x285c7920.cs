using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x285c7920 : MonoBehaviour
{
    private static readonly List<_0x285c7920> _0xc8124753 = new();
    private static void ResolutionChanged()
    {
        _0xdac7fcb2.x = Screen.width;
        _0xdac7fcb2.y = Screen.height;
        _0x91165504.Invoke();
    }

    private static void SafeAreaChanged()
    {
        _0x7ff646bf = Screen.safeArea;
        for (int _0xdecb58a9 = 0; _0xdecb58a9 < _0xc8124753.Count; _0xdecb58a9++)
            _0xc8124753[_0xdecb58a9]._0x858db7d1();
    }

    private RectTransform _0x4a2523f7;
    private void Awake()
    {
        if (!_0xc8124753.Contains(this))
            _0xc8124753.Add(this);
        this._0x60d8e610 = this.GetComponent<Canvas>();
        this._0x753883b2 = this.GetComponent<RectTransform>();
        this._0x4a2523f7 = this.transform.Find(_0x6f1ce76b._0xde677bc4(new byte[8] { 211, 225, 230, 229, 193, 242, 229, 225 }, 128)) as RectTransform;
        if (!_0x9f28e6b6)
        {
            _0x959b2161 = Screen.orientation;
            _0xdac7fcb2.x = Screen.width;
            _0xdac7fcb2.y = Screen.height;
            _0x7ff646bf = Screen.safeArea;
            _0x9f28e6b6 = true;
        }

        this._0x858db7d1();
    }

    private void OnDestroy()
    {
        if (_0xc8124753 != null && _0xc8124753.Contains(this))
            _0xc8124753.Remove(this);
    }

    private Canvas _0x60d8e610;
    private static Rect _0x7ff646bf = Rect.zero;
    private static void OrientationChanged()
    {
        _0x959b2161 = Screen.orientation;
        _0xdac7fcb2.x = Screen.width;
        _0xdac7fcb2.y = Screen.height;
        _0x91165504.Invoke();
    }

    private void _0x858db7d1()
    {
        if (this._0x4a2523f7 == null)
            return;
        Rect _0x5ad40673 = Screen.safeArea;
        Vector2 _0x5979c3a1 = _0x5ad40673.position;
        Vector2 _0x20b91aa2 = _0x5ad40673.position + _0x5ad40673.size;
        _0x5979c3a1.x /= this._0x60d8e610.pixelRect.width;
        _0x5979c3a1.y /= this._0x60d8e610.pixelRect.height;
        _0x20b91aa2.x /= this._0x60d8e610.pixelRect.width;
        _0x20b91aa2.y /= this._0x60d8e610.pixelRect.height;
        this._0x4a2523f7.anchorMin = _0x5979c3a1;
        this._0x4a2523f7.anchorMax = _0x20b91aa2;
    }

    private void Update()
    {
        if (_0xc8124753[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x959b2161)
            OrientationChanged();
        if (Screen.safeArea != _0x7ff646bf)
            SafeAreaChanged();
        if (Screen.width != _0xdac7fcb2.x || Screen.height != _0xdac7fcb2.y)
            ResolutionChanged();
    }

    private static Vector2 _0xdac7fcb2 = Vector2.zero;
    private static UnityEvent _0x91165504 = new();
    private static ScreenOrientation _0x959b2161 = ScreenOrientation.LandscapeLeft;
    private RectTransform _0x753883b2;
    private static bool _0x9f28e6b6;
}

internal static class _0x6f1ce76b
{
    internal static string _0xde677bc4(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}