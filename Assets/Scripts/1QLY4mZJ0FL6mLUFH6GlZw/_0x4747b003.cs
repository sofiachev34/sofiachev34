using UnityEngine;
using UnityEngine.UI;

/// Paints the splash loading bar in the game's palette. The template ships the track at
/// alpha 0.004 - invisible - so progress reads as nothing at all (rule G, stage 5d2c).
/// References are serialized; the Slider lookup is by TYPE, never by name.
public sealed class _0x4747b003 : MonoBehaviour
{
    [SerializeField]
    private Image _track;
    private void Awake()
    {
        Slider _0x18ee5a1b = this._bar;
        if (_0x18ee5a1b == null)
            _0x18ee5a1b = this.GetComponentInChildren<Slider>(true);
        Image _0x3bc5b5be = this._fill;
        if (_0x3bc5b5be == null && _0x18ee5a1b != null && _0x18ee5a1b.fillRect != null)
            _0x3bc5b5be = _0x18ee5a1b.fillRect.GetComponent<Image>();
        if (_0x3bc5b5be != null)
            _0x3bc5b5be.color = new Color(0.219608f, 0.784314f, 1f, 1f);
        if (this._track != null)
            this._track.color = new Color(0.039216f, 0.058824f, 0.156863f, 0.88f);
    }

    [SerializeField]
    private Image _fill;
    [SerializeField]
    private Slider _bar;
}