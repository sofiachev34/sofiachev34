using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// The stage sheet. Rows are spawned from a serialized prefab reference, never by path,
/// and an empty catalogue shows a themed line instead of a blank card (rule G).
public sealed class _0xefc81b4a : MonoBehaviour
{
    public void _0xeaa50008()
    {
        int _0x9a245c4d = this._0x986e2941._0xfa6a6d7f(this._0x58eefd71._0x2fbb40ce);
        for (int _0xcc6aee46 = 0; _0xcc6aee46 < this._0xfc45ff08.Count; _0xcc6aee46++)
        {
            this._0xfc45ff08[_0xcc6aee46]._0xfb241fba(_0xcc6aee46 + 1, this._0x986e2941._0xb3e6655a(_0xcc6aee46), this._0x58eefd71._0xc0dde847(_0xcc6aee46), this._0x58eefd71._0xc978a968(_0xcc6aee46), _0xcc6aee46 == _0x9a245c4d);
        }
    }

    private readonly List<_0xeaf856ff> _0xfc45ff08 = new List<_0xeaf856ff>();
    [SerializeField]
    private float _firstRowY = 520f;
    private void _0x63f7ee2b()
    {
        if (this._0xbaf2e999 || this._chipHost == null || this._chipPrefab == null)
            return;
        this._0xbaf2e999 = true;
        int _0x06b2d8af = this._0x986e2941._0xb29ba43a;
        for (int _0x9b593249 = 0; _0x9b593249 < _0x06b2d8af; _0x9b593249++)
        {
            _0xeaf856ff _0x820b7e3a = Instantiate(this._chipPrefab, this._chipHost);
            RectTransform _0x23138ab5 = _0x820b7e3a.transform as RectTransform;
            if (_0x23138ab5 != null)
            {
                int _0x0871f30d = _0x9b593249 % 2;
                int _0xf790050e = _0x9b593249 / 2;
                _0x23138ab5.anchorMin = new Vector2(0.5f, 0.5f);
                _0x23138ab5.anchorMax = new Vector2(0.5f, 0.5f);
                _0x23138ab5.pivot = new Vector2(0.5f, 0.5f);
                _0x23138ab5.localScale = Vector3.one;
                _0x23138ab5.anchoredPosition = new Vector2(_0x0871f30d == 0 ? -this._columnOffset : this._columnOffset, this._firstRowY - _0xf790050e * this._rowPitch);
            }

            _0xd930d584 _0x9f8460dc = _0x820b7e3a.GetComponent<_0xd930d584>();
            if (_0x9f8460dc != null)
                _0x9f8460dc._0x04affcbd(_0x9b593249, this);
            this._0xfc45ff08.Add(_0x820b7e3a);
        }

        if (this._emptyLabel != null)
            this._emptyLabel.gameObject.SetActive(_0x06b2d8af == 0);
    }

    private readonly _0x6064955d _0x58eefd71 = new _0x6064955d();
    [SerializeField]
    private _0xc92a9915 _menu;
    /// Picking a stage is confirmed on screen before the scene changes: the chip and
    /// the menu card both repaint (C.7).
    public void _0xed42b199(int _0x44dd3578)
    {
        this._0x58eefd71._0x2fbb40ce = this._0x986e2941._0xfa6a6d7f(_0x44dd3578);
        this._0xeaa50008();
        if (this._menu != null)
            this._menu._0x20f36af3();
        _0x3a079d26.Instance._0x257d8566(_0xb39a7050._0xd84c6d41.SCENE_1);
    }

    [SerializeField]
    private RectTransform _chipHost;
    private void OnEnable()
    {
        this._0x63f7ee2b();
        this._0xeaa50008();
    }

    [SerializeField]
    private float _columnOffset = 250f;
    private readonly _0xbcadf24b _0x986e2941 = new _0xbcadf24b();
    [SerializeField]
    private _0xeaf856ff _chipPrefab;
    [SerializeField]
    private TMP_Text _emptyLabel;
    [SerializeField]
    private float _rowPitch = 345f;
    private bool _0xbaf2e999;
}