using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x858b93b1 : MonoBehaviour
{
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x3a079d26.Instance._0x257d8566(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x3a079d26.Instance._0x257d8566(this.LoadSceneId));
    }

    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public int LoadSceneId;
    public bool IsLoadCurrentScene;
}