using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x9765d4e7 : MonoBehaviour
{
    public static _0x9765d4e7 Instance;
    public void _0x72b5d0cb()
    {
        this._0xc42560ae?.Play();
    }

    private void _0x9d54b07c()
    {
        this.AnimationSlider.value = 0.05f;
        _0x7df0ae89 = !_0x7df0ae89;
        this._0xc42560ae = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x37fffce1 => this.AnimationSlider.value = _0x37fffce1, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0xa6dd49b8._0xde64ea98?._0xcb7672b1();
        });
    }

    public float FirstAnimationTime = 10.0f;
    public float SecondPassSliderValue = 0.5f;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x9765d4e7>();
    }

    public Slider AnimationSlider;
    public GameObject Background;
    public void _0x7ae7943e()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0xc42560ae?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x7df0ae89 = false;
    }

    private static bool _0x7df0ae89 = false;
    public GameObject Content;
    private Sequence _0xc42560ae;
    public float DefaultAnimationTime = 0.4f;
    public void _0xc38d216e()
    {
        this._0xc42560ae?.Kill();
        this.AnimationSlider.value = _0x7df0ae89 ? this.SecondPassSliderValue : 0.05f;
    }

    public void _0xc6fd1e7e()
    {
        this._0xc42560ae?.Pause();
    }

    public void _0xf676e8a5()
    {
        this._0xc38d216e();
        bool _0x1052d933 = _0x7df0ae89;
        this._0xc42560ae = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x37fffce1 => this.AnimationSlider.value = _0x37fffce1, _0x1052d933 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x7df0ae89 = !_0x7df0ae89;
    }

    public GameObject Error;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0xb39a7050._0xd84c6d41.SCENE_0 && !_0x7df0ae89)
        {
            this._0x9d54b07c();
        }
        else
        {
            this._0xf676e8a5();
        }
    }
}