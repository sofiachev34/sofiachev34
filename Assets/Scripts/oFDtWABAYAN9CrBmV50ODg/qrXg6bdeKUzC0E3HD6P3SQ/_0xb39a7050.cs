using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0xb39a7050
{
    public static class _0xf9f3518f
    {
        public static int _0xcbf50c6c
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xb2038329._0xf783e763(new byte[5] { 153, 181, 179, 180, 169 }, 218)))
                    PlayerPrefs.SetInt(_0xb2038329._0xf783e763(new byte[5] { 69, 105, 111, 104, 117 }, 6), 0);
                return PlayerPrefs.GetInt(_0xb2038329._0xf783e763(new byte[5] { 201, 229, 227, 228, 249 }, 138));
            }

            set
            {
                PlayerPrefs.SetInt(_0xb2038329._0xf783e763(new byte[5] { 227, 207, 201, 206, 211 }, 160), value);
                _0x3a079d26.Instance._0x44b3b5b9();
            }
        }
    }

    public static class _0x5d80e5e2
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public class _0x8bf537eb
    {
        private static readonly _0x8bf537eb _0x5dd93983 = new();
        public static readonly _0x8bf537eb[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x5dd93983,
            _0x5dd93983,
            _0x5dd93983,
        };
        private int _0xa8070048 => 0;
        private int _0x6cdd8cf1 => 10;
        private string _0x54c7d5ea => _0xb2038329._0xf783e763(new byte[4] { 147, 187, 176, 171 }, 222);
        private string _0xa699f840 => _0xb2038329._0xf783e763(new byte[8] { 233, 224, 243, 224, 233, 222, 149, 216 }, 165);

        private int _0x28a69f65
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xb2038329._0xf783e763(new byte[25] { 217, 239, 232, 232, 255, 244, 238, 221, 246, 245, 248, 251, 246, 217, 242, 251, 234, 238, 255, 232, 211, 244, 254, 255, 226 }, 154)))
                    PlayerPrefs.SetInt(_0xb2038329._0xf783e763(new byte[25] { 234, 220, 219, 219, 204, 199, 221, 238, 197, 198, 203, 200, 197, 234, 193, 200, 217, 221, 204, 219, 224, 199, 205, 204, 209 }, 169), 0);
                return PlayerPrefs.GetInt(_0xb2038329._0xf783e763(new byte[25] { 235, 221, 218, 218, 205, 198, 220, 239, 196, 199, 202, 201, 196, 235, 192, 201, 216, 220, 205, 218, 225, 198, 204, 205, 208 }, 168));
            }

            set => PlayerPrefs.SetInt(_0xb2038329._0xf783e763(new byte[25] { 125, 75, 76, 76, 91, 80, 74, 121, 82, 81, 92, 95, 82, 125, 86, 95, 78, 74, 91, 76, 119, 80, 90, 91, 70 }, 62), value);
        }

        public int _0x1ac66dd9
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x54c7d5ea}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x54c7d5ea}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x54c7d5ea}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x54c7d5ea}CurrentLevelIndex", value);
        }

        public int _0x6796988f
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x54c7d5ea}BestScore"))
                    this._0x6796988f = 0;
                return PlayerPrefs.GetInt($"{this._0x54c7d5ea}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x54c7d5ea}BestScore", value);
        }

        public bool _0x40741427
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x54c7d5ea}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x54c7d5ea}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x54c7d5ea}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x54c7d5ea}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x58729df1
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public static class _0xd84c6d41
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }
}

internal static class _0xb2038329
{
    internal static string _0xf783e763(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}