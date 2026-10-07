using UnityEngine;
using UnityEngine.UI;

public class _0x31ef5fbc : MonoBehaviour
{
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x3a079d26.Instance._0x5c679b5d(this.IsPhysicsRunOnClick));
    }

    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsPhysicsRunOnClick;
}