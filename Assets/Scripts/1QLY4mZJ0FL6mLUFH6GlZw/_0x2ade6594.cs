using DG.Tweening;
using TMPro;
using UnityEngine;

/// The readouts above the field. Every label is a scene object this game owns - the
/// template's own HUD slots are left alone for stage 5da to switch off (C.2).
public sealed class _0x2ade6594 : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _linksValue;
    [SerializeField]
    private TMP_Text _trialName;
    public void _0x326e996e(int _0x4c4f4114, int _0xf025be4d)
    {
        if (this._linksValue != null)
            this._linksValue.text = _0xdbbdb54e._0x7a9c4898(new byte[6] { 35, 38, 33, 36, 60, 79 }, 111) + _0x4c4f4114.ToString() + _0xdbbdb54e._0x7a9c4898(new byte[3] { 33, 46, 33 }, 1) + _0xf025be4d.ToString();
    }

    [SerializeField]
    private TMP_Text _turnsValue;
    public void _0x194542e9(int _0x0d0ecc9d)
    {
        if (this._turnsValue == null)
            return;
        this._turnsValue.text = _0xdbbdb54e._0x7a9c4898(new byte[11] { 181, 180, 179, 175, 178, 193, 173, 164, 167, 181, 193 }, 225) + _0x0d0ecc9d.ToString();
        bool _0x372af41a = _0x0d0ecc9d <= 3;
        this._turnsValue.color = _0x372af41a ? this._alertColour : this._calmColour;
        if (_0x372af41a)
        {
            DOTween.Kill(this._turnsValue.transform, true);
            this._turnsValue.transform.DOPunchScale(Vector3.one * 0.18f, 0.3f, 6, 0.6f).SetTarget(this._turnsValue.transform);
        }
    }

    [SerializeField]
    private Color _alertColour = new Color(0.91f, 0.231f, 0.345f, 1f);
    public void _0xb41bdfeb(int _0xe2f9a106, string _0x026a789f)
    {
        if (this._trialLabel != null)
            this._trialLabel.text = _0xdbbdb54e._0x7a9c4898(new byte[6] { 148, 146, 137, 129, 140, 224 }, 192) + _0xe2f9a106.ToString();
        if (this._trialName != null)
            this._trialName.text = _0x026a789f;
    }

    [SerializeField]
    private Color _calmColour = new Color(0.957f, 0.765f, 0.306f, 1f);
    [SerializeField]
    private TMP_Text _trialLabel;
}

internal static class _0xdbbdb54e
{
    internal static string _0x7a9c4898(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}