using UnityEngine;
using UnityEngine.UI;

/// Closes the stage sheet.
public sealed class _0x409184dd : MonoBehaviour
{
    private void Start()
    {
        if (this._button != null)
            this._button.onClick.AddListener(() => this._0x46853531());
    }

    [SerializeField]
    private _0x0b00c526 _gate;
    private void _0x46853531()
    {
        if (this._gate != null)
            this._gate._0xfe2c5761();
    }

    [SerializeField]
    private Button _button;
}