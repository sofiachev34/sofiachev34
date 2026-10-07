using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0xb39a7050;

public class _0x3a079d26 : MonoBehaviour
{
    private void _0x983ea3e5()
    {
        IsAfterLevelComplete = true;
        Instance._0x257d8566(_0xd84c6d41.SCENE_0);
    }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public static bool IsAfterLevelFailed = false;
    [HideInInspector]
    public List<_0xd05ebe76> MoneyCountContainers = new();
    public Transform EnvironmentWithTweensToToggle;
    private void _0x40131bdf(bool _0x360052b3)
    {
        Rigidbody2D[] _0x59ac3175 = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x5f7c1bf5 in _0x59ac3175)
            if (_0x360052b3)
                _0x5f7c1bf5.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x5f7c1bf5.constraints = RigidbodyConstraints2D.None;
    }

    private static void MakeGrid(List<RectTransform> _0xed698496, AspectRatioFitter _0x6db1fdfd, float _0xbc305c46, int _0xd7579de0, int _0x87a57e69)
    {
        _0x6db1fdfd.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x6db1fdfd.aspectRatio = _0xbc305c46;
        foreach (RectTransform _0x4d773331 in _0xed698496)
        {
            int _0x86e293aa = _0x4d773331.transform.GetSiblingIndex();
            _0x4d773331.anchorMin = new Vector3(Mathf.FloorToInt((float)_0x86e293aa % _0xd7579de0) * (1f / _0xd7579de0), (_0x87a57e69 - (Mathf.FloorToInt((float)_0x86e293aa / _0xd7579de0) % _0x87a57e69 + 1f)) * (1f / _0x87a57e69));
            _0x4d773331.anchorMax = new Vector3(Mathf.FloorToInt((float)_0x86e293aa % _0xd7579de0 + 1f) * (1f / _0xd7579de0), (_0x87a57e69 - Mathf.FloorToInt((float)_0x86e293aa / _0xd7579de0) % _0x87a57e69) * (1f / _0x87a57e69));
            _0x4d773331.offsetMin = Vector2.zero;
            _0x4d773331.offsetMax = Vector2.zero;
        }
    }

    private static void ExitGame()
    {
        Application.Quit();
    }

    public static _0x8bf537eb _0xa5b32cd6 => _0x8bf537eb.ALL_SCENES_SETTING_SINGLETONS[Instance._0x2859b210];

    public void _0xe2d31fe3()
    {
        _0xa5b32cd6._0x40741427 = true;
    }

    public Button DeleteProgressDataButton;
    public int _0x2859b210 => SceneManager.GetActiveScene().buildIndex;
    public bool _0x70fe20e5 { get; private set; }

    private void Start()
    {
        if (this._0x2859b210 != _0xd84c6d41.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0x257d8566(_0xd84c6d41.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0xa5b32cd6._0x40741427 = false;
            _0xd6f6ef07.Instance._0xadc054c2();
            _0x09bc71db.Instance._0x1bf59810(_0x58729df1.TUTORIAL0);
        });
    }

    public Transform Environment;
    public void _0x5c679b5d(bool _0x92379488)
    {
        this._0x70fe20e5 = _0x92379488;
        this._0x40131bdf(!this._0x70fe20e5);
        Physics2D.simulationMode = this._0x70fe20e5 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0xb77cdf2a(this.EnvironmentWithTweensToToggle);
    }

    public Button ShowResetTutorialButton;
    private IEnumerator _0x7febf910(int _0x7d8ea766)
    {
        _0x09bc71db.Instance._0x1bf59810(_0x58729df1.SPLASH);
        AsyncOperation _0x1f60aa39 = SceneManager.LoadSceneAsync(_0x7d8ea766);
        while (!_0x1f60aa39.isDone)
            yield return null;
    }

    private void _0xb77cdf2a(Transform _0x02fecf73)
    {
        Transform[] _0x76a1afb1 = _0x02fecf73.GetComponentsInChildren<Transform>();
        foreach (Transform _0xfc714473 in _0x76a1afb1)
            if (_0xfc714473 != null && DOTween.IsTweening(_0xfc714473))
            {
                if (this._0x70fe20e5)
                    DOTween.Play(_0xfc714473);
                else
                    DOTween.Pause(_0xfc714473);
            }
    }

    private static _0x8bf537eb GAME_INDEX_SETTINGS(int _0x268cdb72)
    {
        return _0x8bf537eb.ALL_SCENES_SETTING_SINGLETONS[_0x268cdb72];
    }

    public void _0x257d8566(int _0xbd64449e)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0x7febf910(_0xbd64449e));
    }

    private static _0x8bf537eb _0x29e19804 => _0x8bf537eb.ALL_SCENES_SETTING_SINGLETONS[0];

    private IEnumerator _0x05499d60(string _0x8e48336a)
    {
        _0x09bc71db.Instance._0x1bf59810(_0x58729df1.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x3abef4ba = SceneManager.LoadSceneAsync(_0x8e48336a);
        while (!_0x3abef4ba.isDone)
            yield return null;
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x3a079d26>();
        this.RootGameObject = GameObject.FindWithTag(_0x0d4472f6._0x2fa2b5d5(new byte[4] { 16, 45, 45, 54 }, 66));
        if (this._0x2859b210 == _0xd84c6d41.SCENE_0)
            this._0x5c679b5d(true);
        else
            this._0x5c679b5d(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0xd05ebe76>(true).ToList();
    }

    public static bool IsAfterLevelComplete;
    public Canvas MainCanvas;
    public void _0x44b3b5b9()
    {
        foreach (_0xd05ebe76 _0x5ead5295 in this.MoneyCountContainers)
            _0x5ead5295._0x7f75c9ef();
    }

    public void _0x56267db6()
    {
        this._0x257d8566(SceneManager.GetActiveScene().buildIndex);
    }

    public static _0x3a079d26 Instance;
}

internal static class _0x0d4472f6
{
    internal static string _0x2fa2b5d5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}