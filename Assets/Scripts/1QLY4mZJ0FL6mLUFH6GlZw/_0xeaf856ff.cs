using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// One row in the stage sheet. The badge gutter and the text column never share an
/// x-band: the text box starts to the right of the gutter with a real gap, so no label
/// can slide under an indicator (CLAUDE-unity.md C.25).
public sealed class _0xeaf856ff : MonoBehaviour
{
    [SerializeField]
    private Color _badgeEarned = new Color(0.957f, 0.765f, 0.306f, 1f);
    [SerializeField]
    private Color _activePlate = new Color(0.165f, 0.227f, 0.478f, 0.85f);
    [SerializeField]
    private TMP_Text _title;
    [SerializeField]
    private Image _badge;
    public void _0x8bd97bef(bool _0xcfb80cb8)
    {
        if (this._plate != null)
            this._plate.color = _0xcfb80cb8 ? this._activePlate : this._idlePlate;
        if (this._border != null)
            this._border.color = _0xcfb80cb8 ? this._activeBorder : this._idleBorder;
    }

    [SerializeField]
    private TMP_Text _best;
    [SerializeField]
    private Image _plate;
    [SerializeField]
    private Image _border;
    [SerializeField]
    private Color _idlePlate = new Color(0.165f, 0.227f, 0.478f, 0.45f);
    [SerializeField]
    private TMP_Text _name;
    public void _0xfb241fba(int _0xa727a6cd, string _0x368dba9c, int _0x22998bab, bool _0xa0613f6a, bool _0x9ab202c1)
    {
        if (this._title != null)
            this._title.text = _0x2398d17d._0x5ac8b87f(new byte[6] { 124, 122, 97, 105, 100, 8 }, 40) + _0xa727a6cd.ToString();
        if (this._name != null)
            this._name.text = _0x368dba9c;
        if (this._best != null)
            this._best.text = _0x22998bab > 0 ? _0x2398d17d._0x5ac8b87f(new byte[5] { 107, 108, 122, 125, 9 }, 41) + _0x22998bab.ToString() : _0x2398d17d._0x5ac8b87f(new byte[6] { 12, 11, 29, 26, 110, 99 }, 78);
        if (this._badge != null)
            this._badge.color = _0xa0613f6a ? this._badgeEarned : this._badgeLocked;
        this._0x8bd97bef(_0x9ab202c1);
    }

    [SerializeField]
    private Color _activeBorder = new Color(0.22f, 0.784f, 1f, 1f);
    [SerializeField]
    private Color _badgeLocked = new Color(0.165f, 0.227f, 0.478f, 0.5f);
    [SerializeField]
    private Color _idleBorder = new Color(0.561f, 0.851f, 1f, 0.3f);
}

internal static class _0x2398d17d
{
    internal static string _0x5ac8b87f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}