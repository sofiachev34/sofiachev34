using UnityEngine;
using UnityEngine.UI;

/// One stage row's click. The row index is handed over by the sheet when it spawns the
/// row, so nothing is resolved by name at runtime.
public sealed class _0xd930d584 : MonoBehaviour
{
    private _0xefc81b4a _0x39dc91c2;
    private void _0x0aabf8fe()
    {
        if (this._0x39dc91c2 != null)
            this._0x39dc91c2._0xed42b199(this._0xfadd8502);
    }

    public void _0x04affcbd(int _0xa86e9d95, _0xefc81b4a _0x805c2bae)
    {
        this._0xfadd8502 = _0xa86e9d95;
        this._0x39dc91c2 = _0x805c2bae;
    }

    private void Start()
    {
        if (this._button != null)
            this._button.onClick.AddListener(() => this._0x0aabf8fe());
    }

    private int _0xfadd8502;
    [SerializeField]
    private Button _button;
}