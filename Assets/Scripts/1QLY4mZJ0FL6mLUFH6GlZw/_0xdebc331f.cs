using UnityEngine;
using UnityEngine.UI;

/// Re-opens the how-to pages. Panels are addressed by their SETTINGS index, which is
/// the only addressing obfuscation cannot break.
public sealed class _0xdebc331f : MonoBehaviour
{
    private void Start()
    {
        if (this._button != null)
            this._button.onClick.AddListener(() => this._0xe5013115());
    }

    private void _0xe5013115()
    {
        _0x09bc71db.Instance._0x1bf59810(_0xb39a7050._0x58729df1.TUTORIAL0);
    }

    [SerializeField]
    private Button _button;
}