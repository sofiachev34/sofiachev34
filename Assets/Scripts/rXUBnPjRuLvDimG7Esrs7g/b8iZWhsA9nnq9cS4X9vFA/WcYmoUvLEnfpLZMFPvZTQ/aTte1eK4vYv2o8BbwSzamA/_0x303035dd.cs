using UnityEngine;
using UnityEngine.UI;

public class _0x303035dd : MonoBehaviour
{
    public Button NextTutorialButton;
    public int NextTutorialPanelIndex;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x09bc71db.Instance._0x1bf59810(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x3a079d26.Instance._0xe2d31fe3());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x09bc71db.Instance._0x1bf59810(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x09bc71db.Instance._0x1bf59810(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x3a079d26.Instance._0xe2d31fe3());
        }
    }

    public bool IsTutorialEndPanel;
    public Button TutorialEndButton;
    public int EndTutorialPanelIndex = 1;
}