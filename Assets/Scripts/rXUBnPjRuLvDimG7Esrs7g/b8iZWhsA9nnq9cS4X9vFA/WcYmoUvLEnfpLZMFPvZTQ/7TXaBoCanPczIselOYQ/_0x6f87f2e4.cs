using UnityEngine;
using UnityEngine.UI;

public class _0x6f87f2e4 : MonoBehaviour
{
    private int _0x8d2b9770;
    private Button _0x18c23bd6;
    private void Awake()
    {
        if (this._0x18c23bd6 == null)
            if (!this.TryGetComponent(out this._0x18c23bd6))
                this._0x18c23bd6 = this.GetComponentInChildren<Button>();
    }

    private bool _0xea03804c;
    private void Start()
    {
        if (this._0xea03804c)
            this._0x18c23bd6.onClick.AddListener(() => _0x09bc71db.Instance._0xa82a188d());
        else
            this._0x18c23bd6.onClick.AddListener(() => _0x09bc71db.Instance._0x1bf59810(this._0x8d2b9770));
    }
}