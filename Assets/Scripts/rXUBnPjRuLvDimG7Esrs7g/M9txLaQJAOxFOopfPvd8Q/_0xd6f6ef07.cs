using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xb39a7050;

public class _0xd6f6ef07 : MonoBehaviour
{
    private void _0x1993f8c3()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public List<_0x315577fe> Pops;
    public int CurrentPopIndex;
    public float ScaleDuration = 0.4f;
    public List<int> LastPopIndexes = new();
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xd6f6ef07>();
    }

    public void _0x36945cf6()
    {
        this.LastPopIndexes.RemoveAll(_0x68efad94 => _0x68efad94 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0xadc054c2();
        else
            this._0x4753ff38(this.LastPopIndexes.Last());
    }

    private void _0xcbbda650()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public _0x315577fe _0xf4b0a9e1(int _0x06b2059a)
    {
        return this.Pops[_0x06b2059a];
    }

    public static _0xd6f6ef07 Instance;
    public List<GameObject> GameObjectsToHide;
    private void _0x08d6e623(bool _0x6958cebe = false)
    {
        for (int _0xa3087424 = 0; _0xa3087424 < this.Pops.Count; ++_0xa3087424)
            if (this.Pops[_0xa3087424] != null && !(_0xa3087424 == this.CurrentPopIndex && _0x6958cebe))
                this.Pops[_0xa3087424]._0x5e1f9f12();
    }

    public void _0xadc054c2()
    {
        this.LastPopIndexes.Clear();
        this._0x08d6e623();
        foreach (GameObject _0xa49adcbc in this.GameObjectsToHide)
            if (_0xa49adcbc != null)
                _0xa49adcbc.SetActive(true);
        this._0x1993f8c3();
    }

    public GameObject BlurBackground;
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x315577fe _0xb76dd263 in this.Pops)
            if (_0xb76dd263 != null)
                _0xb76dd263.gameObject.SetActive(true);
    }

    public void _0x4753ff38(int _0x647fea0d)
    {
        this.CurrentPopIndex = _0x647fea0d;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x08d6e623(true);
        this._0xcbbda650();
        this.Pops[_0x647fea0d].Show();
        foreach (GameObject _0x62368ef6 in this.GameObjectsToHide)
            _0x62368ef6.SetActive(false);
    }
}