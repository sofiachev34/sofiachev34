using DG.Tweening;
using UnityEngine;

/// A small shower of sparks when the pattern closes. Sizes come from the board metrics,
/// never from a literal, and the motion is position + alpha only (C.0).
public sealed class _0xa6e06634 : MonoBehaviour
{
    public void _0x088bd569(Vector2 _0xd4eafeed, float _0x481bc039)
    {
        if (this._motePrefab == null || this._host == null)
            return;
        float _0x7148cd3c = _0x481bc039 * 0.26f;
        float _0x85890ea9 = _0x481bc039 * 2.4f;
        for (int _0x2466f656 = 0; _0x2466f656 < this._count; _0x2466f656++)
        {
            SpriteRenderer _0x3857f129 = Instantiate(this._motePrefab, this._host);
            _0x3857f129.transform.localPosition = new Vector3(_0xd4eafeed.x, _0xd4eafeed.y, 0f);
            _0x3857f129.transform.localScale = Vector3.one;
            _0x3857f129.size = new Vector2(_0x7148cd3c, _0x7148cd3c);
            _0x3857f129.color = this._tint;
            float _0xf9d7a87a = (360f / this._count) * _0x2466f656 + 12f;
            Vector3 _0xbac3fe81 = new Vector3(_0xd4eafeed.x + Mathf.Cos(_0xf9d7a87a * Mathf.Deg2Rad) * _0x85890ea9, _0xd4eafeed.y + Mathf.Sin(_0xf9d7a87a * Mathf.Deg2Rad) * _0x85890ea9, 0f);
            _0x3857f129.transform.DOLocalMove(_0xbac3fe81, 0.7f).SetEase(Ease.OutQuad);
            SpriteRenderer _0x8221464a = _0x3857f129;
            _0x3857f129.DOFade(0f, 0.7f).SetTarget(_0x3857f129).OnComplete(() =>
            {
                if (_0x8221464a != null)
                    Destroy(_0x8221464a.gameObject);
            });
        }
    }

    [SerializeField]
    private Color _tint = new Color(0.957f, 0.765f, 0.306f, 1f);
    [SerializeField]
    private SpriteRenderer _motePrefab;
    [SerializeField]
    private int _count = 6;
    [SerializeField]
    private Transform _host;
}