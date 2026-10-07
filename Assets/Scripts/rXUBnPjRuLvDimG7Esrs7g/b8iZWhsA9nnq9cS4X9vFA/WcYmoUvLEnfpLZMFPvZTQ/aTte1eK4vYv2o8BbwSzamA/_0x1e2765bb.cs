using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x1e2765bb : MonoBehaviour
{
    public void _0x65edcb81()
    {
        this._0xcf585aaf();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x09bc71db.Instance._0x8e66592f(_0x09bc71db.Instance.CurrentPanelIndex);
    }

    private void _0x1c6193b2()
    {
        if (this.OuterBackground != null)
        {
            Image _0xb02b46cf = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xb02b46cf, true);
            _0xb02b46cf.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    public Ease Ease = Ease.OutSine;
    public float ScaleDuration = 0.4f;
    private void _0xfed9c6f8()
    {
        if (this.OuterBackground != null)
        {
            Image _0xc95fca0c = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xc95fca0c, true);
            _0xc95fca0c.DOFade(0f, this.ScaleDuration);
        }
    }

    public void _0x98af48a3()
    {
        this._0xfed9c6f8();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public bool IsScaledDownOnAwake = true;
    private void _0xc031702f()
    {
        if (this.OuterBackground != null)
        {
            Image _0x43502ccf = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x43502ccf, true);
            _0x43502ccf.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public GameObject Content;
    public void Show()
    {
        this._0x1c6193b2();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x09bc71db.Instance._0x8e66592f(_0x09bc71db.Instance.CurrentPanelIndex);
            });
        }
    }

    private bool _0x1b801884 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xc031702f();
    }

    private void _0xcf585aaf()
    {
        if (this.OuterBackground != null)
        {
            Image _0x7254a569 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x7254a569, true);
            _0x7254a569.DOFade(1f, 0f);
        }
    }

    public GameObject OuterBackground;
    public TMP_Text HeaderText;
    public TMP_Text MainText;
}