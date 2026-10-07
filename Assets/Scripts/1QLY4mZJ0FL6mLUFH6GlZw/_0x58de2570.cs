using UnityEngine;
using UnityEngine.UI;

/// Opens the stage sheet. The Button is held by a serialized reference and the click
/// is subscribed with a lambda - a method group would survive renaming only by luck
/// and breaks the cloud build (CLAUDE-unity.md C.1).
public sealed class _0x58de2570 : MonoBehaviour
{
    [SerializeField]
    private _0x0b00c526 _gate;
    private void Start()
    {
        if (this._button != null)
            this._button.onClick.AddListener(() => this._0xe8419e84());
    }

    [SerializeField]
    private Button _button;
    private void _0xe8419e84()
    {
        if (this._gate != null)
            this._gate.Show();
    }
}