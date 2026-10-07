using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x5d4cefdb : MonoBehaviour
{
    private void Update()
    {
        int _0xc4a7cc4a = 1;
        if (this._0x1525e894.Count > 0)
        {
            string _0xaf6b646a = this._0xe96b9906.text;
            foreach (string _0xc2f76084 in this._0x1525e894)
                while (_0xaf6b646a.Contains(_0xc2f76084))
                    _0xaf6b646a = _0xaf6b646a.Replace(_0xc2f76084, "");
            _0xc4a7cc4a = _0xaf6b646a.Length;
        }
        else
        {
            _0xc4a7cc4a = this._0xe96b9906.text.Length;
        }

        float _0xa137e37b = Mathf.Clamp(this._0x080a8324 + this._0xe2779cfb * _0xc4a7cc4a, this._0xfd8939c9, this._0x7dd736e7);
        if (!Mathf.Approximately(this._0x7e77b46e.aspectRatio, _0xa137e37b))
            this._0x7e77b46e.aspectRatio = _0xa137e37b;
    }

    private List<string> _0x1525e894 = new();
    private float _0xe2779cfb = 0.6f;
    private float _0xfd8939c9 = 1.5f;
    private float _0x080a8324;
    private AspectRatioFitter _0x7e77b46e;
    private float _0x7dd736e7 = 4;
    private TMP_Text _0xe96b9906;
}