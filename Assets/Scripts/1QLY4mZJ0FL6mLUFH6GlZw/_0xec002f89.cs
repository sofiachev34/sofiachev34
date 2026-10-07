using DG.Tweening;
using UnityEngine;

/// One mosaic stone. Size comes from m_Size only (CLAUDE-unity.md C.0): the transform
/// scale stays at 1 and every tween animates SpriteRenderer.size, never localScale.
public sealed class _0xec002f89 : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _focus;
    public void _0x68ad5094(int _0x8679c7dc)
    {
        this._0x9b2f515a = _0x8679c7dc;
        this.transform.localRotation = Quaternion.Euler(0f, 0f, -60f * _0x8679c7dc);
    }

    public void _0x42cf224c(bool _0x6df0290e)
    {
        if (this._focus == null)
            return;
        DOTween.Kill(this._focus, true);
        this._focus.DOFade(_0x6df0290e ? 0.95f : 0f, 0.12f).SetTarget(this._focus);
    }

    [SerializeField]
    private SpriteRenderer _face;
    public void _0xdc3c7b18(bool _0x24e92c10)
    {
        if (this._lit == null)
            return;
        DOTween.Kill(this._lit, true);
        this._lit.DOFade(_0x24e92c10 ? 0.85f : 0f, 0.22f).SetTarget(this._lit);
    }

    /// One clockwise step, with a size pulse measured from the computed box.
    public void _0xcfd498ff()
    {
        this._0x9b2f515a++;
        DOTween.Kill(this.transform, true);
        this.transform.DOLocalRotate(new Vector3(0f, 0f, -60f * this._0x9b2f515a), 0.18f).SetEase(Ease.OutCubic);
        if (this._face != null)
        {
            DOTween.Kill(this._face, true);
            Sequence _0xb676e2cf = DOTween.Sequence();
            _0xb676e2cf.Append(DOTween.To(() => this._face.size, _0x76d62a2a => this._face.size = _0x76d62a2a, new Vector2(this._0xc592de6a * 1.08f, this._0xc592de6a * 1.08f), 0.09f));
            _0xb676e2cf.Append(DOTween.To(() => this._face.size, _0x76d62a2a => this._face.size = _0x76d62a2a, new Vector2(this._0xc592de6a, this._0xc592de6a), 0.09f));
            _0xb676e2cf.SetTarget(this._face);
        }
    }

    private int _0x9b2f515a;
    /// A nudge for a tile that carries no path: something answers the tap, but the
    /// move budget is untouched.
    public void _0xd2f08738()
    {
        this._0x9b2f515a++;
        DOTween.Kill(this.transform, true);
        this.transform.DOLocalRotate(new Vector3(0f, 0f, -60f * this._0x9b2f515a), 0.22f).SetEase(Ease.OutBack);
    }

    public void _0x51358ce2(Sprite _0xb82302d3, float _0x23cb42fd, Color _0x1dedc676, Color _0x63f51c60)
    {
        this._0xc592de6a = _0x23cb42fd;
        if (this._face != null)
        {
            this._face.sprite = _0xb82302d3;
            this._face.size = new Vector2(_0x23cb42fd, _0x23cb42fd);
        }

        if (this._lit != null)
        {
            this._lit.size = new Vector2(_0x23cb42fd, _0x23cb42fd);
            this._lit.color = new Color(_0x1dedc676.r, _0x1dedc676.g, _0x1dedc676.b, 0f);
        }

        if (this._focus != null)
        {
            this._focus.size = new Vector2(_0x23cb42fd * 1.04f, _0x23cb42fd * 1.04f);
            this._focus.color = new Color(_0x63f51c60.r, _0x63f51c60.g, _0x63f51c60.b, 0f);
        }

        this._0x9b2f515a = 0;
        this.transform.localRotation = Quaternion.identity;
    }

    [SerializeField]
    private SpriteRenderer _lit;
    private float _0xc592de6a;
}