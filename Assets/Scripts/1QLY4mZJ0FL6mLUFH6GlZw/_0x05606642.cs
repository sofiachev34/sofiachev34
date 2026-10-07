using UnityEngine;
using UnityEngine.UI;

/// Leaves the field for the menu, by scene index.
public sealed class _0x05606642 : MonoBehaviour
{
    [SerializeField]
    private Button _button;
    private void _0xab1c5969()
    {
        _0x3a079d26.Instance._0x5c679b5d(true);
        _0x3a079d26.Instance._0x257d8566(_0xb39a7050._0xd84c6d41.SCENE_0);
    }

    private void Start()
    {
        if (this._button != null)
            this._button.onClick.AddListener(() => this._0xab1c5969());
    }
}