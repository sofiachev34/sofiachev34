using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Dresses and fills the three template pops (pause 6, win 7, lose 8). Everything is
/// reached through serialized references or the pop's own slots - no names and no lookups by asset
/// path - and the whole card is restyled, not just its headline (C.3).
public sealed class _0x211a08a6 : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _winBody;
    public void _0xc77afd80(int _0x1be84368, int _0x7042eb45, int _0x46ede295)
    {
        _0x315577fe _0x0674635b = _0xd6f6ef07.Instance._0xf4b0a9e1(_0xb39a7050._0x5d80e5e2.PAUSE);
        if (_0x0674635b == null)
            return;
        this._0x761bb5bf(_0x0674635b.ContentHeaderText, _0x01a039ca._0x55131a02(new byte[6] { 39, 54, 34, 36, 50, 51 }, 119), 0.648f);
        this._0x13acc48d(_0x0674635b.ContentMainText, _0x01a039ca._0x55131a02(new byte[11] { 1, 0, 7, 27, 6, 117, 25, 16, 19, 1, 117 }, 85) + _0x1be84368.ToString() + _0x01a039ca._0x55131a02(new byte[9] { 180, 185, 180, 216, 221, 218, 223, 199, 180 }, 148) + _0x7042eb45.ToString() + _0x01a039ca._0x55131a02(new byte[3] { 44, 35, 44 }, 12) + _0x46ede295.ToString(), 0.545f);
        this._0xa1d09b4d(this._pauseBody, _0x01a039ca._0x55131a02(new byte[28] { 60, 32, 45, 72, 56, 41, 60, 60, 45, 58, 38, 72, 33, 59, 72, 32, 45, 36, 44, 72, 33, 38, 72, 56, 36, 41, 43, 45 }, 104));
    }

    [SerializeField]
    private Color _creamColour = new Color(0.961f, 0.937f, 0.898f, 1f);
    public void _0x423843e3(string _0xb920873c, int _0xe714ecad, int _0xc2892623)
    {
        _0x315577fe _0x5f1344f3 = _0xd6f6ef07.Instance._0xf4b0a9e1(_0xb39a7050._0x5d80e5e2.LOSE);
        if (_0x5f1344f3 == null)
            return;
        this._0x761bb5bf(_0x5f1344f3.ContentHeaderText, _0x01a039ca._0x55131a02(new byte[12] { 203, 209, 208, 164, 203, 194, 164, 208, 209, 214, 202, 215 }, 132), 0.648f);
        this._0x13acc48d(_0x5f1344f3.ContentMainText, _0xe714ecad.ToString() + _0x01a039ca._0x55131a02(new byte[3] { 25, 22, 25 }, 57) + _0xc2892623.ToString(), 0f);
        this._0xa1d09b4d(this._loseBody, _0xb920873c + _0x01a039ca._0x55131a02(new byte[14] { 62, 87, 77, 62, 77, 74, 87, 82, 82, 62, 81, 78, 91, 80 }, 30));
    }

    [SerializeField]
    private Color _cardColour = new Color(0.165f, 0.227f, 0.478f, 0.94f);
    [SerializeField]
    private Color _borderColour = new Color(0.22f, 0.784f, 1f, 0.55f);
    [SerializeField]
    private Image[] _cardPlates;
    [SerializeField]
    private TMP_Text _loseBody;
    /// A pop Image left without a sprite is drawn by Unity as a plain white slab, so
    /// every close button gets a real icon before any pop can be raised (ANDROID-3247).
    private void _0x13cc6991()
    {
        if (this._closeIcons != null)
        {
            for (int _0x1e2a244b = 0; _0x1e2a244b < this._closeIcons.Length; _0x1e2a244b++)
            {
                if (this._closeIcons[_0x1e2a244b] == null)
                    continue;
                this._closeIcons[_0x1e2a244b].sprite = this._closeIcon;
                this._closeIcons[_0x1e2a244b].color = this._creamColour;
                this._closeIcons[_0x1e2a244b].preserveAspect = true;
            }
        }

        if (this._cardPlates != null)
            for (int _0x0758c59f = 0; _0x0758c59f < this._cardPlates.Length; _0x0758c59f++)
                if (this._cardPlates[_0x0758c59f] != null)
                    this._cardPlates[_0x0758c59f].color = this._cardColour;
        if (this._cardBorders != null)
            for (int _0x82512666 = 0; _0x82512666 < this._cardBorders.Length; _0x82512666++)
                if (this._cardBorders[_0x82512666] != null)
                    this._cardBorders[_0x82512666].color = this._borderColour;
    }

    [SerializeField]
    private TMP_Text _pauseBody;
    [SerializeField]
    private Image[] _closeIcons;
    /// A value the template already positions (the result row) keeps its box; only the
    /// pause line, which ships at zero height, is re-boxed.
    private void _0x13acc48d(TMP_Text _0xd9af8e93, string _0x5c4ca299, float _0x8a064463)
    {
        if (_0xd9af8e93 == null)
            return;
        _0xd9af8e93.gameObject.SetActive(true);
        _0xd9af8e93.text = _0x5c4ca299;
        _0xd9af8e93.color = this._creamColour;
        _0xd9af8e93.textWrappingMode = TextWrappingModes.NoWrap;
        _0xd9af8e93.overflowMode = TextOverflowModes.Overflow;
        _0xd9af8e93.enableAutoSizing = true;
        _0xd9af8e93.fontSizeMin = 40f;
        _0xd9af8e93.fontSizeMax = 56f;
        RectTransform _0xbd5be8b7 = _0xd9af8e93.transform as RectTransform;
        if (_0xbd5be8b7 != null && _0x8a064463 > 0f)
        {
            _0xd9af8e93.alignment = TextAlignmentOptions.Center;
            _0xbd5be8b7.anchorMin = new Vector2(0.5f, _0x8a064463);
            _0xbd5be8b7.anchorMax = new Vector2(0.5f, _0x8a064463);
            _0xbd5be8b7.pivot = new Vector2(0.5f, 0.5f);
            _0xbd5be8b7.anchoredPosition = Vector2.zero;
            _0xbd5be8b7.sizeDelta = new Vector2(900f, 90f);
        }
    }

    [SerializeField]
    private Sprite _closeIcon;
    [SerializeField]
    private Color _goldColour = new Color(0.957f, 0.765f, 0.306f, 1f);
    private void _0xa1d09b4d(TMP_Text _0x8c52da08, string _0x4bdcec33)
    {
        if (_0x8c52da08 == null)
            return;
        _0x8c52da08.gameObject.SetActive(true);
        _0x8c52da08.text = _0x4bdcec33;
    }

    private void Awake()
    {
        this._0x13cc6991();
    }

    [SerializeField]
    private Image[] _cardBorders;
    /// The template headline ships as "HEADER" on a zero-height rect, so it is given a
    /// real box here as well as the words. Wrap off, autosize on, floor at the
    /// readability minimum (C.10/C.12).
    private void _0x761bb5bf(TMP_Text _0x9f4841b1, string _0x2d5c4ebd, float _0x1952f913)
    {
        if (_0x9f4841b1 == null)
            return;
        _0x9f4841b1.gameObject.SetActive(true);
        _0x9f4841b1.text = _0x2d5c4ebd;
        _0x9f4841b1.color = this._goldColour;
        _0x9f4841b1.textWrappingMode = TextWrappingModes.NoWrap;
        _0x9f4841b1.overflowMode = TextOverflowModes.Overflow;
        _0x9f4841b1.enableAutoSizing = true;
        _0x9f4841b1.fontSizeMin = 56f;
        _0x9f4841b1.fontSizeMax = 86f;
        _0x9f4841b1.alignment = TextAlignmentOptions.Center;
        RectTransform _0x176059e0 = _0x9f4841b1.transform as RectTransform;
        if (_0x176059e0 != null && _0x1952f913 > 0f)
        {
            _0x176059e0.anchorMin = new Vector2(0.5f, _0x1952f913);
            _0x176059e0.anchorMax = new Vector2(0.5f, _0x1952f913);
            _0x176059e0.pivot = new Vector2(0.5f, 0.5f);
            _0x176059e0.anchoredPosition = Vector2.zero;
            _0x176059e0.sizeDelta = new Vector2(940f, 140f);
        }
    }

    public void _0x9f1b2a5d(string _0x573bcd2a, int _0xeb02a4c9)
    {
        _0x315577fe _0xc2285cbd = _0xd6f6ef07.Instance._0xf4b0a9e1(_0xb39a7050._0x5d80e5e2.WIN);
        if (_0xc2285cbd == null)
            return;
        this._0x761bb5bf(_0xc2285cbd.ContentHeaderText, _0x01a039ca._0x55131a02(new byte[16] { 132, 149, 128, 128, 145, 134, 154, 244, 134, 145, 135, 128, 155, 134, 145, 144 }, 212), 0.648f);
        this._0x13acc48d(_0xc2285cbd.ContentMainText, _0xeb02a4c9.ToString(), 0f);
        this._0xa1d09b4d(this._winBody, _0x573bcd2a + _0x01a039ca._0x55131a02(new byte[15] { 150, 255, 229, 150, 225, 254, 249, 250, 243, 150, 247, 241, 247, 255, 248 }, 182));
    }
}

internal static class _0x01a039ca
{
    internal static string _0x55131a02(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}