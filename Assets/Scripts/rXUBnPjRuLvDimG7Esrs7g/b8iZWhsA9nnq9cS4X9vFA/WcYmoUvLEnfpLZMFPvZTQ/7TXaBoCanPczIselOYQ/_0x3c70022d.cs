using UnityEngine;
using UnityEngine.UI;

public class _0x3c70022d : MonoBehaviour
{
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0xd6f6ef07.Instance._0x36945cf6();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0xd6f6ef07.Instance._0xadc054c2());
        else
            this.Button.onClick.AddListener(() => _0xd6f6ef07.Instance._0x4753ff38(this.PopToShowIndex));
    }

    public int PopToShowIndex;
    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsHideAllPops;
    public bool IsShowLastPop;
}