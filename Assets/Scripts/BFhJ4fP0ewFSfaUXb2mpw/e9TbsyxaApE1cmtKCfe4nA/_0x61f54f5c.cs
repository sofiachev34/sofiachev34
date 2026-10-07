using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x61f54f5c : MonoBehaviour
{
    private void _0x9d5a626a()
    {
        if (this._0x433eb610.canvasRenderer.GetColor() != this._0x08a48113.canvasRenderer.GetColor())
            this._0x08a48113.canvasRenderer.SetColor(this._0x433eb610.canvasRenderer.GetColor());
    }

    private void Update()
    {
        this._0x9d5a626a();
    }

    private Image _0x433eb610;
    private TMP_Text _0x08a48113;
}