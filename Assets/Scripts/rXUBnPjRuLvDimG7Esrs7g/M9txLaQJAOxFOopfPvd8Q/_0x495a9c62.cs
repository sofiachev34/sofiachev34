using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x495a9c62 : MonoBehaviour
{
    private void _0xaab1175b()
    {
        if (this.ScoreCurrent >= this._0xf282246e)
            this._0x1353545b();
        else
            this._0x82560866();
    }

    private void _0x2d8a9e3c()
    {
        if (this.ScoreCurrent > _0x3a079d26._0xa5b32cd6._0x6796988f)
            _0x3a079d26._0xa5b32cd6._0x6796988f = this.ScoreCurrent;
        if (_0xfa938ad6.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0xf282246e)
                this._0x1353545b();
    }

    public List<Button> PauseButtons = new();
    [HideInInspector]
    public int TimeLeft;
    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x2dd82d7e;
        this.CurrentGameIndex = _0x3a079d26.Instance._0x2859b210;
        foreach (Button _0xa432d318 in this.HomeButtons)
            _0xa432d318.onClick.AddListener(() =>
            {
                this._0x94763b1e();
            });
        foreach (Button _0x0350f7c4 in this.PauseButtons)
            _0x0350f7c4.onClick.AddListener(() =>
            {
                _0x3a079d26.Instance._0x5c679b5d(false);
                _0xd6f6ef07.Instance._0x4753ff38(_0xb39a7050._0x5d80e5e2.PAUSE);
            });
        this._0xffcf7356();
        this.LevelNumberText.ForEach(_0xde8eb51d => _0xde8eb51d.text = $"LVL {_0x3a079d26._0xa5b32cd6._0x1ac66dd9 + 1}");
        if (_0xfa938ad6.Instance.IsTimerEnabled)
        {
            this._0x2f79abed();
            this.StartCoroutine(this._0x79b716a1());
        }
    }

    public void _0x82560866()
    {
        if (_0xfa938ad6.Instance.IsOnlyWinGameEndEnabled)
            this._0x1353545b();
        if (!this.IsGameEnd)
        {
            this._0xeda09fe8();
            _0x3a079d26.IsAfterLevelComplete = false;
            _0x3a079d26.IsAfterLevelFailed = true;
            _0x315577fe _0x82635463 = _0xd6f6ef07.Instance._0xf4b0a9e1(_0xb39a7050._0x5d80e5e2.LOSE).GetComponent<_0x315577fe>();
            if (_0xfa938ad6.Instance.IsCheckScoreEnabled)
                _0x82635463.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xf282246e}";
            else
                _0x82635463.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x82635463.ContentAdditionalText.text = $"{0}";
            _0xb39a7050._0xf9f3518f._0xcbf50c6c += 0;
            _0xd6f6ef07.Instance._0x4753ff38(_0xb39a7050._0x5d80e5e2.LOSE);
        }
    }

    private void Awake()
    {
        _0xf60ae8eb = this.gameObject.GetComponent<_0x495a9c62>();
    }

    public void _0x6b65e30d(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0xffcf7356();
            this._0x2d8a9e3c();
        }
    }

    public List<Button> HomeButtons = new();
    private void _0xffcf7356()
    {
        if (_0xfa938ad6.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0xde8eb51d => _0xde8eb51d.text = $"{this.ScoreCurrent}/{this._0xf282246e}");
        else
            this.ScoreText.ForEach(_0xde8eb51d => _0xde8eb51d.text = $"{this.ScoreCurrent}");
    }

    public List<TMP_Text> ScoreText = new();
    public void _0x1353545b()
    {
        if (!this.IsGameEnd)
        {
            this._0xeda09fe8();
            _0x3a079d26.IsAfterLevelComplete = true;
            _0x3a079d26.IsAfterLevelFailed = false;
            _0x315577fe _0x70ac2a4e = _0xd6f6ef07.Instance._0xf4b0a9e1(_0xb39a7050._0x5d80e5e2.WIN).GetComponent<_0x315577fe>();
            if (_0xfa938ad6.Instance.IsCheckScoreEnabled)
                _0x70ac2a4e.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xf282246e}";
            else
                _0x70ac2a4e.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0xfa938ad6.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0xb39a7050._0xf9f3518f._0xcbf50c6c)
                    _0xb39a7050._0xf9f3518f._0xcbf50c6c = this.ScoreCurrent;
                _0x70ac2a4e.ContentAdditionalText.text = $"{_0xb39a7050._0xf9f3518f._0xcbf50c6c}";
            }
            else
            {
                _0x70ac2a4e.ContentAdditionalText.text = $"{this._0xcbc21a83}";
                _0xb39a7050._0xf9f3518f._0xcbf50c6c += this._0xcbc21a83;
            }

            if (_0xfa938ad6.Instance.IsLevelIncrementOnWin)
                ++_0x3a079d26._0xa5b32cd6._0x1ac66dd9;
            _0xd6f6ef07.Instance._0x4753ff38(_0xb39a7050._0x5d80e5e2.WIN);
        }
    }

    private void _0xeda09fe8()
    {
        this.IsGameEnd = true;
        _0x3a079d26.IsAfterLevelComplete = true;
    }

    public List<TMP_Text> SubtitleText = new();
    public void _0x94763b1e()
    {
        _0x3a079d26.Instance._0x5c679b5d(true);
        _0x3a079d26.Instance._0x257d8566(_0xb39a7050._0xd84c6d41.SCENE_0);
    }

    private int _0x2dd82d7e => this.CustomTimeInitial + _0x3a079d26._0xa5b32cd6._0x1ac66dd9 * 10;

    private static _0x495a9c62 _0xf60ae8eb;
    public List<TMP_Text> TimerText = new();
    public int CustomTargetScore = 10;
    public List<TMP_Text> LevelNumberText = new();
    [HideInInspector]
    public int CurrentGameIndex;
    public int CustomTimeInitial = 30;
    [HideInInspector]
    public int ScoreCurrent;
    private int _0xf282246e => this.CustomTargetScore + _0x3a079d26._0xa5b32cd6._0x1ac66dd9 * 10;

    [HideInInspector]
    public bool IsGameEnd;
    private void _0x2f79abed()
    {
        this.TimerText.ForEach(_0xde8eb51d => _0xde8eb51d.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x2f2e720b._0x69b60969(new byte[6] { 196, 196, 245, 147, 218, 218 }, 169)));
    }

    private int _0xcbc21a83 => this.ScoreCurrent;

    private IEnumerator _0x79b716a1()
    {
        this._0x2f79abed();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x3a079d26.Instance._0x2859b210 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x3a079d26.Instance._0x70fe20e5)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x2f79abed();
            }
        }

        if (!this.IsGameEnd)
            this._0x82560866();
    }
}

internal static class _0x2f2e720b
{
    internal static string _0x69b60969(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}