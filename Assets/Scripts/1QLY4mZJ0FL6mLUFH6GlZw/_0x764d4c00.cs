using UnityEngine;
using UnityEngine.UI;

/// Pause. The template's own ShowPopButton would raise the card but leave the run
/// going, so the director freezes play and fills the card before it is shown (C.3).
public sealed class _0x764d4c00 : MonoBehaviour
{
    [SerializeField]
    private Button _button;
    [SerializeField]
    private _0x5f7485ec _director;
    private void Start()
    {
        if (this._button != null)
            this._button.onClick.AddListener(() => this._0xad969bf2());
    }

    private void _0xad969bf2()
    {
        if (this._director != null)
            this._director._0x2b09ae91();
    }
}