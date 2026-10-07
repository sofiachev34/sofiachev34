using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x315577fe : MonoBehaviour
{
    public void _0x5e1f9f12()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    public TMP_Text ContentMainText;
    public TMP_Text ContentHeaderText;
    private void Start()
    {
    // Content.SetActive(false);
    }

    public static void HideAllPops()
    {
        _0xd6f6ef07.Instance._0xadc054c2();
    }

    public bool IsScaledDownOnAwake = true;
    public Ease ease = Ease.OutSine;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xecfe2cb0();
    }

    public float scaleDuration = 0.4f;
    public TMP_Text ContentAdditionalText;
    private void _0xecfe2cb0()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public GameObject Content;
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public Image ContentImage;
    public bool IsOnlyYScale;
    private bool _0xc25ecfee => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;
}