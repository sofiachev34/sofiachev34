using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xb39a7050;

public class _0x09bc71db : MonoBehaviour
{
    private void _0xeeb0c1c5(int _0x40eba885)
    {
        this.LastPanelIndexes.Add(_0x40eba885);
        this.CurrentPanelIndex = _0x40eba885;
        for (int _0xb9990743 = 0; _0xb9990743 < this.Panels.Count; _0xb9990743++)
            if (_0xb9990743 != _0x40eba885 && this.Panels[_0xb9990743] != null)
                this.Panels[_0xb9990743]._0x98af48a3();
    }

    private void Start()
    {
        this._0x2f704987();
    }

    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    public void _0x1bf59810(int _0x320b8c37)
    {
        this._0x9b29c637(_0x320b8c37);
        this._0x22a5813d(_0x320b8c37);
        this.CurrentPanelIndex = _0x320b8c37;
        this.Panels[_0x320b8c37].Show();
    }

    public int CurrentPanelIndex;
    public List<_0x1e2765bb> Panels;
    private void _0x9b29c637(int _0xedd68008)
    {
        this.LastPanelIndexes.Add(_0xedd68008);
        this.CurrentPanelIndex = _0xedd68008;
        for (int _0x7020eca3 = 0; _0x7020eca3 < this.Panels.Count; _0x7020eca3++)
            if (_0x7020eca3 != _0xedd68008 && this.Panels[_0x7020eca3] != null)
                this.Panels[_0x7020eca3]._0x98af48a3();
    }

    private void _0x2f704987()
    {
        this._0x60763c74(_0x58729df1.SPLASH);
        if (_0x3a079d26.Instance._0x2859b210 == _0xd84c6d41.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x9765d4e7.Instance.DefaultAnimationTime);
        }
    }

    private void SwitchSplash()
    {
        if (_0xfa938ad6.Instance.IsTutorialEnabled && !_0x3a079d26._0xa5b32cd6._0x40741427)
            this._0x1bf59810(_0x58729df1.TUTORIAL0);
        else
            this._0x1bf59810(_0x58729df1.DEFAULT);
    }

    public void _0xa82a188d()
    {
        this.LastPanelIndexes.RemoveAll(_0x68efad94 => _0x68efad94 == this.CurrentPanelIndex);
        int _0x7547deaf = this.LastPanelIndexes.Last();
        this._0x22a5813d(_0x7547deaf);
        this._0xeeb0c1c5(_0x7547deaf);
        this.CurrentPanelIndex = _0x7547deaf;
        this.Panels[_0x7547deaf].Show();
    }

    public void _0x8e66592f(int _0x57e1e9ad)
    {
        if (_0x57e1e9ad == _0x58729df1.SPLASH && _0x3a079d26.Instance._0x2859b210 != _0xd84c6d41.SCENE_0)
            _0x9765d4e7.Instance._0xf676e8a5();
        if (_0x3a079d26.Instance._0x2859b210 != _0xd84c6d41.SCENE_0)
        {
            if (_0x57e1e9ad == _0x58729df1.SPLASH || _0x57e1e9ad == _0x58729df1.TUTORIAL0)
                _0x3a079d26.Instance._0x5c679b5d(false);
            else if (_0x57e1e9ad == _0x58729df1.DEFAULT)
                _0x3a079d26.Instance._0x5c679b5d(true);
        }
    }

    public float ScaleDuration = 0.4f;
    public float StaticBlurMaterialInitialValue;
    public static _0x09bc71db Instance;
    private _0x1e2765bb _0xd4c861cf(int _0xc3ba4208)
    {
        return this.Panels[_0xc3ba4208];
    }

    public bool IsShowSplashOnStart = true;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x09bc71db>();
    }

    private void _0x22a5813d(int _0xb1e32226)
    {
        if (_0xb1e32226 == _0x58729df1.SPLASH)
            _0x9765d4e7.Instance._0xc38d216e();
        if (_0x3a079d26.Instance._0x2859b210 == _0xd84c6d41.SCENE_0)
        {
        }
    }

    private void _0x60763c74(int _0x3bcadef7)
    {
        this._0x9b29c637(_0x3bcadef7);
        this._0x22a5813d(_0x3bcadef7);
        this.CurrentPanelIndex = _0x3bcadef7;
        this.Panels[_0x3bcadef7]._0x65edcb81();
    }
}