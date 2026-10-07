using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The menu. Shows the selected stage, how far the player has got and the coin total,
/// all on objects this game owns; the template's own Play button keeps its loader
/// driver and only gets a visible face and a real size (G.3).
public sealed class _0xc92a9915 : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _progress;
    [SerializeField]
    private RectTransform _mark;
    [SerializeField]
    private TMP_Text _trialBest;
    private readonly _0xbcadf24b _0xc77975f6 = new _0xbcadf24b();
    [SerializeField]
    private TMP_Text _trialTitle;
    private void Start()
    {
        this._0xf0e7731c();
        this._0x20f36af3();
        if (this._mark != null)
        {
            this._mark.localScale = Vector3.one;
            this._mark.DOScale(1.025f, 3f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetTarget(this._mark);
        }
    }

    [SerializeField]
    private TMP_Text _trialName;
    private readonly _0x6064955d _0x8d626b58 = new _0x6064955d();
    [SerializeField]
    private TMP_Text[] _templateLeftovers;
    public void _0x20f36af3()
    {
        int _0xd9634014 = this._0xc77975f6._0xfa6a6d7f(this._0x8d626b58._0x2fbb40ce);
        if (this._trialTitle != null)
            this._trialTitle.text = _0x370ca595._0xbb521741(new byte[6] { 34, 36, 63, 55, 58, 86 }, 118) + (_0xd9634014 + 1).ToString();
        if (this._trialName != null)
            this._trialName.text = this._0xc77975f6._0xb3e6655a(_0xd9634014);
        if (this._trialBest != null)
        {
            int _0xa0acf6fe = this._0x8d626b58._0xc0dde847(_0xd9634014);
            this._trialBest.text = _0xa0acf6fe > 0 ? _0x370ca595._0xbb521741(new byte[5] { 138, 141, 155, 156, 232 }, 200) + _0xa0acf6fe.ToString() + _0x370ca595._0xbb521741(new byte[6] { 36, 80, 81, 86, 74, 87 }, 4) : _0x370ca595._0xbb521741(new byte[6] { 93, 90, 76, 75, 63, 50 }, 31);
        }

        if (this._progress != null)
        {
            this._progress.text = _0x370ca595._0xbb521741(new byte[15] { 216, 222, 197, 205, 192, 223, 172, 207, 192, 201, 205, 222, 201, 200, 172 }, 140) + this._0x8d626b58._0x37047479(this._0xc77975f6._0xb29ba43a).ToString() + _0x370ca595._0xbb521741(new byte[3] { 94, 81, 94 }, 126) + this._0xc77975f6._0xb29ba43a.ToString();
        }
    }

    /// Tutorial pages this game does not dress still ship the template's placeholder
    /// copy, so they are emptied at runtime (CLAUDE-unity.md C.15).
    private void _0xf0e7731c()
    {
        if (this._templateLeftovers == null)
            return;
        for (int _0xb9605ef5 = 0; _0xb9605ef5 < this._templateLeftovers.Length; _0xb9605ef5++)
            if (this._templateLeftovers[_0xb9605ef5] != null)
                this._templateLeftovers[_0xb9605ef5].text = "";
    }
}

internal static class _0x370ca595
{
    internal static string _0xbb521741(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}