using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0xffb85962 : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0xa878dc25 != null)
            return;
        GameObject _0x6dcb1208 = new GameObject(_0x50f88158._0x742d2990(new byte[16] { 36, 29, 0, 51, 31, 30, 4, 2, 17, 3, 4, 55, 5, 17, 2, 20 }, 112));
        _0x6dcb1208.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x6dcb1208);
        _0xa878dc25 = _0x6dcb1208.AddComponent<_0xffb85962>();
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x4b6d80e1;
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x47029823)
    {
        return 0.2126f * Linear(_0x47029823.r) + 0.7152f * Linear(_0x47029823.g) + 0.0722f * Linear(_0x47029823.b);
    }

    private const float MinOutlineWidth = 0.01f;
    private void OnEnable()
    {
        if (this._0x4b6d80e1 == null)
            this._0x4b6d80e1 = _0x71440e3c => this._0xdf72d638(_0x71440e3c);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x4b6d80e1);
    }

    private static _0xffb85962 _0xa878dc25;
    private void LateUpdate()
    {
        if (this._0x823e5420.Count == 0)
            return;
        this._0xfe3432e8.Clear();
        this._0xfe3432e8.AddRange(this._0x823e5420);
        this._0x823e5420.Clear();
        for (int _0x4e73b06b = 0; _0x4e73b06b < this._0xfe3432e8.Count; _0x4e73b06b++)
            Fix(this._0xfe3432e8[_0x4e73b06b]);
    }

    private const float TargetRatio = 7f;
    private readonly HashSet<TMP_Text> _0x823e5420 = new HashSet<TMP_Text>();
    private const float MinRatio = 4.5f;
    private static float Linear(float _0xe2496b2c)
    {
        _0xe2496b2c = Mathf.Clamp01(_0xe2496b2c);
        return _0xe2496b2c <= 0.03928f ? _0xe2496b2c / 12.92f : Mathf.Pow((_0xe2496b2c + 0.055f) / 1.055f, 2.4f);
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0xdf72d638(Object _0x6126d182)
    {
        TMP_Text _0xc401804b = _0x6126d182 as TMP_Text;
        if (_0xc401804b != null)
            this._0x823e5420.Add(_0xc401804b);
    }

    private static float Ratio(Color _0xfbeef31f, Color _0x69cd57cb)
    {
        float _0xa5436251 = Luminance(_0xfbeef31f);
        float _0xf5fa35d4 = Luminance(_0x69cd57cb);
        return (Mathf.Max(_0xa5436251, _0xf5fa35d4) + 0.05f) / (Mathf.Min(_0xa5436251, _0xf5fa35d4) + 0.05f);
    }

    private static void Fix(TMP_Text _0x5840beda)
    {
        if (_0x5840beda == null || !_0x5840beda.isActiveAndEnabled)
            return;
        Material _0x4dd99430 = _0x5840beda.fontSharedMaterial;
        if (_0x4dd99430 == null || !_0x4dd99430.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x4dd99430.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x4dd99430.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x3c256ce7 = _0x5840beda.color;
        if (_0x3c256ce7.a <= 0f)
            return;
        Color _0x467a9970 = _0x4dd99430.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x3c256ce7, _0x467a9970) >= MinRatio)
            return;
        Color _0x41bf6208 = Luminance(_0x467a9970) < 0.5f ? Color.white : Color.black;
        Color _0x0064b4ba;
        if (Ratio(_0x41bf6208, _0x467a9970) < TargetRatio)
        {
            _0x0064b4ba = _0x41bf6208;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x30a87bd2 = 0f;
            float _0x575f0eb5 = 1f;
            for (int _0x07f22e4b = 0; _0x07f22e4b < 20; _0x07f22e4b++)
            {
                float _0x63f00369 = (_0x30a87bd2 + _0x575f0eb5) * 0.5f;
                if (Ratio(Color.Lerp(_0x3c256ce7, _0x41bf6208, _0x63f00369), _0x467a9970) >= TargetRatio)
                    _0x575f0eb5 = _0x63f00369;
                else
                    _0x30a87bd2 = _0x63f00369;
            }

            _0x0064b4ba = Color.Lerp(_0x3c256ce7, _0x41bf6208, _0x575f0eb5);
        }

        _0x0064b4ba.a = _0x3c256ce7.a;
        _0x5840beda.color = _0x0064b4ba;
    }

    private void OnDisable()
    {
        if (this._0x4b6d80e1 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x4b6d80e1);
    }

    private readonly List<TMP_Text> _0xfe3432e8 = new List<TMP_Text>();
}

internal static class _0x50f88158
{
    internal static string _0x742d2990(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}