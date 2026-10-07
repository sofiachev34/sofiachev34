using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// Shows and hides one scene object this game owns. Codegen can only steer what it
/// built itself, so overlays live behind this gate instead of leaning on template
/// panels (CLAUDE-unity.md C.2).
public sealed class _0x0b00c526 : MonoBehaviour
{
    public void _0xfe2c5761()
    {
        if (this._content != null)
            this._content.SetActive(false);
    }

    private void Awake()
    {
        if (this._content != null)
            this._content.SetActive(false);
    }

    public void Show()
    {
        if (this._content == null)
            return;
        this._content.SetActive(true);
        if (this._scrim != null)
        {
            Color _0x53243e99 = this._scrim.color;
            this._scrim.color = new Color(_0x53243e99.r, _0x53243e99.g, _0x53243e99.b, 0f);
            DOTween.Kill(this._scrim, true);
            this._scrim.DOFade(this._scrimAlpha, 0.18f).SetTarget(this._scrim);
        }

        if (this._card != null)
        {
            DOTween.Kill(this._card, true);
            this._card.localScale = Vector3.one * 0.92f;
            this._card.DOScale(1f, 0.22f).SetEase(Ease.OutBack).SetTarget(this._card);
        }
    }

    public bool _0xcc989b2c
    {
        get
        {
            return this._content != null && this._content.activeSelf;
        }
    }

    [SerializeField]
    private GameObject _content;
    [SerializeField]
    private float _scrimAlpha = 0.78f;
    [SerializeField]
    private Image _scrim;
    [SerializeField]
    private RectTransform _card;
}