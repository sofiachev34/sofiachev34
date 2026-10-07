using TMPro;
using UnityEngine;
using static _0xb39a7050;

public class _0xd05ebe76 : MonoBehaviour
{
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0xb8343ab0;
            if (this.gameObject.TryGetComponent(out _0xb8343ab0))
                this.MoneyCountText = _0xb8343ab0;
        }

        this._0x7f75c9ef();
    }

    public void _0x7f75c9ef()
    {
        this.MoneyCountText.text = _0xf9f3518f._0xcbf50c6c.ToString();
    }

    public TMP_Text MoneyCountText;
}