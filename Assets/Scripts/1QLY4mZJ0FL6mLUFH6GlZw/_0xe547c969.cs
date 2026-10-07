using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

/// Taps on the field. Only the new Input System is used, through EnhancedTouch, and
/// the run gate is the template's own IsGameRunning flag so a raised pop really stops
/// play (CLAUDE-unity.md C.1/C.3).
public sealed class _0xe547c969 : MonoBehaviour
{
    [SerializeField]
    private _0x5f7485ec _director;
    private void OnEnable()
    {
        EnhancedTouchSupport.Enable();
    }

    [SerializeField]
    private Camera _camera;
    [SerializeField]
    private float _bottomGuardFraction = 0.12f;
    [SerializeField]
    private float _topGuardFraction = 0.175f;
    private void Update()
    {
        if (this._director == null || this._camera == null)
            return;
        if (_0x3a079d26.Instance == null || !_0x3a079d26.Instance._0x70fe20e5)
            return;
        if (!this._director._0x3472dc8c)
            return;
        foreach (Touch _0x84be29e3 in Touch.activeTouches)
        {
            if (_0x84be29e3.phase != TouchPhase.Ended)
                continue;
            Vector2 _0x61776228 = _0x84be29e3.screenPosition;
            float height = Screen.height;
            if (height > 0f)
            {
                float _0xe55f48f5 = _0x61776228.y / height;
                // keep the HUD strip and the hint strip out of the play area so a tap on
                // a readout never costs a turn
                if (_0xe55f48f5 > 1f - this._topGuardFraction || _0xe55f48f5 < this._bottomGuardFraction)
                    continue;
            }

            Vector3 _0xfe346ef5 = this._camera.ScreenToWorldPoint(new Vector3(_0x61776228.x, _0x61776228.y, 0f));
            this._director._0x4b2edb76(new Vector2(_0xfe346ef5.x, _0xfe346ef5.y));
        }
    }
}