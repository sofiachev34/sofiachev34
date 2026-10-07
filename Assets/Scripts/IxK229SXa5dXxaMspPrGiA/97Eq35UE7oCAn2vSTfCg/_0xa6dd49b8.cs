using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0xa6dd49b8 : MonoBehaviour
{
    private float _0xefe8f776 = 0f;
    private bool _0x3fab52e8(int _0x542aa985, string _0x25636365, string _0xb310bbb4)
    {
        if (string.IsNullOrEmpty(_0xb310bbb4))
            return false;
        if (!IsHttpUrl(_0xb310bbb4))
            return true;
        if (string.IsNullOrEmpty(_0x25636365))
            return false;
        return _0x25636365.IndexOf(_0x0a5e32f2._0x73015297(new byte[20] { 214, 193, 193, 204, 208, 220, 221, 221, 214, 208, 199, 218, 220, 221, 204, 193, 214, 192, 214, 199 }, 147), StringComparison.OrdinalIgnoreCase) >= 0 || _0x25636365.IndexOf(_0x0a5e32f2._0x73015297(new byte[22] { 218, 205, 205, 192, 220, 208, 209, 209, 218, 220, 203, 214, 208, 209, 192, 205, 218, 217, 202, 204, 218, 219 }, 159), StringComparison.OrdinalIgnoreCase) >= 0 || _0x25636365.IndexOf(_0x0a5e32f2._0x73015297(new byte[21] { 131, 148, 148, 153, 133, 137, 136, 136, 131, 133, 146, 143, 137, 136, 153, 133, 138, 137, 149, 131, 130 }, 198), StringComparison.OrdinalIgnoreCase) >= 0 || _0x25636365.IndexOf(_0x0a5e32f2._0x73015297(new byte[22] { 122, 109, 109, 96, 106, 113, 116, 113, 112, 104, 113, 96, 106, 109, 115, 96, 108, 124, 119, 122, 114, 122 }, 63), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0x1e000e5a { get; set; }

    private bool _0x585e3ccd(string _0x9ab08131)
    {
        if (string.IsNullOrEmpty(_0x9ab08131))
            return false;
        try
        {
            using (var _0x9fd6addd = new AndroidJavaClass(_0x0a5e32f2._0x73015297(new byte[30] { 52, 56, 58, 121, 34, 57, 62, 35, 46, 100, 51, 121, 39, 59, 54, 46, 50, 37, 121, 2, 57, 62, 35, 46, 7, 59, 54, 46, 50, 37 }, 87)))
            using (var _0x32ea5018 = _0x9fd6addd.GetStatic<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[15] { 103, 113, 118, 118, 97, 106, 112, 69, 103, 112, 109, 114, 109, 112, 125 }, 4)))
            using (var _0xc39ffe72 = _0x32ea5018.Call<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[17] { 179, 177, 160, 132, 181, 183, 191, 181, 179, 177, 153, 181, 186, 181, 179, 177, 166 }, 212)))
            using (var _0x007cc879 = _0xc39ffe72.Call<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[25] { 79, 77, 92, 100, 73, 93, 70, 75, 64, 97, 70, 92, 77, 70, 92, 110, 71, 90, 120, 73, 75, 67, 73, 79, 77 }, 40), _0x9ab08131))
            {
                if (_0x007cc879 == null)
                    return false;
                WLog(_0x0a5e32f2._0x73015297(new byte[37] { 93, 118, 108, 113, 115, 123, 82, 119, 117, 123, 62, 114, 127, 107, 112, 125, 118, 62, 119, 112, 109, 106, 127, 114, 114, 123, 122, 62, 110, 127, 125, 117, 127, 121, 123, 36, 62 }, 30) + _0x9ab08131);
                _0x007cc879.Call<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[8] { 226, 231, 231, 197, 239, 226, 228, 240 }, 131), 0x10000000);
                _0x32ea5018.Call(_0x0a5e32f2._0x73015297(new byte[13] { 75, 76, 89, 74, 76, 121, 91, 76, 81, 78, 81, 76, 65 }, 56), _0x007cc879);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private string _0x4758fdb3 = "";
    private Canvas _0xe5866300()
    {
        if (_0x65a9a271 != null)
            return _0x65a9a271;
        var _0x225a5f9e = gameObject.GetComponentInChildren<Canvas>();
        if (_0x225a5f9e == null)
        {
            var _0x243a27b9 = new GameObject(_0x0a5e32f2._0x73015297(new byte[6] { 32, 2, 13, 21, 2, 16 }, 99), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x225a5f9e = _0x243a27b9.GetComponent<Canvas>();
            _0x225a5f9e.transform.SetParent(transform, false);
            _0x225a5f9e.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x65a9a271 = _0x225a5f9e;
        return _0x65a9a271;
    }

    private readonly string[] _0xe663172c = new string[]
    {
        _0x0a5e32f2._0x73015297(new byte[60] { 123, 20, 5, 59, 171, 223, 227, 238, 171, 249, 238, 238, 231, 248, 171, 234, 249, 238, 171, 227, 228, 255, 171, 249, 226, 236, 227, 255, 171, 229, 228, 252, 171, 105, 11, 24, 171, 239, 228, 229, 105, 11, 18, 255, 171, 230, 226, 248, 248, 171, 242, 228, 254, 249, 171, 248, 251, 226, 229, 170 }, 139),
        _0x0a5e32f2._0x73015297(new byte[52] { 158, 241, 227, 238, 78, 39, 26, 78, 13, 1, 27, 2, 10, 78, 12, 11, 78, 23, 1, 27, 28, 78, 2, 27, 13, 5, 23, 78, 3, 1, 3, 11, 0, 26, 78, 140, 238, 253, 78, 25, 6, 23, 78, 29, 26, 1, 30, 78, 0, 1, 25, 81 }, 110),
        _0x0a5e32f2._0x73015297(new byte[66] { 237, 149, 174, 224, 183, 128, 47, 77, 102, 104, 47, 120, 102, 97, 124, 47, 110, 125, 106, 47, 103, 102, 123, 123, 102, 97, 104, 47, 98, 96, 125, 106, 47, 96, 105, 123, 106, 97, 47, 123, 96, 107, 110, 118, 47, 237, 143, 156, 47, 124, 123, 110, 118, 47, 102, 97, 47, 123, 103, 106, 47, 104, 110, 98, 106, 33 }, 15),
        _0x0a5e32f2._0x73015297(new byte[54] { 174, 193, 203, 204, 126, 10, 54, 55, 45, 126, 55, 45, 126, 46, 44, 55, 51, 59, 126, 42, 55, 51, 59, 126, 188, 222, 205, 126, 42, 54, 59, 126, 60, 59, 45, 42, 126, 46, 50, 63, 39, 59, 44, 45, 126, 46, 50, 63, 39, 126, 48, 49, 41, 112 }, 94),
        _0x0a5e32f2._0x73015297(new byte[48] { 24, 119, 124, 77, 200, 177, 135, 157, 154, 200, 159, 129, 134, 134, 129, 134, 143, 200, 155, 156, 154, 141, 137, 131, 200, 139, 135, 157, 132, 140, 200, 138, 141, 200, 135, 134, 141, 200, 155, 152, 129, 134, 200, 137, 159, 137, 145, 198 }, 232),
        _0x0a5e32f2._0x73015297(new byte[65] { 72, 39, 34, 56, 152, 242, 217, 219, 211, 200, 215, 204, 203, 152, 217, 202, 221, 152, 213, 215, 202, 221, 152, 217, 219, 204, 209, 206, 221, 152, 204, 215, 214, 209, 223, 208, 204, 152, 90, 56, 43, 152, 203, 204, 217, 193, 152, 217, 214, 220, 152, 204, 202, 193, 152, 193, 215, 205, 202, 152, 212, 205, 219, 211, 150 }, 184),
        _0x0a5e32f2._0x73015297(new byte[55] { 230, 137, 152, 164, 54, 83, 96, 115, 100, 111, 54, 101, 102, 127, 120, 54, 117, 121, 99, 120, 98, 101, 54, 244, 150, 133, 54, 98, 126, 115, 54, 120, 115, 110, 98, 54, 121, 120, 115, 54, 117, 121, 99, 122, 114, 54, 116, 115, 54, 111, 121, 99, 100, 101, 56 }, 22),
        _0x0a5e32f2._0x73015297(new byte[63] { 136, 199, 250, 133, 210, 229, 74, 58, 6, 11, 19, 15, 24, 25, 74, 24, 3, 13, 2, 30, 74, 4, 5, 29, 74, 11, 24, 15, 74, 29, 3, 4, 4, 3, 4, 13, 74, 136, 234, 249, 74, 14, 5, 4, 136, 234, 243, 30, 74, 29, 11, 6, 1, 74, 11, 29, 11, 19, 74, 19, 15, 30, 68 }, 106),
        _0x0a5e32f2._0x73015297(new byte[51] { 24, 119, 103, 110, 200, 167, 134, 132, 145, 200, 156, 128, 135, 155, 141, 200, 159, 128, 135, 200, 155, 156, 137, 145, 200, 129, 134, 200, 156, 128, 141, 200, 143, 137, 133, 141, 200, 159, 129, 134, 200, 156, 128, 141, 200, 152, 154, 129, 146, 141, 198 }, 232),
        _0x0a5e32f2._0x73015297(new byte[64] { 36, 92, 103, 41, 126, 73, 230, 139, 169, 171, 163, 168, 178, 179, 171, 230, 175, 181, 230, 163, 176, 163, 180, 191, 178, 174, 175, 168, 161, 230, 36, 70, 85, 230, 173, 163, 163, 182, 230, 181, 182, 175, 168, 168, 175, 168, 161, 230, 160, 169, 180, 230, 191, 169, 179, 180, 230, 165, 174, 167, 168, 165, 163, 232 }, 198)
    };
    internal bool ContainsIgnoreCase(string _0xef1cf1f5, string _0x0b2c8cab)
    {
        if (string.IsNullOrEmpty(_0xef1cf1f5) || string.IsNullOrEmpty(_0x0b2c8cab))
            return false;
        return _0xef1cf1f5.IndexOf(_0x0b2c8cab, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    // WEB VIEW LOGIC END
    internal void _0xe6a74620()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x4ac1ac43 = new AndroidNotificationChannel
        {
            Id = _0x0a5e32f2._0x73015297(new byte[15] { 170, 171, 168, 175, 187, 162, 186, 145, 173, 166, 175, 160, 160, 171, 162 }, 206),
            Name = _0x0a5e32f2._0x73015297(new byte[15] { 103, 70, 69, 66, 86, 79, 87, 3, 96, 75, 66, 77, 77, 70, 79 }, 35),
            Importance = Importance.High,
            Description = _0x0a5e32f2._0x73015297(new byte[21] { 89, 123, 112, 123, 108, 127, 114, 62, 112, 113, 106, 119, 120, 119, 125, 127, 106, 119, 113, 112, 109 }, 30)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x4ac1ac43);
        // Build notification
        var _0x3b06d54a = new AndroidNotification
        {
            Title = _0xe663172c[UnityEngine.Random.Range(0, _0xe663172c.Length)],
            Text = _0x0a5e32f2._0x73015297(new byte[21] { 229, 214, 193, 132, 221, 203, 209, 132, 215, 209, 214, 193, 132, 208, 203, 132, 193, 220, 205, 208, 155 }, 164),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x3b06d54a, _0x0a5e32f2._0x73015297(new byte[15] { 53, 52, 55, 48, 36, 61, 37, 14, 50, 57, 48, 63, 63, 52, 61 }, 81));
    }

    private bool _0xfeea819b = false;
    private IEnumerator _0x6eae04f5(IEnumerator _0x0ddaec0e, TaskCompletionSource<bool> _0x3815ab25)
    {
        yield return _0x0ddaec0e;
        _0x3815ab25.SetResult(true);
    }

    internal void Update()
    {
        if (_0xe20b4fdc == null)
            return;
        if (_0x7503ed5b())
            _0xa8ebc0ec();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0x52a16140();
        if (_0x7477fb8b && _0xbdf18914 != null)
            _0xbdf18914.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private void _0x69bc0560(string _0xe1ba83b6)
    {
        if (string.IsNullOrEmpty(_0xe1ba83b6))
            return;
        if (TryOpenExternalLikeChrome(_0xe1ba83b6))
            return;
        OpenUrlExternally(_0xe1ba83b6);
    }

    private bool _0xed00c050 = false;
    private string _0x3e4114e1 = "";
    private string _0x4936e200()
    {
        if (string.IsNullOrEmpty(_0x5b03a129) && _0xe20b4fdc != null)
            _0x5b03a129 = _0xe20b4fdc.GetUserAgent();
        if (string.IsNullOrEmpty(_0x5b03a129))
            return string.Empty;
        string _0xfda9939f = Regex.Replace(_0x5b03a129, _0x0a5e32f2._0x73015297(new byte[11] { 132, 171, 242, 227, 132, 171, 242, 175, 174, 132, 186 }, 216), string.Empty);
        _0xfda9939f = Regex.Replace(_0xfda9939f, _0x0a5e32f2._0x73015297(new byte[15] { 79, 96, 56, 81, 102, 122, 127, 119, 60, 72, 77, 40, 58, 78, 56 }, 19), string.Empty);
        _0xfda9939f = Regex.Replace(_0xfda9939f, _0x0a5e32f2._0x73015297(new byte[15] { 42, 25, 14, 15, 21, 19, 18, 83, 72, 32, 82, 76, 32, 15, 86 }, 124), string.Empty);
        return Regex.Replace(_0xfda9939f, _0x0a5e32f2._0x73015297(new byte[6] { 146, 189, 181, 252, 226, 179 }, 206), _0x0a5e32f2._0x73015297(new byte[1] { 91 }, 123)).Trim();
    }

    private void _0x3281dea1()
    {
        if (_0xe20b4fdc == null)
            return;
        if (_0x2179de34)
            _0xe20b4fdc.SetUserAgent(_0x4936e200());
        else
            _0xe20b4fdc.SetUserAgent("");
    }

    internal bool IsAboutBlank(string _0x71eda4e8)
    {
        if (string.IsNullOrEmpty(_0x71eda4e8))
            return false;
        return _0x71eda4e8.StartsWith(_0x0a5e32f2._0x73015297(new byte[11] { 190, 189, 176, 170, 171, 229, 189, 179, 190, 177, 180 }, 223), StringComparison.OrdinalIgnoreCase);
    }

    private Action _0xa5efe5f6;
    private Canvas _0x65a9a271;
    private Text _0xe4939d08;
    private async Task<bool> _0xf95e84ff()
    {
        {
#if B_LOGS
            Debug.Log(_0x0a5e32f2._0x73015297(new byte[29] { 117, 122, 75, 93, 90, 115, 14, 103, 93, 126, 92, 71, 88, 79, 77, 87, 111, 64, 74, 125, 79, 88, 75, 74, 109, 70, 75, 77, 69 }, 46));
#endif
        }

        string _0xfc557911 = "";
        for (int _0x1cf9a3c2 = 0; _0x1cf9a3c2 < 2; _0x1cf9a3c2++)
        {
            if (await _0xbd1fe990(1, 100))
            {
                await _0x4d7634fe(_0x0a5e32f2._0x73015297(new byte[7] { 173, 163, 160, 172, 164, 170, 171 }, 207));
                _0xa361e3ad();
                return true;
            }

            _0xfc557911 = await _0xb07fc09d(1, 100);
            if (!string.IsNullOrEmpty(_0xfc557911))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0xfc557911))
            {
                if (!string.IsNullOrEmpty(_0x6892126a))
                {
                    _0xfc557911 = _0xcb26ab7e(_0xfc557911, _0x6892126a);
                    {
#if B_LOGS
                        Debug.Log(_0x0a5e32f2._0x73015297(new byte[53] { 179, 188, 141, 155, 156, 181, 200, 171, 137, 139, 128, 141, 140, 200, 142, 129, 134, 137, 132, 189, 154, 132, 200, 159, 129, 156, 128, 200, 155, 141, 134, 140, 129, 140, 200, 10, 110, 122, 200, 155, 128, 135, 159, 200, 191, 141, 138, 190, 129, 141, 159, 210, 200 }, 232) + _0xfc557911);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x0a5e32f2._0x73015297(new byte[39] { 81, 94, 111, 121, 126, 87, 42, 73, 107, 105, 98, 111, 110, 42, 108, 99, 100, 107, 102, 95, 120, 102, 42, 232, 140, 152, 42, 121, 98, 101, 125, 42, 93, 111, 104, 92, 99, 111, 125 }, 10));
#endif
                    }
                }

                _0x4890fb3d = true;
                _0xc8802f93(_0xfc557911);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x0a5e32f2._0x73015297(new byte[44] { 4, 11, 58, 44, 43, 2, 127, 26, 39, 60, 58, 47, 43, 54, 48, 49, 127, 40, 55, 54, 51, 58, 127, 60, 55, 58, 60, 52, 54, 49, 56, 127, 44, 62, 41, 58, 59, 127, 51, 54, 49, 52, 101, 127 }, 95) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    // WS_SOURCE MONO
    public static _0xa6dd49b8 _0xde64ea98 { get; private set; }

    private Task _0xad7cc80e(IEnumerator _0x730f6a1d)
    {
        var _0x9b3fe572 = new TaskCompletionSource<bool>();
        StartCoroutine(_0x6eae04f5(_0x730f6a1d, _0x9b3fe572));
        return _0x9b3fe572.Task;
    }

    private string _0x6a49f12d = "";
    private IEnumerator _0x4f203aca(string _0xf13d1286)
    {
        if (Permission.HasUserAuthorizedPermission(_0xf13d1286))
            yield break;
        bool _0xed7c4d1f = false;
        var _0x4057a757 = new PermissionCallbacks();
        _0x4057a757.PermissionGranted += _0x1cb78366 => _0xed7c4d1f = true;
        _0x4057a757.PermissionDenied += _0x1cb78366 => _0xed7c4d1f = true;
        Permission.RequestUserPermission(_0xf13d1286, _0x4057a757);
        yield return new WaitUntil(() => _0xed7c4d1f);
    }

    private void _0xd0886385()
    {
        {
#if B_LOGS
            Debug.Log(_0x0a5e32f2._0x73015297(new byte[22] { 67, 76, 125, 107, 108, 69, 56, 75, 108, 119, 106, 125, 92, 125, 110, 113, 123, 125, 81, 118, 126, 119 }, 24));
#endif
        }

        _0x93e85806 = SystemInfo.deviceModel;
        _0x3e4114e1 = Application.version;
        _0x8d3b75f4 = Application.installMode;
        _0x14eb206f = Application.installerName;
        _0x9774d32a = Application.identifier;
        _0x0d973d13 = _0xa8adeaa5();
        _0x5b03a129 = _0xe4308edb();
        _0x2adf6d23 = SystemInfo.deviceUniqueIdentifier;
        _0x266691a6 = SystemInfo.graphicsDeviceName;
        _0x75ac7904 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x3e4114e1 = _0x0a5e32f2._0x73015297(new byte[5] { 85, 76, 85, 76, 85 }, 98);
                _0x8d3b75f4 = ApplicationInstallMode.Store;
                _0x14eb206f = _0x0a5e32f2._0x73015297(new byte[19] { 78, 66, 64, 3, 76, 67, 73, 95, 66, 68, 73, 3, 91, 72, 67, 73, 68, 67, 74 }, 45);
                _0x5b03a129 = _0x0a5e32f2._0x73015297(new byte[8] { 233, 225, 252, 248, 245, 172, 249, 237 }, 140);
                _0x2adf6d23 = Guid.NewGuid().ToString().Replace(_0x0a5e32f2._0x73015297(new byte[1] { 13 }, 32), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x0a5e32f2._0x73015297(new byte[17] { 66, 77, 124, 106, 109, 68, 57, 125, 124, 111, 84, 118, 125, 124, 117, 35, 57 }, 25) + _0x93e85806);
            Debug.Log(_0x0a5e32f2._0x73015297(new byte[19] { 10, 5, 52, 34, 37, 12, 113, 48, 33, 33, 7, 52, 35, 34, 56, 62, 63, 107, 113 }, 81) + _0x3e4114e1);
            Debug.Log(_0x0a5e32f2._0x73015297(new byte[20] { 169, 166, 151, 129, 134, 175, 210, 155, 156, 129, 134, 147, 158, 158, 191, 157, 150, 151, 200, 210 }, 242) + _0x8d3b75f4);
            Debug.Log(_0x0a5e32f2._0x73015297(new byte[23] { 166, 169, 152, 142, 137, 160, 221, 148, 147, 142, 137, 156, 145, 145, 152, 143, 174, 137, 146, 143, 152, 199, 221 }, 253) + _0x14eb206f);
            Debug.Log(_0x0a5e32f2._0x73015297(new byte[14] { 57, 54, 7, 17, 22, 63, 66, 3, 18, 18, 43, 6, 88, 66 }, 98) + _0x9774d32a);
            Debug.Log(_0x0a5e32f2._0x73015297(new byte[14] { 217, 214, 231, 241, 246, 223, 162, 227, 230, 244, 203, 230, 184, 162 }, 130) + _0x0d973d13);
            Debug.Log(_0x0a5e32f2._0x73015297(new byte[18] { 93, 82, 99, 117, 114, 91, 38, 115, 117, 99, 116, 71, 97, 99, 104, 114, 60, 38 }, 6) + _0x5b03a129);
            Debug.Log(_0x0a5e32f2._0x73015297(new byte[17] { 201, 198, 247, 225, 230, 207, 178, 225, 235, 225, 214, 247, 228, 219, 246, 168, 178 }, 146) + _0x2adf6d23);
            Debug.Log(_0x0a5e32f2._0x73015297(new byte[12] { 167, 168, 153, 143, 136, 161, 220, 155, 140, 137, 198, 220 }, 252) + _0x266691a6);
            Debug.Log(_0x0a5e32f2._0x73015297(new byte[12] { 55, 56, 9, 31, 24, 49, 76, 15, 28, 25, 86, 76 }, 108) + _0x75ac7904);
#endif
        }
    }

    private void _0x132c221c(UniWebView _0xbd3ba93a)
    {
        if (_0xfeea819b)
            return;
        _0xfeea819b = true;
        _0xbd3ba93a.AddUrlScheme(_0x0a5e32f2._0x73015297(new byte[2] { 224, 243 }, 148));
        _0xbd3ba93a.AddUrlScheme(_0x0a5e32f2._0x73015297(new byte[6] { 134, 129, 155, 138, 129, 155 }, 239));
        _0xbd3ba93a.AddUrlScheme(_0x0a5e32f2._0x73015297(new byte[6] { 161, 173, 190, 167, 169, 184 }, 204));
        _0xbd3ba93a.OnMessageReceived += (_0x2699fd4e, _0x57b5192a) =>
        {
            if (TryOpenExternalLikeChrome(_0x57b5192a.RawMessage))
            {
                _0x8a404ff0(false);
                return;
            }
        };
        _0xbd3ba93a.RegisterShouldHandleRequest(_0xe10c4349 =>
        {
            string _0x0ca56ea3 = _0xe10c4349 != null ? _0xe10c4349.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x0ca56ea3))
                return true;
            WLog(_0x0a5e32f2._0x73015297(new byte[21] { 156, 167, 160, 186, 163, 171, 135, 174, 161, 171, 163, 170, 157, 170, 190, 186, 170, 188, 187, 245, 239 }, 207) + _0x0ca56ea3);
            if (TryOpenExternalLikeChrome(_0x0ca56ea3))
            {
                _0x8a404ff0(false);
                return false;
            }

            if (_0xe10c4349 != null && _0xe10c4349.IsMainFrame && IsGoogleAuthFlowUrl(_0x0ca56ea3) && !_0x2179de34)
            {
                WLog(_0x0a5e32f2._0x73015297(new byte[62] { 238, 194, 202, 205, 131, 244, 198, 193, 245, 202, 198, 212, 131, 199, 198, 215, 198, 192, 215, 198, 199, 131, 228, 204, 204, 196, 207, 198, 131, 194, 214, 215, 203, 131, 246, 241, 239, 131, 142, 157, 131, 209, 198, 207, 204, 194, 199, 131, 212, 202, 215, 203, 131, 228, 204, 204, 196, 207, 198, 131, 246, 226 }, 163));
                _0x2179de34 = true;
                _0x8a404ff0(true);
                _0xe20b4fdc.SetUserAgent(_0x4936e200());
                _0xe20b4fdc.Load(_0x0ca56ea3);
                return false;
            }

            return true;
        });
        _0xbd3ba93a.OnLoadingErrorReceived += (_0x2699fd4e, _0x0897339c, _0x57b5192a, _0x9f05155b) =>
        {
            WLog(_0x0a5e32f2._0x73015297(new byte[25] { 111, 67, 75, 76, 2, 117, 71, 64, 116, 75, 71, 85, 2, 103, 80, 80, 77, 80, 24, 2, 65, 77, 70, 71, 31 }, 34) + _0x0897339c + _0x0a5e32f2._0x73015297(new byte[9] { 146, 223, 215, 193, 193, 211, 213, 215, 143 }, 178) + _0x57b5192a);
            string _0x52723009 = GetFailingUrl(_0x9f05155b);
            if (string.IsNullOrEmpty(_0x52723009) || IsAboutBlank(_0x52723009))
                return;
            _ = _0x4d7634fe(_0x0a5e32f2._0x73015297(new byte[8] { 197, 196, 237, 215, 192, 192, 221, 192 }, 178));
            WLog(_0x0a5e32f2._0x73015297(new byte[45] { 183, 155, 147, 148, 218, 173, 159, 152, 172, 147, 159, 141, 218, 156, 155, 147, 150, 147, 148, 157, 218, 175, 168, 182, 218, 215, 196, 218, 149, 138, 159, 148, 218, 159, 130, 142, 159, 136, 148, 155, 150, 150, 131, 192, 218 }, 250) + _0x52723009);
            StopCurrentFailedLoad(_0x2699fd4e);
            _0x69bc0560(_0x52723009);
        };
        _0xbd3ba93a.OnPageStarted += (_0x2699fd4e, _0xca3ed802) =>
        {
            _0x5d9f846b = 0;
            if (_0x402938de && IsAboutBlank(_0xca3ed802))
            {
                WLog(_0x0a5e32f2._0x73015297(new byte[27] { 70, 100, 115, 97, 119, 100, 123, 54, 119, 116, 121, 99, 98, 44, 116, 122, 119, 120, 125, 54, 101, 98, 119, 100, 98, 115, 114 }, 22));
                return;
            }

            WLog(_0x0a5e32f2._0x73015297(new byte[29] { 237, 193, 201, 206, 128, 247, 197, 194, 246, 201, 197, 215, 128, 239, 206, 240, 193, 199, 197, 243, 212, 193, 210, 212, 197, 196, 154, 128, 139 }, 160) + (Time.realtimeSinceStartup - _0xefe8f776).ToString(_0x0a5e32f2._0x73015297(new byte[5] { 131, 157, 131, 131, 131 }, 179)) + _0x0a5e32f2._0x73015297(new byte[2] { 200, 155 }, 187) + _0xca3ed802);
            if (TryOpenExternalLikeChrome(_0xca3ed802))
            {
                StopCurrentFailedLoad(_0x2699fd4e);
                return;
            }

            if (ContainsIgnoreCase(_0xca3ed802, _0x0a5e32f2._0x73015297(new byte[8] { 231, 234, 234, 226, 173, 226, 243, 243 }, 131)) || ContainsIgnoreCase(_0xca3ed802, _0x0a5e32f2._0x73015297(new byte[15] { 45, 60, 36, 115, 42, 52, 57, 58, 56, 41, 115, 63, 49, 50, 58 }, 93)) || _0xca3ed802.StartsWith(_0x0a5e32f2._0x73015297(new byte[25] { 245, 233, 233, 237, 238, 167, 178, 178, 255, 237, 250, 241, 242, 255, 252, 241, 251, 252, 235, 179, 241, 244, 235, 248, 178 }, 157), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x2699fd4e);
                OpenUrlExternally(_0xca3ed802);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0xca3ed802))
            {
                _0x8a404ff0(true);
                WLog(_0x0a5e32f2._0x73015297(new byte[41] { 98, 74, 74, 66, 73, 64, 5, 68, 80, 81, 77, 5, 67, 73, 74, 82, 5, 65, 64, 81, 64, 70, 81, 64, 65, 5, 8, 27, 5, 78, 64, 64, 85, 5, 83, 76, 86, 76, 71, 73, 64 }, 37));
                return;
            }

            _0x2afec387 = true;
            _0x8a404ff0(true);
            WLog(_0x0a5e32f2._0x73015297(new byte[43] { 3, 49, 54, 2, 61, 49, 35, 116, 56, 59, 53, 48, 61, 58, 51, 123, 38, 49, 48, 61, 38, 49, 55, 32, 61, 58, 51, 116, 121, 106, 116, 63, 49, 49, 36, 116, 34, 61, 39, 61, 54, 56, 49 }, 84));
        };
        _0xbd3ba93a.OnPageCommitted += (_0x2699fd4e, _0xca3ed802) =>
        {
            if (_0x402938de && IsAboutBlank(_0xca3ed802))
                return;
            WLog(_0x0a5e32f2._0x73015297(new byte[31] { 199, 235, 227, 228, 170, 221, 239, 232, 220, 227, 239, 253, 170, 197, 228, 218, 235, 237, 239, 201, 229, 231, 231, 227, 254, 254, 239, 238, 176, 170, 161 }, 138) + (Time.realtimeSinceStartup - _0xefe8f776).ToString(_0x0a5e32f2._0x73015297(new byte[5] { 144, 142, 144, 144, 144 }, 160)) + _0x0a5e32f2._0x73015297(new byte[2] { 193, 146 }, 178) + _0xca3ed802);
            if (!firstLoadShown && IsHttpUrl(_0xca3ed802))
            {
                firstLoadShown = true;
                _0x2afec387 = false;
                _0x8a404ff0(false);
                _0xed0113fe();
                _0x52a16140();
                _0x2699fd4e.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x4d7634fe(_0x0a5e32f2._0x73015297(new byte[9] { 74, 75, 98, 82, 77, 88, 83, 88, 89 }, 61));
                WLog(_0x0a5e32f2._0x73015297(new byte[39] { 16, 60, 52, 51, 125, 10, 56, 63, 11, 52, 56, 42, 125, 46, 53, 50, 42, 51, 125, 50, 51, 125, 62, 50, 48, 48, 52, 41, 41, 56, 57, 125, 62, 50, 51, 41, 56, 51, 41 }, 93));
            }
        };
        _0xbd3ba93a.OnPageProgressChanged += (_0x2699fd4e, _0x61d29513) =>
        {
            if (_0x402938de)
                return;
            if (!firstLoadShown && _0x61d29513 >= 0.65f)
            {
                firstLoadShown = true;
                _0x2afec387 = false;
                _0x8a404ff0(false);
                _0xed0113fe();
                _0x52a16140();
                _0x2699fd4e.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x4d7634fe(_0x0a5e32f2._0x73015297(new byte[9] { 209, 208, 249, 201, 214, 195, 200, 195, 194 }, 166));
                WLog(_0x0a5e32f2._0x73015297(new byte[32] { 251, 215, 223, 216, 150, 225, 211, 212, 224, 223, 211, 193, 150, 197, 222, 217, 193, 216, 150, 212, 207, 150, 198, 196, 217, 209, 196, 211, 197, 197, 140, 150 }, 182) + _0x61d29513);
            }
        };
        _0xbd3ba93a.OnPageFinished += (_0x2699fd4e, _0x0897339c, _0xca3ed802) =>
        {
            if (_0x402938de && IsAboutBlank(_0xca3ed802))
            {
                _0x402938de = false;
                WLog(_0x0a5e32f2._0x73015297(new byte[28] { 129, 163, 180, 166, 176, 163, 188, 241, 176, 179, 190, 164, 165, 235, 179, 189, 176, 191, 186, 241, 183, 184, 191, 184, 162, 185, 180, 181 }, 209));
                return;
            }

            WLog(_0x0a5e32f2._0x73015297(new byte[24] { 103, 75, 67, 68, 10, 125, 79, 72, 124, 67, 79, 93, 10, 108, 67, 68, 67, 89, 66, 79, 78, 16, 10, 1 }, 42) + (Time.realtimeSinceStartup - _0xefe8f776).ToString(_0x0a5e32f2._0x73015297(new byte[5] { 149, 139, 149, 149, 149 }, 165)) + _0x0a5e32f2._0x73015297(new byte[7] { 158, 205, 142, 130, 137, 136, 208 }, 237) + _0x0897339c + _0x0a5e32f2._0x73015297(new byte[5] { 119, 34, 37, 59, 106 }, 87) + _0xca3ed802);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x2afec387 = false;
                _0x8a404ff0(false);
                _0xed0113fe();
                _0x52a16140();
                _0x2699fd4e.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x4d7634fe(_0x0a5e32f2._0x73015297(new byte[9] { 122, 123, 82, 98, 125, 104, 99, 104, 105 }, 13));
                WLog(_0x0a5e32f2._0x73015297(new byte[33] { 164, 136, 128, 135, 201, 190, 140, 139, 191, 128, 140, 158, 201, 143, 128, 155, 154, 157, 201, 133, 134, 136, 141, 201, 138, 134, 132, 153, 133, 140, 157, 140, 141 }, 233));
            }
            else if (_0x2afec387)
            {
                _0x2afec387 = false;
                _0x8a404ff0(false);
                _0x2699fd4e.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x0a5e32f2._0x73015297(new byte[40] { 157, 177, 185, 190, 240, 135, 181, 178, 134, 185, 181, 167, 240, 131, 184, 191, 167, 240, 177, 182, 164, 181, 162, 240, 188, 191, 177, 180, 185, 190, 183, 240, 182, 185, 190, 185, 163, 184, 181, 180 }, 208));
            }
            else
            {
                _0x8a404ff0(false);
            }

            if (_0x2179de34 && !IsGoogleAuthFlowUrl(_0xca3ed802) && !IsGoogleAuthFlowUrl(_0xca3ed802))
            {
                WLog(_0x0a5e32f2._0x73015297(new byte[48] { 87, 127, 127, 119, 124, 117, 48, 113, 101, 100, 120, 48, 99, 117, 117, 125, 99, 48, 118, 121, 126, 121, 99, 120, 117, 116, 48, 61, 46, 48, 98, 117, 99, 100, 127, 98, 117, 48, 116, 117, 118, 113, 101, 124, 100, 48, 69, 81 }, 16));
                _0x2179de34 = false;
                _0xe20b4fdc.SetUserAgent("");
            }
        };
        _0xbd3ba93a.OnShouldClose += _0x2699fd4e =>
        {
            WLog(_0x0a5e32f2._0x73015297(new byte[41] { 16, 31, 46, 56, 63, 22, 107, 6, 42, 34, 37, 107, 28, 46, 41, 29, 34, 46, 60, 107, 4, 37, 24, 35, 36, 62, 39, 47, 8, 39, 36, 56, 46, 107, 34, 37, 61, 36, 32, 46, 47 }, 75));
            _0xa8ebc0ec();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0xbd3ba93a.SetPopupPageEventEnabled(true);
        bool _0x1eefc824 = false;
        bool _0x089e01aa = false;
        _0xbd3ba93a.OnMultipleWindowOpened += (_0x2699fd4e, _0x1a43a68a) =>
        {
            _0x2699fd4e.ScrollTo(0, 0, false);
            WLog(_0x0a5e32f2._0x73015297(new byte[43] { 102, 105, 88, 78, 73, 96, 29, 112, 92, 84, 83, 29, 106, 88, 95, 107, 84, 88, 74, 29, 112, 72, 81, 73, 84, 77, 81, 88, 106, 84, 83, 89, 82, 74, 29, 114, 77, 88, 83, 88, 89, 7, 29 }, 61) + _0x1a43a68a);
            var _0x98890cba = _0xbd3ba93a.GetPopupWindow(_0x1a43a68a);
            if (_0x98890cba == null)
                return;
            _0xe0603d2f.Add(_0x98890cba);
            Debug.Log($"[Test] Popup ID: {_0x98890cba.Id}");
            _0x98890cba.OnPageStarted += (_0xbebfeb6e, _0xca3ed802) =>
            {
                WLog(_0x0a5e32f2._0x73015297(new byte[36] { 95, 80, 97, 119, 112, 89, 36, 84, 107, 116, 113, 116, 36, 83, 97, 102, 82, 109, 97, 115, 36, 75, 106, 84, 101, 99, 97, 87, 112, 101, 118, 112, 97, 96, 62, 36 }, 4) + _0xca3ed802);
                _0x5d9f846b = 0;
                if (string.IsNullOrEmpty(_0xca3ed802) || IsAboutBlank(_0xca3ed802))
                    return;
                if (IsGoogleAuthFlowUrl(_0xca3ed802))
                {
                    WLog(_0x0a5e32f2._0x73015297(new byte[57] { 65, 78, 127, 105, 110, 71, 58, 74, 117, 106, 111, 106, 58, 93, 117, 117, 125, 118, 127, 58, 123, 111, 110, 114, 58, 124, 118, 117, 109, 58, 55, 36, 58, 105, 106, 117, 117, 124, 58, 93, 117, 117, 125, 118, 127, 58, 89, 114, 104, 117, 119, 127, 58, 79, 91, 32, 58 }, 26) + _0xca3ed802);
                    _0x1eefc824 = false;
                    _0x49cce04b();
                    if (_0xbebfeb6e != null && _0xbebfeb6e.IsAlive)
                        _0xbebfeb6e.EvaluateJavaScript(_0x231c878f());
                    return;
                }

                if (_0xe20b4fdc == null)
                    return;
                if (!_0x1eefc824)
                {
                    _0x1eefc824 = true;
                    _0xe20b4fdc.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x0a5e32f2._0x73015297(new byte[39] { 62, 49, 0, 22, 17, 56, 69, 53, 10, 21, 16, 21, 69, 4, 21, 21, 9, 28, 69, 50, 12, 11, 1, 10, 18, 22, 69, 1, 0, 22, 14, 17, 10, 21, 69, 48, 36, 95, 69 }, 101) + _0xca3ed802);
                }

                if (_0xbebfeb6e != null && _0xbebfeb6e.IsAlive)
                    _0xbebfeb6e.EvaluateJavaScript(_0x3982423f());
                if (!_0x089e01aa && _0xbebfeb6e != null && _0xbebfeb6e.IsAlive && IsHttpUrl(_0xca3ed802))
                {
                    _0x089e01aa = true;
                }
            };
            _0x98890cba.OnPageFinished += (_0xbebfeb6e, _0x9f05155b) =>
            {
                string _0x197f9cbd = _0x9f05155b != null ? _0x9f05155b.data : string.Empty;
                WLog(_0x0a5e32f2._0x73015297(new byte[35] { 102, 105, 88, 78, 73, 96, 29, 109, 82, 77, 72, 77, 29, 106, 88, 95, 107, 84, 88, 74, 29, 123, 84, 83, 84, 78, 85, 88, 89, 7, 29, 72, 79, 81, 0 }, 61) + _0x197f9cbd);
                if (_0xbebfeb6e == null || !_0xbebfeb6e.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x197f9cbd))
                {
                    _0x49cce04b();
                    _0xbebfeb6e.EvaluateJavaScript(_0x231c878f());
                    return;
                }

                if (!_0x1eefc824)
                    return;
                _0xbebfeb6e.EvaluateJavaScript(_0x3982423f());
            };
        };
        _0xbd3ba93a.OnMultipleWindowClosed += (_0x2699fd4e, _0x1a43a68a) =>
        {
            _0xe0603d2f.RemoveAll(_0xf1c2c72e => _0xf1c2c72e == null || _0xf1c2c72e.Id == _0x1a43a68a || !_0xf1c2c72e.IsAlive);
            _0x8a404ff0(false);
            if (_0xe0603d2f.Count == 0 && _0xe20b4fdc != null)
            {
                _0x1eefc824 = false;
                _0x089e01aa = false;
                _0x3281dea1();
            }

            WLog(_0x0a5e32f2._0x73015297(new byte[43] { 62, 49, 0, 22, 17, 56, 69, 40, 4, 12, 11, 69, 50, 0, 7, 51, 12, 0, 18, 69, 40, 16, 9, 17, 12, 21, 9, 0, 50, 12, 11, 1, 10, 18, 69, 38, 9, 10, 22, 0, 1, 95, 69 }, 101) + _0x1a43a68a);
        };
        _0xbd3ba93a.RegisterOnRequestMediaCapturePermission(_0xe10c4349 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private void _0x8a404ff0(bool _0x30eabd77)
    {
        _0x5cd115bb();
        _0x4f54dc18.SetActive(_0x30eabd77);
        _0x7477fb8b = _0x30eabd77;
        if (_0x30eabd77)
        {
            _0x4f54dc18.transform.SetAsLastSibling();
            if (_0xbdf18914 != null)
                _0xbdf18914.localRotation = Quaternion.identity;
        }
    }

    public void _0xa361e3ad()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x0a5e32f2._0x73015297(new byte[18] { 244, 251, 202, 220, 219, 242, 143, 227, 206, 218, 193, 204, 199, 143, 232, 206, 194, 202 }, 175));
#endif
        }

        _0x9765d4e7.Instance?._0x7ae7943e();
        _0x09bc71db.Instance._0x1bf59810(_0xb39a7050._0x58729df1.DEFAULT);
    }

    private string _0x54f39c71 = "";
    private string GetFailingUrl(UniWebViewNativeResultPayload _0x1db9a735)
    {
        if (_0x1db9a735 == null || _0x1db9a735.Extra == null)
            return null;
        object _0xdcfda3ee;
        if (!_0x1db9a735.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0xdcfda3ee))
            return null;
        return _0xdcfda3ee as string;
    }

    internal bool IsHttpUrl(string _0x8c2d4aff)
    {
        if (string.IsNullOrEmpty(_0x8c2d4aff))
            return false;
        return _0x8c2d4aff.StartsWith(_0x0a5e32f2._0x73015297(new byte[7] { 89, 69, 69, 65, 11, 30, 30 }, 49), StringComparison.OrdinalIgnoreCase) || _0x8c2d4aff.StartsWith(_0x0a5e32f2._0x73015297(new byte[8] { 30, 2, 2, 6, 5, 76, 89, 89 }, 118), StringComparison.OrdinalIgnoreCase);
    }

    private bool _0x2179d5b1(string _0x27d4709e, string _0xd634db11)
    {
        string _0x5246eed6 = _0x966fd780(_0x27d4709e);
        if (string.IsNullOrEmpty(_0x5246eed6))
            _0x5246eed6 = _0xd634db11;
        if (_0x585e3ccd(_0x5246eed6))
            return true;
        string _0x16436039 = string.IsNullOrEmpty(_0x5246eed6) ? _0x0a5e32f2._0x73015297(new byte[29] { 23, 11, 11, 15, 12, 69, 80, 80, 15, 19, 30, 6, 81, 24, 16, 16, 24, 19, 26, 81, 28, 16, 18, 80, 12, 11, 16, 13, 26 }, 127) : _0x0a5e32f2._0x73015297(new byte[46] { 12, 16, 16, 20, 23, 94, 75, 75, 20, 8, 5, 29, 74, 3, 11, 11, 3, 8, 1, 74, 7, 11, 9, 75, 23, 16, 11, 22, 1, 75, 5, 20, 20, 23, 75, 0, 1, 16, 5, 13, 8, 23, 91, 13, 0, 89 }, 100) + _0x5246eed6;
        WLog(_0x0a5e32f2._0x73015297(new byte[35] { 215, 252, 230, 251, 249, 241, 216, 253, 255, 241, 180, 249, 245, 230, 255, 241, 224, 180, 242, 245, 248, 248, 246, 245, 247, 255, 180, 245, 231, 180, 227, 241, 246, 174, 180 }, 148) + _0x16436039);
        return _0xee30c790(_0x16436039);
    }

    private bool _0xace5ca2d()
    {
        var _0x62d779d8 = _0xd5be844d();
        if (_0x62d779d8 == null)
            return false;
        WLog(_0x0a5e32f2._0x73015297(new byte[31] { 56, 17, 2, 20, 7, 17, 2, 21, 80, 18, 17, 19, 27, 80, 93, 78, 80, 0, 31, 0, 5, 0, 80, 55, 31, 50, 17, 19, 27, 74, 80 }, 112) + _0x62d779d8.Id);
        _0x62d779d8.GoBack();
        return true;
    }

    private void _0x5cd115bb()
    {
        if (_0x4f54dc18 != null)
            return;
        var _0x9c8d57fa = _0xe5866300();
        _0x4f54dc18 = new GameObject(_0x0a5e32f2._0x73015297(new byte[14] { 246, 196, 195, 247, 200, 196, 214, 242, 209, 200, 207, 207, 196, 211 }, 161), typeof(RectTransform), typeof(Text));
        _0xbdf18914 = _0x4f54dc18.GetComponent<RectTransform>();
        _0xbdf18914.SetParent(_0x9c8d57fa.transform, false);
        _0xbdf18914.anchorMin = new Vector2(0.5f, 0.5f);
        _0xbdf18914.anchorMax = new Vector2(0.5f, 0.5f);
        _0xbdf18914.pivot = new Vector2(0.5f, 0.5f);
        _0xbdf18914.sizeDelta = new Vector2(600f, 600f);
        _0xbdf18914.anchoredPosition = Vector2.zero;
        _0xe4939d08 = _0x4f54dc18.GetComponent<Text>();
        _0xe4939d08.text = _0x0a5e32f2._0x73015297(new byte[1] { 236 }, 195);
        _0xe4939d08.font = Resources.GetBuiltinResource<Font>(_0x0a5e32f2._0x73015297(new byte[17] { 17, 56, 58, 60, 62, 36, 15, 40, 51, 41, 52, 48, 56, 115, 41, 41, 59 }, 93));
        _0xe4939d08.fontSize = 200;
        _0xe4939d08.alignment = TextAnchor.MiddleCenter;
        _0xe4939d08.color = Color.white;
        _0xe4939d08.raycastTarget = false;
        _0x4f54dc18.SetActive(false);
    }

    private void _0xc8802f93(string _0xd9f5ea52)
    {
        _0x33a3f44b();
        StartCoroutine(_0x094a3cc5(_0xd9f5ea52));
    }

    private RectTransform _0xbdf18914;
    private bool _0x7663215e = false;
    private string _0x40166447 = "";
    private GameObject _0x4f54dc18;
    private void OnApplicationFocus(bool _0x3b4308b6)
    {
        isApplicationFocus = _0x3b4308b6;
        if (_0x3b4308b6 && _0x9c601b3d)
        {
            _0x33a3f44b();
        }
    }

    private void _0x1b89be3e(string _0x988467a0)
    {
        bool _0x73874a73 = !string.IsNullOrEmpty(_0x988467a0);
        if (_0x73874a73)
        {
            {
#if B_LOGS
                Debug.Log(_0x0a5e32f2._0x73015297(new byte[13] { 235, 228, 213, 195, 196, 237, 144, 227, 216, 223, 199, 138, 144 }, 176) + _0x988467a0);
#endif
            }

            _0xc8802f93(_0x988467a0);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x0a5e32f2._0x73015297(new byte[39] { 82, 93, 108, 122, 125, 84, 41, 79, 104, 101, 101, 107, 104, 106, 98, 41, 235, 143, 155, 41, 78, 104, 100, 108, 41, 33, 103, 102, 41, 111, 96, 103, 104, 101, 41, 92, 91, 69, 32 }, 9));
#endif
            }

            _0xa361e3ad();
            return;
        }
    }

    private static string ReadPushField(Dictionary<string, object> _0xc5b501dd, string _0xa8a13267)
    {
        if (_0xc5b501dd == null || string.IsNullOrEmpty(_0xa8a13267))
            return string.Empty;
        if (_0xc5b501dd.TryGetValue(_0x0a5e32f2._0x73015297(new byte[16] { 51, 50, 41, 52, 59, 52, 62, 60, 41, 52, 50, 51, 25, 60, 41, 60 }, 93), out var raw))
        {
            try
            {
                var _0xe0a4ac25 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0xe0a4ac25 != null && _0xe0a4ac25.TryGetValue(_0xa8a13267, out var nestedVal))
                {
                    var _0x7ba76811 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x7ba76811))
                        return _0x7ba76811;
                }
            }
            catch
            {
            }
        }

        if (_0xc5b501dd.TryGetValue(_0xa8a13267, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    internal bool isApplicationPause = false;
    internal bool isDestroyedForce = false;
    private void _0xed0113fe()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private void _0x340a618c(UniWebView _0xbdb5cb68)
    {
        _0xbdb5cb68.BackgroundColor = Color.clear;
        _0xbdb5cb68.SetSupportMultipleWindows(true, true);
        _0xbdb5cb68.SetBackButtonEnabled(false);
        _0xe20b4fdc.SetUserAgent(_0x4936e200());
    }

    private IEnumerator _0x094a3cc5(string _0xba7e1eae)
    {
        if (_0xe20b4fdc != null && _0x9c601b3d)
            yield break;
        _0xe20b4fdc = gameObject.AddComponent<UniWebView>();
        _0x340a618c(_0xe20b4fdc);
        _0x132c221c(_0xe20b4fdc);
        _0xe20b4fdc.BackgroundColor = Color.clear;
        var _0x78f8c06f = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0x52a16140();
        yield return new WaitForEndOfFrame();
        _0x9c601b3d = true;
        _0x5cd115bb();
        _0x8a404ff0(true);
        _0x402938de = false;
        _0x2179de34 = false;
        _0xe0603d2f.Clear();
        _0x3e0430b9 = -1;
        firstLoadShown = false;
        _0x2afec387 = false;
        _0x7663215e = false;
        _0xe20b4fdc.SetUserAgent("");
        _0xefe8f776 = Time.realtimeSinceStartup;
        _0xe20b4fdc.Stop();
        _0xe20b4fdc.Load(_0xba7e1eae);
        _0xe20b4fdc.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x0a5e32f2._0x73015297(new byte[25] { 245, 217, 209, 214, 152, 239, 221, 218, 238, 209, 221, 207, 152, 241, 214, 209, 204, 209, 217, 212, 152, 235, 208, 215, 207 }, 184));
    }

    private UniWebViewPopup _0xd5be844d()
    {
        for (int _0xf2c439cc = _0xe0603d2f.Count - 1; _0xf2c439cc >= 0; _0xf2c439cc--)
        {
            var _0xe3bee0cf = _0xe0603d2f[_0xf2c439cc];
            if (_0xe3bee0cf != null && _0xe3bee0cf.IsAlive)
                return _0xe3bee0cf;
            _0xe0603d2f.RemoveAt(_0xf2c439cc);
        }

        return null;
    }

    internal Button _0x933e96b5(string _0x6212971c, Transform _0x7a30b504)
    {
        var _0x715f4d88 = new GameObject(_0x6212971c + _0x0a5e32f2._0x73015297(new byte[3] { 21, 35, 57 }, 87), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x13189beb = _0x715f4d88.GetComponent<RectTransform>();
        _0x13189beb.SetParent(_0x7a30b504, false);
        var _0x994c7605 = _0x715f4d88.GetComponent<Image>();
        _0x994c7605.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x8aea506d = _0x715f4d88.GetComponent<Button>();
        var _0xe902b5b1 = _0x8aea506d.colors;
        _0xe902b5b1.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0xe902b5b1.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x8aea506d.colors = _0xe902b5b1;
        var _0x33b0f3c5 = new GameObject(_0x0a5e32f2._0x73015297(new byte[4] { 199, 246, 235, 231 }, 147), typeof(RectTransform), typeof(Text));
        var _0x610bad6a = _0x33b0f3c5.GetComponent<RectTransform>();
        _0x610bad6a.SetParent(_0x715f4d88.transform, false);
        _0x610bad6a.anchorMin = Vector2.zero;
        _0x610bad6a.anchorMax = Vector2.one;
        _0x610bad6a.offsetMin = _0x610bad6a.offsetMax = Vector2.zero;
        var _0xa903b8ca = _0x33b0f3c5.GetComponent<Text>();
        _0xa903b8ca.text = _0x6212971c;
        _0xa903b8ca.alignment = TextAnchor.MiddleCenter;
        _0xa903b8ca.color = Color.black;
        _0xa903b8ca.font = Resources.GetBuiltinResource<Font>(_0x0a5e32f2._0x73015297(new byte[9] { 103, 84, 79, 71, 74, 8, 82, 82, 64 }, 38));
        _0xa903b8ca.fontSize = 28;
        WLog(_0x0a5e32f2._0x73015297(new byte[14] { 90, 107, 124, 120, 109, 124, 91, 108, 109, 109, 118, 119, 57, 62 }, 25) + _0x6212971c + _0x0a5e32f2._0x73015297(new byte[1] { 246 }, 209));
        return _0x8aea506d;
    }

    internal Rect lastSafe = Rect.zero;
    internal void _0x52a16140()
    {
        Rect _0xf0dbc99f = Screen.safeArea;
        Vector2 _0x8c6cfda1 = new Vector2(Screen.width, Screen.height);
        if (_0xf0dbc99f == lastSafe && _0x8c6cfda1 == lastSize)
            return;
        // Apply manual padding
        _0xf0dbc99f.xMin += _0xbf030fa3;
        _0xf0dbc99f.xMax -= _0x7c2dd2ec;
        _0xf0dbc99f.yMin += _0x45456b6c;
        _0xf0dbc99f.yMax -= _0x1f6be05e;
        // Convert Unity safe area -> native WebView frame
        Rect _0x666d1b73 = new Rect(_0xf0dbc99f.x, _0x8c6cfda1.y - _0xf0dbc99f.y - _0xf0dbc99f.height, // Y flip for native coordinate system
 _0xf0dbc99f.width, _0xf0dbc99f.height);
        _0xe20b4fdc.Frame = _0x666d1b73;
        lastSafe = Screen.safeArea;
        lastSize = _0x8c6cfda1;
    }

    private string _0x9dff8d65 { get; set; }

    private void _0x33a3f44b()
    {
        using (var _0x71a22efb = new AndroidJavaClass(_0x0a5e32f2._0x73015297(new byte[30] { 149, 153, 155, 216, 131, 152, 159, 130, 143, 197, 146, 216, 134, 154, 151, 143, 147, 132, 216, 163, 152, 159, 130, 143, 166, 154, 151, 143, 147, 132 }, 246)))
        using (var _0x4249edfb = _0x71a22efb.GetStatic<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[15] { 110, 120, 127, 127, 104, 99, 121, 76, 110, 121, 100, 123, 100, 121, 116 }, 13)))
        using (var _0x7da8d379 = _0x4249edfb.Call<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[9] { 163, 161, 176, 141, 170, 176, 161, 170, 176 }, 196)))
        {
            if (_0x7da8d379 == null)
                return;
            using (var _0xec5b8232 = _0x7da8d379.Call<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[9] { 195, 193, 208, 225, 220, 208, 214, 197, 215 }, 164)))
            {
                if (_0xec5b8232 == null)
                    return;
                using (var _0x06802292 = new AndroidJavaObject(_0x0a5e32f2._0x73015297(new byte[19] { 102, 123, 110, 39, 99, 122, 102, 103, 39, 67, 90, 70, 71, 70, 107, 99, 108, 106, 125 }, 9)))
                using (var _0x2d26147f = _0xec5b8232.Call<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[6] { 221, 211, 207, 229, 211, 194 }, 182)))
                using (var _0xe95a456d = _0x2d26147f.Call<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[8] { 139, 150, 135, 144, 131, 150, 141, 144 }, 226)))
                {
                    while (_0xe95a456d.Call<bool>(_0x0a5e32f2._0x73015297(new byte[7] { 196, 205, 223, 226, 201, 212, 216 }, 172)))
                    {
                        string _0x4aff1ecc = _0xe95a456d.Call<string>(_0x0a5e32f2._0x73015297(new byte[4] { 86, 93, 64, 76 }, 56));
                        using (var _0x8b21f92d = _0xec5b8232.Call<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[3] { 71, 69, 84 }, 32), _0x4aff1ecc))
                        {
                            _0x06802292.Call<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[3] { 233, 236, 237 }, 153), _0x4aff1ecc, _0x8b21f92d);
                        }
                    }

                    string _0xf10aaa23 = _0x06802292.Call<string>(_0x0a5e32f2._0x73015297(new byte[8] { 120, 99, 95, 120, 126, 101, 98, 107 }, 12));
                    if (!string.IsNullOrEmpty(_0xf10aaa23))
                    {
                        _0x4ec8a23d(_0xf10aaa23);
                        _0x883fb1a6(_0xf10aaa23);
                    }
                }
            }
        }
    }

    private void StopCurrentFailedLoad(UniWebView _0xdcddba66)
    {
        _0x8a404ff0(false);
        if (_0xdcddba66 == null)
            return;
        _0xdcddba66.Stop();
        if (_0xdcddba66.CanGoBack)
            _0xdcddba66.GoBack();
    }

    private void _0x71fc6390()
    {
        if (_0x7663215e)
        {
            WLog(_0x0a5e32f2._0x73015297(new byte[18] { 168, 149, 132, 153, 205, 140, 129, 159, 136, 140, 137, 148, 205, 158, 133, 130, 154, 131 }, 237));
            return;
        }

        _0x8a404ff0(false);
        WLog(_0x0a5e32f2._0x73015297(new byte[46] { 0, 44, 36, 35, 109, 26, 40, 47, 27, 36, 40, 58, 109, 29, 56, 62, 37, 109, 3, 34, 57, 36, 43, 36, 46, 44, 57, 36, 34, 35, 109, 101, 37, 44, 63, 41, 58, 44, 63, 40, 109, 47, 44, 46, 38, 100 }, 77));
        ++_0x5d9f846b;
        _0xe6a74620();
        if (_0x5d9f846b <= 1)
            return;
        if (_0xeb8d5c45())
        {
            WLog(_0x0a5e32f2._0x73015297(new byte[37] { 121, 68, 85, 72, 28, 79, 87, 85, 76, 76, 89, 88, 28, 17, 2, 28, 76, 83, 76, 73, 76, 79, 28, 79, 72, 85, 80, 80, 28, 83, 76, 89, 82, 89, 88, 6, 28 }, 60) + _0xe0603d2f.Count);
            return;
        }

        Application.Quit();
    }

    private string _0x231c878f()
    {
        string _0xed917413 = _0x4936e200();
        if (string.IsNullOrEmpty(_0xed917413))
            return _0x0a5e32f2._0x73015297(new byte[7] { 114, 107, 109, 96, 36, 52, 63 }, 4);
        string _0x3a745f2c = _0xed917413.Replace(_0x0a5e32f2._0x73015297(new byte[1] { 81 }, 13), _0x0a5e32f2._0x73015297(new byte[2] { 185, 185 }, 229)).Replace(_0x0a5e32f2._0x73015297(new byte[1] { 15 }, 40), _0x0a5e32f2._0x73015297(new byte[2] { 15, 116 }, 83));
        var _0x37786c5c = Regex.Match(_0xed917413, _0x0a5e32f2._0x73015297(new byte[12] { 125, 86, 76, 81, 83, 91, 17, 22, 98, 90, 21, 23 }, 62));
        string _0x17dc90da = _0x37786c5c.Success ? _0x37786c5c.Groups[1].Value : _0x0a5e32f2._0x73015297(new byte[3] { 136, 139, 137 }, 185);
        return _0x0a5e32f2._0x73015297(new byte[12] { 45, 99, 112, 107, 102, 113, 108, 106, 107, 45, 44, 126 }, 5) + _0x0a5e32f2._0x73015297(new byte[8] { 92, 75, 88, 10, 95, 75, 23, 13 }, 42) + _0x3a745f2c + _0x0a5e32f2._0x73015297(new byte[2] { 223, 195 }, 248) + _0x0a5e32f2._0x73015297(new byte[30] { 42, 61, 46, 124, 44, 46, 51, 40, 51, 97, 18, 61, 42, 53, 59, 61, 40, 51, 46, 114, 44, 46, 51, 40, 51, 40, 37, 44, 57, 103 }, 92) + _0x0a5e32f2._0x73015297(new byte[121] { 135, 148, 143, 130, 149, 136, 142, 143, 193, 133, 132, 135, 201, 142, 131, 139, 205, 138, 132, 152, 205, 151, 128, 141, 200, 154, 149, 147, 152, 154, 174, 131, 139, 132, 130, 149, 207, 133, 132, 135, 136, 143, 132, 177, 147, 142, 145, 132, 147, 149, 152, 201, 142, 131, 139, 205, 138, 132, 152, 205, 154, 134, 132, 149, 219, 135, 148, 143, 130, 149, 136, 142, 143, 201, 200, 154, 147, 132, 149, 148, 147, 143, 193, 151, 128, 141, 218, 156, 205, 130, 142, 143, 135, 136, 134, 148, 147, 128, 131, 141, 132, 219, 149, 147, 148, 132, 156, 200, 218, 156, 130, 128, 149, 130, 137, 201, 132, 200, 154, 156, 156 }, 225) + _0x0a5e32f2._0x73015297(new byte[26] { 16, 17, 18, 92, 4, 6, 27, 0, 27, 88, 83, 1, 7, 17, 6, 53, 19, 17, 26, 0, 83, 88, 1, 21, 93, 79 }, 116) + _0x0a5e32f2._0x73015297(new byte[52] { 51, 50, 49, 127, 39, 37, 56, 35, 56, 123, 112, 54, 39, 39, 1, 50, 37, 36, 62, 56, 57, 112, 123, 34, 54, 121, 37, 50, 39, 59, 54, 52, 50, 127, 120, 9, 26, 56, 45, 62, 59, 59, 54, 11, 120, 120, 123, 112, 112, 126, 126, 108 }, 87) + _0x0a5e32f2._0x73015297(new byte[37] { 151, 150, 149, 219, 131, 129, 156, 135, 156, 223, 212, 131, 159, 146, 135, 149, 156, 129, 158, 212, 223, 212, 191, 154, 157, 134, 139, 211, 146, 129, 158, 133, 203, 159, 212, 218, 200 }, 243) + _0x0a5e32f2._0x73015297(new byte[34] { 205, 204, 207, 129, 217, 219, 198, 221, 198, 133, 142, 223, 204, 199, 205, 198, 219, 142, 133, 142, 238, 198, 198, 206, 197, 204, 137, 224, 199, 202, 135, 142, 128, 146 }, 169) + _0x0a5e32f2._0x73015297(new byte[30] { 185, 184, 187, 245, 173, 175, 178, 169, 178, 241, 250, 176, 188, 165, 137, 178, 168, 190, 181, 141, 178, 180, 179, 169, 174, 250, 241, 232, 244, 230 }, 221) + _0x0a5e32f2._0x73015297(new byte[48] { 117, 115, 120, 122, 119, 96, 115, 33, 116, 96, 101, 60, 122, 99, 115, 96, 111, 101, 114, 59, 90, 122, 99, 115, 96, 111, 101, 59, 38, 66, 105, 115, 110, 108, 104, 116, 108, 38, 45, 119, 100, 115, 114, 104, 110, 111, 59, 38 }, 1) + _0x17dc90da + _0x0a5e32f2._0x73015297(new byte[35] { 180, 238, 191, 232, 241, 225, 242, 253, 247, 169, 180, 212, 252, 252, 244, 255, 246, 179, 208, 251, 225, 252, 254, 246, 180, 191, 229, 246, 225, 224, 250, 252, 253, 169, 180 }, 147) + _0x17dc90da + _0x0a5e32f2._0x73015297(new byte[238] { 97, 59, 106, 61, 36, 52, 39, 40, 34, 124, 97, 8, 41, 50, 123, 7, 121, 4, 52, 39, 40, 34, 97, 106, 48, 35, 52, 53, 47, 41, 40, 124, 97, 116, 114, 97, 59, 27, 106, 43, 41, 36, 47, 42, 35, 124, 50, 52, 51, 35, 106, 54, 42, 39, 50, 32, 41, 52, 43, 124, 97, 7, 40, 34, 52, 41, 47, 34, 97, 106, 33, 35, 50, 14, 47, 33, 46, 3, 40, 50, 52, 41, 54, 63, 16, 39, 42, 51, 35, 53, 124, 32, 51, 40, 37, 50, 47, 41, 40, 110, 111, 61, 52, 35, 50, 51, 52, 40, 102, 22, 52, 41, 43, 47, 53, 35, 104, 52, 35, 53, 41, 42, 48, 35, 110, 61, 39, 52, 37, 46, 47, 50, 35, 37, 50, 51, 52, 35, 124, 97, 39, 52, 43, 97, 106, 36, 47, 50, 40, 35, 53, 53, 124, 97, 112, 114, 97, 106, 43, 41, 36, 47, 42, 35, 124, 50, 52, 51, 35, 106, 43, 41, 34, 35, 42, 124, 97, 97, 106, 54, 42, 39, 50, 32, 41, 52, 43, 124, 97, 7, 40, 34, 52, 41, 47, 34, 97, 106, 54, 42, 39, 50, 32, 41, 52, 43, 16, 35, 52, 53, 47, 41, 40, 124, 97, 119, 114, 104, 118, 104, 118, 97, 106, 51, 39, 0, 51, 42, 42, 16, 35, 52, 53, 47, 41, 40, 124, 97 }, 70) + _0x17dc90da + _0x0a5e32f2._0x73015297(new byte[117] { 118, 104, 118, 104, 118, 104, 127, 37, 113, 99, 37, 37, 99, 23, 58, 50, 61, 59, 44, 118, 60, 61, 62, 49, 54, 61, 8, 42, 55, 40, 61, 42, 44, 33, 112, 40, 42, 55, 44, 55, 116, 127, 45, 43, 61, 42, 25, 63, 61, 54, 44, 28, 57, 44, 57, 127, 116, 35, 63, 61, 44, 98, 62, 45, 54, 59, 44, 49, 55, 54, 112, 113, 35, 42, 61, 44, 45, 42, 54, 120, 45, 57, 60, 99, 37, 116, 59, 55, 54, 62, 49, 63, 45, 42, 57, 58, 52, 61, 98, 44, 42, 45, 61, 37, 113, 99, 37, 59, 57, 44, 59, 48, 112, 61, 113, 35, 37 }, 88) + _0x0a5e32f2._0x73015297(new byte[5] { 148, 192, 193, 192, 210 }, 233);
    }

    private string _0xd77d9358 = "";
    private string _0x8c4288f1 = "";
    internal string _0x966fd780(string _0x77731e14)
    {
        int _0x1c7710e5 = _0x77731e14.IndexOf(_0x0a5e32f2._0x73015297(new byte[3] { 229, 232, 177 }, 140), StringComparison.OrdinalIgnoreCase);
        if (_0x1c7710e5 < 0)
            return null;
        string _0x912e66b2 = _0x77731e14.Substring(_0x1c7710e5 + 3);
        int _0xb0eb0473 = _0x912e66b2.IndexOf('&');
        return _0xb0eb0473 >= 0 ? _0x912e66b2.Substring(0, _0xb0eb0473) : _0x912e66b2;
    }

    private string _0xcb26ab7e(string _0x2aa8bcf5, string _0x74c0edac)
    {
        if (string.IsNullOrEmpty(_0x74c0edac))
            return _0x2aa8bcf5;
        if (_0x2aa8bcf5.Contains(_0x0a5e32f2._0x73015297(new byte[1] { 82 }, 109)))
            return _0x2aa8bcf5 + _0x0a5e32f2._0x73015297(new byte[8] { 225, 180, 162, 169, 163, 174, 163, 250 }, 199) + UnityWebRequest.EscapeURL(_0x74c0edac);
        else
            return _0x2aa8bcf5 + _0x0a5e32f2._0x73015297(new byte[8] { 190, 242, 228, 239, 229, 232, 229, 188 }, 129) + UnityWebRequest.EscapeURL(_0x74c0edac);
    }

    private string _0x14eb206f = "";
    private string Decrypt(string _0xf25a0764, string _0x4c859bdc)
    {
        try
        {
            var _0x4b1a111b = Convert.FromBase64String(_0xf25a0764);
            using var _0x6b703631 = Aes.Create();
            _0x6b703631.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x4c859bdc));
            var _0x8821eb36 = new byte[16];
            Buffer.BlockCopy(_0x4b1a111b, 0, _0x8821eb36, 0, 16);
            _0x6b703631.IV = _0x8821eb36;
            using var _0xf84b9311 = new MemoryStream(_0x4b1a111b, 16, _0x4b1a111b.Length - 16);
            using var _0xd4d6f0a7 = new CryptoStream(_0xf84b9311, _0x6b703631.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0xa4eda0b7 = new StreamReader(_0xd4d6f0a7, Encoding.UTF8);
            return _0xa4eda0b7.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private string _0x380858e0;
    private bool _0x5630f01a(string _0x2f9ca774)
    {
        try
        {
            using (var _0x27ac17a6 = new AndroidJavaClass(_0x0a5e32f2._0x73015297(new byte[30] { 132, 136, 138, 201, 146, 137, 142, 147, 158, 212, 131, 201, 151, 139, 134, 158, 130, 149, 201, 178, 137, 142, 147, 158, 183, 139, 134, 158, 130, 149 }, 231)))
            using (var _0xabd3d24a = _0x27ac17a6.GetStatic<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[15] { 91, 77, 74, 74, 93, 86, 76, 121, 91, 76, 81, 78, 81, 76, 65 }, 56)))
            using (var _0x744d14f3 = _0xabd3d24a.Call<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[17] { 230, 228, 245, 209, 224, 226, 234, 224, 230, 228, 204, 224, 239, 224, 230, 228, 243 }, 129)))
            using (var _0xf12f5231 = new AndroidJavaClass(_0x0a5e32f2._0x73015297(new byte[22] { 74, 69, 79, 89, 68, 66, 79, 5, 72, 68, 69, 95, 78, 69, 95, 5, 98, 69, 95, 78, 69, 95 }, 43)))
            using (var _0xd45ea3f8 = _0xf12f5231.CallStatic<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[8] { 34, 51, 32, 33, 55, 7, 32, 59 }, 82), _0x2f9ca774, 1))
            {
                string _0x560eb869 = _0xd45ea3f8.Call<string>(_0x0a5e32f2._0x73015297(new byte[14] { 166, 164, 181, 146, 181, 179, 168, 175, 166, 132, 185, 181, 179, 160 }, 193), _0x0a5e32f2._0x73015297(new byte[20] { 216, 200, 213, 205, 201, 223, 200, 229, 220, 219, 214, 214, 216, 219, 217, 209, 229, 207, 200, 214 }, 186));
                string _0x59d0c2c8 = _0xd45ea3f8.Call<string>(_0x0a5e32f2._0x73015297(new byte[10] { 70, 68, 85, 113, 64, 66, 74, 64, 70, 68 }, 33));
                _0xd45ea3f8.Call<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[11] { 212, 209, 209, 246, 212, 193, 208, 210, 218, 199, 204 }, 181), _0x0a5e32f2._0x73015297(new byte[33] { 43, 36, 46, 56, 37, 35, 46, 100, 35, 36, 62, 47, 36, 62, 100, 41, 43, 62, 47, 45, 37, 56, 51, 100, 8, 24, 5, 29, 25, 11, 8, 6, 15 }, 74));
                _0xd45ea3f8.Call<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[11] { 222, 201, 193, 195, 218, 201, 233, 212, 216, 222, 205 }, 172), _0x0a5e32f2._0x73015297(new byte[20] { 158, 142, 147, 139, 143, 153, 142, 163, 154, 157, 144, 144, 158, 157, 159, 151, 163, 137, 142, 144 }, 252));
                if (_0xd45ea3f8.Call<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[15] { 183, 160, 182, 170, 169, 179, 160, 132, 166, 177, 172, 179, 172, 177, 188 }, 197), _0x744d14f3) != null)
                {
                    WLog(_0x0a5e32f2._0x73015297(new byte[24] { 215, 252, 230, 251, 249, 241, 216, 253, 255, 241, 180, 251, 228, 241, 250, 180, 253, 250, 224, 241, 250, 224, 174, 180 }, 148) + _0x2f9ca774);
                    _0xd45ea3f8.Call<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[8] { 92, 89, 89, 123, 81, 92, 90, 78 }, 61), 0x10000000);
                    _0xabd3d24a.Call(_0x0a5e32f2._0x73015297(new byte[13] { 122, 125, 104, 123, 125, 72, 106, 125, 96, 127, 96, 125, 112 }, 9), _0xd45ea3f8);
                    return true;
                }

                if (_0x585e3ccd(_0x59d0c2c8))
                    return true;
                if (!string.IsNullOrEmpty(_0x560eb869))
                {
                    WLog(_0x0a5e32f2._0x73015297(new byte[28] { 217, 242, 232, 245, 247, 255, 214, 243, 241, 255, 186, 243, 244, 238, 255, 244, 238, 186, 252, 251, 246, 246, 248, 251, 249, 241, 160, 186 }, 154) + _0x560eb869);
                    if (_0x1cc7510a(_0x560eb869))
                        return _0x2179d5b1(_0x560eb869, _0x59d0c2c8);
                    return _0xee30c790(_0x560eb869);
                }

                WLog(_0x0a5e32f2._0x73015297(new byte[30] { 233, 194, 216, 197, 199, 207, 230, 195, 193, 207, 138, 195, 196, 222, 207, 196, 222, 138, 196, 197, 138, 194, 203, 196, 206, 198, 207, 216, 144, 138 }, 170) + _0x2f9ca774);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x0a5e32f2._0x73015297(new byte[26] { 239, 196, 222, 195, 193, 201, 224, 197, 199, 201, 140, 197, 194, 216, 201, 194, 216, 140, 202, 205, 197, 192, 201, 200, 150, 140 }, 172) + e.Message);
            return true;
        }
    }

    private readonly List<UniWebViewPopup> _0xe0603d2f = new List<UniWebViewPopup>();
    private async Task _0x570edb3b()
    {
        if (await _0x95777bf6())
            return;
        if (await _0x74c005d8())
            return;
        if (await _0xf95e84ff())
            return;
        _0xd0886385();
        await _0xad7cc80e(_0xd48261b6());
        _0x6a49f12d = await _0x6f1b9fd6();
        await _0xa2861b45();
    }

    internal bool isApplicationFocus = false;
    private AndroidJavaObject _0x60378baf { get; set; }

    private async Task _0xa2861b45()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x8c4288f1 = _0x0a5e32f2._0x73015297(new byte[5] { 178, 181, 184, 167, 177 }, 212);
        _0xd77d9358 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x54f39c71 = DateTime.UtcNow.Ticks.ToString();
        _0x7e2b8ac9 = "";
        JObject _0xe1c82406 = _0x17e1ebc1(_0x9774d32a, _0xed4798d1, _0x0d973d13, _0x124f96d7, _0xe871f930, _0x1e000e5a, _0x9dff8d65, _0x5b03a129, _0x6a49f12d, _0x2adf6d23, _0x8c4288f1, _0x7e2b8ac9, _0x93e85806, _0x3e4114e1, _0x8d3b75f4.ToString(), _0x14eb206f, _0x54f39c71, _0xd77d9358, _0x40166447, _0x266691a6, _0x75ac7904, _0x1c9e8f28, _0x65d451a4());
        var _0xa482e89e = _0x2ee4c9e6(_0xe1c82406.ToString(), _0x40166447);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0xe1c82406}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x0a5e32f2._0x73015297(new byte[7] { 30, 15, 23, 2, 1, 15, 10 }, 110) + _0x40166447, _0xa482e89e } });
            await Task.Delay(500);
            string _0x7fb3939e = "";
            for (int _0x0c5123c7 = 0; _0x0c5123c7 < 20; _0x0c5123c7++)
            {
                if (await _0xbd1fe990(1, 1))
                {
                    await _0x4d7634fe(_0x0a5e32f2._0x73015297(new byte[7] { 55, 57, 58, 54, 62, 48, 49 }, 85));
                    _0xa361e3ad();
                    return;
                }

                _0x7fb3939e = await _0xb07fc09d(1, 500);
                if (!string.IsNullOrEmpty(_0x7fb3939e))
                    break;
            }

            _0x1b89be3e(_0x7fb3939e);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x0a5e32f2._0x73015297(new byte[22] { 24, 23, 6, 16, 23, 30, 99, 4, 38, 45, 38, 49, 34, 47, 99, 38, 49, 49, 44, 49, 121, 99 }, 67) + e.Message);
#endif
            }

            _0xa361e3ad();
        }
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0xa361e3ad();
    }

    private string _0x9774d32a = "";
    private JObject _0x17e1ebc1(params string[] _0xac596b69)
    {
        JObject _0x11d582c6 = new JObject();
        foreach (var _0x16e2e628 in _0xac596b69)
        {
            string _0xaa1af99d = _0x217a2683();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0xaa1af99d} val={_0x16e2e628}");
#endif
            }

            _0x11d582c6.Add(_0xaa1af99d, _0x16e2e628 == null ? "" : _0x16e2e628);
        }

        return _0x11d582c6;
    }

    private string _0x93e85806 = "";
    private bool _0x2afec387 = false;
    // MAIN FLOW
    private bool _0x81a09f57 { get; set; }

    private void _0x49cce04b()
    {
        _0x2179de34 = true;
        if (_0xe20b4fdc != null)
            _0xe20b4fdc.SetUserAgent(_0x4936e200());
    }

    private bool _0xee30c790(string _0x404b9b22)
    {
        try
        {
            using (var _0x3cdd2db5 = new AndroidJavaClass(_0x0a5e32f2._0x73015297(new byte[30] { 21, 25, 27, 88, 3, 24, 31, 2, 15, 69, 18, 88, 6, 26, 23, 15, 19, 4, 88, 35, 24, 31, 2, 15, 38, 26, 23, 15, 19, 4 }, 118)))
            using (var _0x25f41bc4 = _0x3cdd2db5.GetStatic<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[15] { 216, 206, 201, 201, 222, 213, 207, 250, 216, 207, 210, 205, 210, 207, 194 }, 187)))
            using (var _0x5e716b6d = new AndroidJavaClass(_0x0a5e32f2._0x73015297(new byte[15] { 106, 101, 111, 121, 100, 98, 111, 37, 101, 110, 127, 37, 94, 121, 98 }, 11)))
            using (var _0x4248363f = _0x5e716b6d.CallStatic<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[5] { 43, 58, 41, 40, 62 }, 91), _0x404b9b22))
            using (var _0x7d394208 = new AndroidJavaObject(_0x0a5e32f2._0x73015297(new byte[22] { 105, 102, 108, 122, 103, 97, 108, 38, 107, 103, 102, 124, 109, 102, 124, 38, 65, 102, 124, 109, 102, 124 }, 8), _0x0a5e32f2._0x73015297(new byte[26] { 131, 140, 134, 144, 141, 139, 134, 204, 139, 140, 150, 135, 140, 150, 204, 131, 129, 150, 139, 141, 140, 204, 180, 171, 167, 181 }, 226), _0x4248363f))
            {
                WLog(_0x0a5e32f2._0x73015297(new byte[26] { 90, 113, 107, 118, 116, 124, 85, 112, 114, 124, 57, 118, 105, 124, 119, 57, 124, 97, 109, 124, 107, 119, 120, 117, 35, 57 }, 25) + _0x404b9b22);
                _0x7d394208.Call<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[11] { 225, 228, 228, 195, 225, 244, 229, 231, 239, 242, 249 }, 128), _0x0a5e32f2._0x73015297(new byte[33] { 24, 23, 29, 11, 22, 16, 29, 87, 16, 23, 13, 28, 23, 13, 87, 26, 24, 13, 28, 30, 22, 11, 0, 87, 59, 43, 54, 46, 42, 56, 59, 53, 60 }, 121));
                _0x7d394208.Call<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[8] { 1, 4, 4, 38, 12, 1, 7, 19 }, 96), 0x10000000);
                _0x25f41bc4.Call(_0x0a5e32f2._0x73015297(new byte[13] { 162, 165, 176, 163, 165, 144, 178, 165, 184, 167, 184, 165, 168 }, 209), _0x7d394208);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x0a5e32f2._0x73015297(new byte[28] { 21, 62, 36, 57, 59, 51, 26, 63, 61, 51, 118, 51, 46, 34, 51, 36, 56, 55, 58, 118, 48, 55, 63, 58, 51, 50, 108, 118 }, 86) + e.Message);
            Application.OpenURL(_0x404b9b22);
            return true;
        }
    }

    private string _0x75ac7904 = "";
    private bool _0x2179de34 = false;
    private string _0x0d973d13 = "";
    private string _0x65d451a4()
    {
        float _0x2945dbf5 = Time.realtimeSinceStartup;
        if (_0x2945dbf5 < 0f)
            _0x2945dbf5 = 0f;
        int _0xddc7fd4c = (int)(_0x2945dbf5 * 1000f);
        int _0x9559831e = _0xddc7fd4c / 60000;
        int _0x03c62260 = (_0xddc7fd4c / 1000) % 60;
        int _0x46b84a45 = _0xddc7fd4c % 1000;
        return string.Format(_0x0a5e32f2._0x73015297(new byte[21] { 250, 177, 187, 177, 177, 252, 187, 250, 176, 187, 177, 177, 252, 187, 250, 179, 187, 177, 177, 177, 252 }, 129), _0x9559831e, _0x03c62260, _0x46b84a45);
    }

    private string _0x1c9e8f28 = "";
    private string _0xe4308edb()
    {
        try
        {
            using (var _0xee559e40 = new AndroidJavaClass(_0x0a5e32f2._0x73015297(new byte[30] { 225, 237, 239, 172, 247, 236, 235, 246, 251, 177, 230, 172, 242, 238, 227, 251, 231, 240, 172, 215, 236, 235, 246, 251, 210, 238, 227, 251, 231, 240 }, 130)))
            {
                var _0x6024befb = _0xee559e40.GetStatic<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[15] { 157, 139, 140, 140, 155, 144, 138, 191, 157, 138, 151, 136, 151, 138, 135 }, 254));
                var _0x7355c1a0 = _0x6024befb.Call<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[21] { 192, 194, 211, 230, 215, 215, 203, 206, 196, 198, 211, 206, 200, 201, 228, 200, 201, 211, 194, 223, 211 }, 167));
                using (var _0x773f906b = new AndroidJavaClass(_0x0a5e32f2._0x73015297(new byte[26] { 251, 244, 254, 232, 245, 243, 254, 180, 237, 255, 248, 241, 243, 238, 180, 205, 255, 248, 201, 255, 238, 238, 243, 244, 253, 233 }, 154)))
                {
                    return _0x773f906b.CallStatic<string>(_0x0a5e32f2._0x73015297(new byte[19] { 64, 66, 83, 99, 66, 65, 70, 82, 75, 83, 114, 84, 66, 85, 102, 64, 66, 73, 83 }, 39), _0x7355c1a0);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private bool _0x47a80d4e = false;
    private void _0x883fb1a6(string _0xd5ea880f)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x0a5e32f2._0x73015297(new byte[34] { 8, 7, 54, 32, 39, 14, 115, 21, 54, 39, 48, 59, 115, 22, 43, 39, 33, 50, 115, 3, 38, 32, 59, 115, 23, 50, 39, 50, 115, 1, 50, 36, 105, 115 }, 83) + _0xd5ea880f);
#endif
            }
        }

        var _0x08208fe9 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xd5ea880f);
        StartCoroutine(_0xc07f111b(_0x08208fe9));
    }

    private IEnumerator _0x9ee10ab3()
    {
        yield return _0x4f203aca(Permission.Camera);
    }

    private async Task _0x4d7634fe(string _0x4f7be9fb)
    {
        if (_0x47a80d4e || string.IsNullOrEmpty(_0x40166447) || string.IsNullOrEmpty(_0x4f7be9fb) || _0x4890fb3d)
            return;
        _0x47a80d4e = true;
        try
        {
            JObject _0x348c9b54 = _0x17e1ebc1(_0x4f7be9fb, _0x40166447, _0x65d451a4());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x4f7be9fb} payload: {_0x348c9b54}");
                }
#endif
            }

            var _0x292098d0 = _0x2ee4c9e6(_0x348c9b54.ToString(), _0x40166447);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x0a5e32f2._0x73015297(new byte[4] { 205, 206, 192, 197 }, 161) + _0x40166447, _0x292098d0 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x0a5e32f2._0x73015297(new byte[24] { 242, 253, 236, 250, 253, 244, 137, 229, 198, 200, 205, 137, 217, 200, 218, 218, 137, 204, 219, 219, 198, 219, 147, 137 }, 169) + e.Message);
#endif
            }
        }
    }

    private int _0x3e0430b9 = -1;
    internal bool _0x1cc7510a(string _0x3b5348ac)
    {
        return _0x3b5348ac.StartsWith(_0x0a5e32f2._0x73015297(new byte[9] { 150, 154, 137, 144, 158, 143, 193, 212, 212 }, 251), StringComparison.OrdinalIgnoreCase) || _0x3b5348ac.StartsWith(_0x0a5e32f2._0x73015297(new byte[24] { 183, 171, 171, 175, 172, 229, 240, 240, 175, 179, 190, 166, 241, 184, 176, 176, 184, 179, 186, 241, 188, 176, 178, 240 }, 223), StringComparison.OrdinalIgnoreCase) || _0x3b5348ac.StartsWith(_0x0a5e32f2._0x73015297(new byte[23] { 83, 79, 79, 75, 1, 20, 20, 75, 87, 90, 66, 21, 92, 84, 84, 92, 87, 94, 21, 88, 84, 86, 20 }, 59), StringComparison.OrdinalIgnoreCase);
    }

    private async Task<bool> _0x74c005d8()
    {
        _0x9765d4e7.Instance?._0xc6fd1e7e();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0xa06feaf1) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x0a5e32f2._0x73015297(new byte[32] { 165, 170, 155, 141, 138, 163, 222, 171, 144, 151, 138, 135, 222, 174, 139, 141, 150, 222, 176, 145, 138, 151, 152, 151, 157, 159, 138, 151, 145, 144, 196, 222 }, 254) + string.Join(_0x0a5e32f2._0x73015297(new byte[1] { 0 }, 9), _0xa06feaf1));
                }
#endif
            }
        };
        try
        {
            _0x124f96d7 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x0a5e32f2._0x73015297(new byte[31] { 11, 4, 53, 35, 36, 13, 112, 22, 49, 57, 60, 53, 52, 112, 36, 63, 112, 55, 53, 36, 112, 32, 37, 35, 56, 112, 36, 63, 59, 53, 62 }, 80));
                }
#endif
            }

            _0x124f96d7 = "";
        }

        _0xed00c050 = !string.IsNullOrEmpty(_0x124f96d7);
        _0x1c9e8f28 = _0x65d451a4();
        {
#if B_LOGS
            Debug.Log(_0x0a5e32f2._0x73015297(new byte[25] { 11, 4, 53, 35, 36, 13, 112, 5, 62, 57, 36, 41, 112, 0, 37, 35, 56, 112, 4, 63, 59, 53, 62, 106, 112 }, 80) + _0x124f96d7);
#endif
        }

        _0x9765d4e7.Instance?._0x72b5d0cb();
        return false;
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x6f1b9fd6()
    {
        var _0xfe35ffac = _0x0a5e32f2._0x73015297(new byte[40] { 136, 148, 148, 144, 147, 218, 207, 207, 151, 151, 151, 206, 131, 140, 143, 149, 132, 134, 140, 129, 146, 133, 206, 131, 143, 141, 207, 131, 132, 142, 205, 131, 135, 137, 207, 148, 146, 129, 131, 133 }, 224);
        using (UnityWebRequest _0x8c263318 = UnityWebRequest.Get(_0xfe35ffac))
        {
            await _0x8c263318.SendWebRequest();
            string[] _0x542ddad2 = _0x8c263318.downloadHandler.text.Split('\n');
            foreach (string _0xbabfd00f in _0x542ddad2)
            {
                if (_0xbabfd00f.StartsWith(_0x0a5e32f2._0x73015297(new byte[3] { 169, 176, 253 }, 192)))
                {
                    string _0x50c739ee = _0xbabfd00f.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x50c739ee} from {_0xfe35ffac}");
                        }
#endif
                    }

                    return _0x50c739ee;
                }
            }
        }

        return "";
    }

    private bool TryOpenExternalLikeChrome(string _0x631cbc9d)
    {
        if (string.IsNullOrEmpty(_0x631cbc9d))
            return false;
        if (_0x631cbc9d.StartsWith(_0x0a5e32f2._0x73015297(new byte[9] { 152, 159, 133, 148, 159, 133, 203, 222, 222 }, 241), StringComparison.OrdinalIgnoreCase))
            return _0x5630f01a(_0x631cbc9d);
        if (_0x1cc7510a(_0x631cbc9d))
            return _0x2179d5b1(_0x631cbc9d, null);
        if (!_0x631cbc9d.StartsWith(_0x0a5e32f2._0x73015297(new byte[7] { 123, 103, 103, 99, 41, 60, 60 }, 19), StringComparison.OrdinalIgnoreCase) && !_0x631cbc9d.StartsWith(_0x0a5e32f2._0x73015297(new byte[8] { 250, 230, 230, 226, 225, 168, 189, 189 }, 146), StringComparison.OrdinalIgnoreCase) && !_0x631cbc9d.StartsWith(_0x0a5e32f2._0x73015297(new byte[11] { 146, 145, 156, 134, 135, 201, 145, 159, 146, 157, 152 }, 243), StringComparison.OrdinalIgnoreCase))
        {
            return _0xee30c790(_0x631cbc9d);
        }

        return false;
    }

    private string _0x266691a6 = "";
    private int _0x5d9f846b = 0;
    private async Task<bool> _0x95777bf6()
    {
        {
#if B_LOGS
            Debug.Log(_0x0a5e32f2._0x73015297(new byte[37] { 80, 95, 110, 120, 127, 86, 43, 88, 98, 108, 101, 66, 101, 94, 101, 98, 127, 114, 88, 110, 121, 125, 98, 104, 110, 120, 74, 101, 100, 101, 114, 102, 100, 126, 120, 103, 114 }, 11));
#endif
        }

        try
        {
            var _0x6cb7b3de = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x6cb7b3de);
            {
#if B_LOGS
                Debug.Log(_0x0a5e32f2._0x73015297(new byte[32] { 53, 58, 11, 29, 26, 51, 78, 59, 0, 7, 26, 23, 61, 11, 28, 24, 7, 13, 11, 29, 78, 39, 0, 7, 26, 7, 15, 2, 7, 20, 11, 10 }, 110));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x0a5e32f2._0x73015297(new byte[20] { 19, 2, 20, 19, 103, 18, 41, 46, 51, 62, 20, 34, 53, 49, 46, 36, 34, 52, 125, 103 }, 71) + ex.Message);
#endif
            }

            _0xde64ea98?._0xa361e3ad();
            return true;
        }

        bool _0xd1c6820f = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0xd1c6820f = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x0a5e32f2._0x73015297(new byte[37] { 61, 50, 3, 21, 18, 59, 70, 53, 15, 1, 8, 75, 15, 8, 70, 39, 8, 9, 8, 31, 11, 9, 19, 21, 72, 70, 54, 10, 7, 31, 3, 20, 70, 47, 34, 92, 70 }, 102) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x40166447 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x0a5e32f2._0x73015297(new byte[25] { 230, 247, 225, 230, 146, 225, 219, 213, 220, 159, 219, 220, 146, 243, 199, 198, 218, 146, 247, 224, 224, 253, 224, 136, 146 }, 178) + ex.Message);
#endif
                }

                _0xde64ea98?._0xa361e3ad();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x0a5e32f2._0x73015297(new byte[28] { 106, 123, 109, 106, 30, 109, 87, 89, 80, 19, 87, 80, 30, 108, 91, 79, 75, 91, 77, 74, 30, 123, 108, 108, 113, 108, 4, 30 }, 62) + ex.Message);
#endif
                }

                _0xde64ea98?._0xa361e3ad();
                return true;
            }
        }
        while (!_0xd1c6820f);
        return false;
    }

    private bool _0xeb8d5c45()
    {
        _0xe0603d2f.RemoveAll(_0xf1c2c72e => _0xf1c2c72e == null || !_0xf1c2c72e.IsAlive);
        return _0xe0603d2f.Count > 0;
    }

    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x2ee4c9e6(string _0xb04cbfaf, string _0xb5cbca75)
    {
        try
        {
            using var _0x9c209051 = Aes.Create();
            _0x9c209051.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xb5cbca75));
            _0x9c209051.GenerateIV();
            using var _0xef08a9ba = new MemoryStream();
            _0xef08a9ba.Write(_0x9c209051.IV, 0, _0x9c209051.IV.Length);
            using (var _0x4c3fe8f1 = new CryptoStream(_0xef08a9ba, _0x9c209051.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0x33697601 = Encoding.UTF8.GetBytes(_0xb04cbfaf);
                _0x4c3fe8f1.Write(_0x33697601, 0, _0x33697601.Length);
                _0x4c3fe8f1.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0xef08a9ba.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private bool _0x7477fb8b = false;
    private bool _0x4890fb3d = false;
    public void _0xcb7672b1()
    {
        if (_0x9c601b3d)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x0a5e32f2._0x73015297(new byte[33] { 199, 200, 249, 239, 232, 193, 188, 200, 245, 241, 249, 238, 188, 243, 233, 232, 188, 177, 162, 188, 241, 243, 234, 249, 188, 232, 243, 188, 239, 255, 249, 242, 249 }, 156));
            }
#endif
        }

        _0xa361e3ad();
    }

    private int _0x1f6be05e = 5, _0x45456b6c = 5, _0xbf030fa3 = 5, _0x7c2dd2ec = 5;
    private async Task<string> _0xb07fc09d(int _0x104cf6e3 = 5, int _0x25abfdff = 500)
    {
        try
        {
            List<EntityData> _0xe705cab5 = new List<EntityData>();
            int _0x1b83ec07 = 0;
            do
            {
                _0xe705cab5 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x0a5e32f2._0x73015297(new byte[8] { 185, 165, 168, 176, 172, 187, 128, 173 }, 201), _0x40166447, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x40166447 }), new QueryOptions())).ToList();
                await Task.Delay(_0x25abfdff);
            }
            while (_0xe705cab5.Count == 0 && _0x1b83ec07++ < _0x104cf6e3);
            {
#if B_LOGS
                {
                    Debug.Log(_0x0a5e32f2._0x73015297(new byte[33] { 111, 96, 81, 71, 64, 105, 20, 103, 85, 66, 81, 80, 20, 120, 93, 90, 95, 20, 101, 65, 81, 70, 77, 20, 70, 81, 71, 65, 88, 64, 71, 14, 20 }, 52) + JsonConvert.SerializeObject(_0xe705cab5, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x0a5e32f2._0x73015297(new byte[39] { 198, 201, 248, 238, 233, 192, 189, 206, 252, 235, 248, 249, 189, 209, 244, 243, 246, 189, 204, 232, 248, 239, 228, 189, 239, 248, 238, 232, 241, 233, 238, 189, 254, 242, 232, 243, 233, 167, 189 }, 157) + _0xe705cab5.Count);
                }
#endif
            }

            var _0x031086fe = _0xe705cab5.SelectMany(_0xfe913897 => _0xfe913897.Data).FirstOrDefault(_0xb1cfaeb0 => _0xb1cfaeb0.Key == _0x40166447)?.Value.GetAs<string>() ?? string.Empty;
            _0x031086fe = Decrypt(_0x031086fe, _0x40166447);
            {
#if B_LOGS
                {
                    Debug.Log(_0x0a5e32f2._0x73015297(new byte[24] { 169, 166, 151, 129, 134, 175, 210, 190, 157, 147, 150, 210, 129, 147, 132, 151, 150, 210, 158, 155, 156, 153, 200, 210 }, 242) + _0x031086fe);
                }
#endif
            }

            return _0x031086fe;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x0a5e32f2._0x73015297(new byte[39] { 100, 107, 90, 76, 75, 98, 31, 120, 90, 75, 31, 80, 77, 31, 79, 94, 77, 76, 90, 31, 76, 94, 73, 90, 91, 31, 83, 86, 81, 84, 31, 89, 94, 86, 83, 90, 91, 5, 31 }, 63) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private string _0x5b03a129 = "";
    private static readonly string WindowsDesktopUserAgent = _0x0a5e32f2._0x73015297(new byte[111] { 247, 213, 192, 211, 214, 214, 219, 149, 143, 148, 138, 154, 146, 237, 211, 212, 222, 213, 205, 201, 154, 244, 238, 154, 139, 138, 148, 138, 129, 154, 237, 211, 212, 140, 142, 129, 154, 194, 140, 142, 147, 154, 251, 202, 202, 214, 223, 237, 223, 216, 241, 211, 206, 149, 143, 137, 141, 148, 137, 140, 154, 146, 241, 242, 238, 247, 246, 150, 154, 214, 211, 209, 223, 154, 253, 223, 217, 209, 213, 147, 154, 249, 210, 200, 213, 215, 223, 149, 139, 136, 138, 148, 138, 148, 138, 148, 138, 154, 233, 219, 220, 219, 200, 211, 149, 143, 137, 141, 148, 137, 140 }, 186);
    private string _0x2adf6d23 = "";
    private IEnumerator _0xd48261b6()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x0a5e32f2._0x73015297(new byte[26] { 222, 209, 224, 246, 241, 216, 165, 204, 235, 236, 241, 236, 228, 233, 236, 255, 224, 215, 224, 227, 227, 224, 247, 224, 247, 165 }, 133));
            }
#endif
        }

        bool _0x506fdb14 = false;
        InstallReferrer.GetReferrer((_0x5ff26702) =>
        {
            Debug.Log(_0x0a5e32f2._0x73015297(new byte[24] { 193, 206, 255, 233, 238, 186, 200, 255, 252, 255, 232, 232, 255, 232, 199, 186, 253, 255, 238, 186, 120, 28, 8, 186 }, 154) + _0xe871f930);
            if (_0x5ff26702.IsSuccess)
            {
                _0xe871f930 = _0x5ff26702.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x0a5e32f2._0x73015297(new byte[28] { 95, 80, 97, 119, 112, 36, 86, 97, 98, 97, 118, 118, 97, 118, 89, 36, 87, 113, 103, 103, 97, 119, 119, 36, 230, 130, 150, 36 }, 4) + _0xe871f930);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x0a5e32f2._0x73015297(new byte[27] { 72, 71, 118, 96, 103, 51, 65, 118, 117, 118, 97, 97, 118, 97, 78, 51, 85, 114, 122, 127, 118, 119, 51, 241, 149, 129, 51 }, 19) + _0x5ff26702);
#endif
                }

                _0xe871f930 = "";
            }

            _0x81a09f57 = true;
        });
        StartCoroutine(_0x8871f8ad(2f));
        yield return new WaitUntil(() => _0x81a09f57);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0xe871f930}");
#endif
        }

        bool _0xd93761f0 = _0xe871f930.Contains(_0x0a5e32f2._0x73015297(new byte[6] { 202, 206, 193, 196, 201, 144 }, 173));
        _0x506fdb14 = _0xd93761f0 || _0xe871f930.Contains(_0x0a5e32f2._0x73015297(new byte[18] { 122, 107, 107, 104, 53, 114, 117, 104, 111, 122, 124, 105, 122, 118, 53, 120, 116, 118 }, 27)) || _0xe871f930.Contains(_0x0a5e32f2._0x73015297(new byte[17] { 210, 195, 195, 192, 157, 213, 210, 208, 214, 209, 220, 220, 216, 157, 208, 220, 222 }, 179));
        _0x1e000e5a = _0xd93761f0 ? "" : (_0x506fdb14 ? "" : _0x1e000e5a);
        _0x1e000e5a = _0x1e000e5a ?? "";
        _0x9dff8d65 = _0x9dff8d65 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x1e000e5a}");
#endif
        }
    }

    private string _0xe871f930 = "";
    private string _0x217a2683()
    {
        string _0x144260be = _0x0a5e32f2._0x73015297(new byte[62] { 249, 250, 251, 252, 253, 254, 255, 240, 241, 242, 243, 244, 245, 246, 247, 232, 233, 234, 235, 236, 237, 238, 239, 224, 225, 226, 217, 218, 219, 220, 221, 222, 223, 208, 209, 210, 211, 212, 213, 214, 215, 200, 201, 202, 203, 204, 205, 206, 207, 192, 193, 194, 168, 169, 170, 171, 172, 173, 174, 175, 160, 161 }, 152);
        System.Random _0x4fb927c2 = new System.Random();
        int _0x85138f59 = _0x4fb927c2.Next(8, 16);
        return new string (Enumerable.Repeat(_0x144260be, _0x85138f59).Select(_0x77226082 => _0x77226082[_0x4fb927c2.Next(_0x77226082.Length)]).ToArray());
    }

    private ApplicationInstallMode _0x8d3b75f4 = ApplicationInstallMode.Unknown;
    private async void Start()
    {
        await _0x570edb3b();
    }

    private string _0xed4798d1 = "";
    private IEnumerator _0x8871f8ad(float _0x0ff87e6e)
    {
        yield return new WaitForSeconds(_0x0ff87e6e);
        if (!_0x81a09f57)
        {
            _0x81a09f57 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0xe871f930}");
                }
#endif
            }
        }
    }

    private void _0xa8ebc0ec()
    {
        WLog(_0x0a5e32f2._0x73015297(new byte[21] { 49, 24, 11, 29, 14, 24, 11, 28, 89, 27, 24, 26, 18, 89, 9, 11, 28, 10, 10, 28, 29 }, 121));
        if (Time.frameCount == _0x3e0430b9)
            return;
        _0x3e0430b9 = Time.frameCount;
        if (_0x3597602e())
            return;
        _0x71fc6390();
    }

    private string _0x124f96d7 = "";
    private void WLog(string _0x6d233342)
    {
#if B_LOGS
        {
            Debug.Log(_0x0a5e32f2._0x73015297(new byte[7] { 129, 142, 191, 169, 174, 135, 250 }, 218) + _0x6d233342);
        }
#endif
    }

    internal bool IsGoogleAuthFlowUrl(string _0x7e5955ad)
    {
        if (string.IsNullOrEmpty(_0x7e5955ad))
            return false;
        return _0x7e5955ad.IndexOf(_0x0a5e32f2._0x73015297(new byte[19] { 174, 172, 172, 160, 186, 161, 187, 188, 225, 168, 160, 160, 168, 163, 170, 225, 172, 160, 162 }, 207), StringComparison.OrdinalIgnoreCase) >= 0 || _0x7e5955ad.IndexOf(_0x0a5e32f2._0x73015297(new byte[16] { 61, 63, 63, 51, 41, 50, 40, 47, 114, 59, 51, 51, 59, 48, 57, 114 }, 92), StringComparison.OrdinalIgnoreCase) >= 0 || _0x7e5955ad.IndexOf(_0x0a5e32f2._0x73015297(new byte[21] { 153, 145, 145, 153, 146, 155, 139, 141, 155, 140, 157, 145, 144, 138, 155, 144, 138, 208, 157, 145, 147 }, 254), StringComparison.OrdinalIgnoreCase) >= 0 || _0x7e5955ad.IndexOf(_0x0a5e32f2._0x73015297(new byte[11] { 244, 224, 231, 242, 231, 250, 240, 189, 240, 252, 254 }, 147), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private bool _0x7503ed5b()
    {
        var _0xe94108e1 = Keyboard.current;
        return _0xe94108e1 != null && _0xe94108e1.escapeKey.wasPressedThisFrame;
    }

    private string _0x6892126a;
    // PART 3
    private string _0xa8adeaa5()
    {
        try
        {
            var _0x83a78039 = new AndroidJavaClass(_0x0a5e32f2._0x73015297(new byte[30] { 164, 168, 170, 233, 178, 169, 174, 179, 190, 244, 163, 233, 183, 171, 166, 190, 162, 181, 233, 146, 169, 174, 179, 190, 151, 171, 166, 190, 162, 181 }, 199));
            var _0xe252a857 = _0x83a78039.GetStatic<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[15] { 253, 235, 236, 236, 251, 240, 234, 223, 253, 234, 247, 232, 247, 234, 231 }, 158));
            var _0x32a7a274 = new AndroidJavaClass(_0x0a5e32f2._0x73015297(new byte[57] { 212, 216, 218, 153, 208, 216, 216, 208, 219, 210, 153, 214, 217, 211, 197, 216, 222, 211, 153, 208, 218, 196, 153, 214, 211, 196, 153, 222, 211, 210, 217, 195, 222, 209, 222, 210, 197, 153, 246, 211, 193, 210, 197, 195, 222, 196, 222, 217, 208, 254, 211, 244, 219, 222, 210, 217, 195 }, 183));
            var _0xfef04c5b = _0x32a7a274.CallStatic<AndroidJavaObject>(_0x0a5e32f2._0x73015297(new byte[20] { 10, 8, 25, 44, 9, 27, 8, 31, 25, 4, 30, 4, 3, 10, 36, 9, 36, 3, 11, 2 }, 109), _0xe252a857);
            var _0x6f5d7c5e = _0xfef04c5b.Call<string>(_0x0a5e32f2._0x73015297(new byte[5] { 217, 219, 202, 247, 218 }, 190));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0x6f5d7c5e}");
#endif
            }

            return string.IsNullOrEmpty(_0x6f5d7c5e) ? "" : _0x6f5d7c5e;
        }
        catch
        {
            return "";
        }
    }

    private bool _0x402938de = false;
    private string _0x3982423f()
    {
        return _0x0a5e32f2._0x73015297(new byte[12] { 235, 165, 182, 173, 160, 183, 170, 172, 173, 235, 234, 184 }, 195) + _0x0a5e32f2._0x73015297(new byte[8] { 251, 236, 255, 173, 248, 236, 176, 170 }, 141) + WindowsDesktopUserAgent + _0x0a5e32f2._0x73015297(new byte[2] { 95, 67 }, 120) + _0x0a5e32f2._0x73015297(new byte[30] { 230, 241, 226, 176, 224, 226, 255, 228, 255, 173, 222, 241, 230, 249, 247, 241, 228, 255, 226, 190, 224, 226, 255, 228, 255, 228, 233, 224, 245, 171 }, 144) + _0x0a5e32f2._0x73015297(new byte[121] { 6, 21, 14, 3, 20, 9, 15, 14, 64, 4, 5, 6, 72, 15, 2, 10, 76, 11, 5, 25, 76, 22, 1, 12, 73, 27, 20, 18, 25, 27, 47, 2, 10, 5, 3, 20, 78, 4, 5, 6, 9, 14, 5, 48, 18, 15, 16, 5, 18, 20, 25, 72, 15, 2, 10, 76, 11, 5, 25, 76, 27, 7, 5, 20, 90, 6, 21, 14, 3, 20, 9, 15, 14, 72, 73, 27, 18, 5, 20, 21, 18, 14, 64, 22, 1, 12, 91, 29, 76, 3, 15, 14, 6, 9, 7, 21, 18, 1, 2, 12, 5, 90, 20, 18, 21, 5, 29, 73, 91, 29, 3, 1, 20, 3, 8, 72, 5, 73, 27, 29, 29 }, 96) + _0x0a5e32f2._0x73015297(new byte[26] { 80, 81, 82, 28, 68, 70, 91, 64, 91, 24, 19, 65, 71, 81, 70, 117, 83, 81, 90, 64, 19, 24, 65, 85, 29, 15 }, 52) + _0x0a5e32f2._0x73015297(new byte[130] { 16, 17, 18, 92, 4, 6, 27, 0, 27, 88, 83, 21, 4, 4, 34, 17, 6, 7, 29, 27, 26, 83, 88, 83, 65, 90, 68, 84, 92, 35, 29, 26, 16, 27, 3, 7, 84, 58, 32, 84, 69, 68, 90, 68, 79, 84, 35, 29, 26, 66, 64, 79, 84, 12, 66, 64, 93, 84, 53, 4, 4, 24, 17, 35, 17, 22, 63, 29, 0, 91, 65, 71, 67, 90, 71, 66, 84, 92, 63, 60, 32, 57, 56, 88, 84, 24, 29, 31, 17, 84, 51, 17, 23, 31, 27, 93, 84, 55, 28, 6, 27, 25, 17, 91, 69, 70, 68, 90, 68, 90, 68, 90, 68, 84, 39, 21, 18, 21, 6, 29, 91, 65, 71, 67, 90, 71, 66, 83, 93, 79 }, 116) + _0x0a5e32f2._0x73015297(new byte[30] { 114, 115, 112, 62, 102, 100, 121, 98, 121, 58, 49, 102, 122, 119, 98, 112, 121, 100, 123, 49, 58, 49, 65, 127, 120, 37, 36, 49, 63, 45 }, 22) + _0x0a5e32f2._0x73015297(new byte[34] { 97, 96, 99, 45, 117, 119, 106, 113, 106, 41, 34, 115, 96, 107, 97, 106, 119, 34, 41, 34, 66, 106, 106, 98, 105, 96, 37, 76, 107, 102, 43, 34, 44, 62 }, 5) + _0x0a5e32f2._0x73015297(new byte[30] { 187, 186, 185, 247, 175, 173, 176, 171, 176, 243, 248, 178, 190, 167, 139, 176, 170, 188, 183, 143, 176, 182, 177, 171, 172, 248, 243, 239, 246, 228 }, 223) + _0x0a5e32f2._0x73015297(new byte[449] { 188, 186, 177, 179, 190, 169, 186, 232, 189, 169, 172, 245, 179, 170, 186, 169, 166, 172, 187, 242, 147, 179, 170, 186, 169, 166, 172, 242, 239, 139, 160, 186, 167, 165, 161, 189, 165, 239, 228, 190, 173, 186, 187, 161, 167, 166, 242, 239, 249, 250, 248, 239, 181, 228, 179, 170, 186, 169, 166, 172, 242, 239, 143, 167, 167, 175, 164, 173, 232, 139, 160, 186, 167, 165, 173, 239, 228, 190, 173, 186, 187, 161, 167, 166, 242, 239, 249, 250, 248, 239, 181, 228, 179, 170, 186, 169, 166, 172, 242, 239, 134, 167, 188, 245, 137, 247, 138, 186, 169, 166, 172, 239, 228, 190, 173, 186, 187, 161, 167, 166, 242, 239, 250, 252, 239, 181, 149, 228, 165, 167, 170, 161, 164, 173, 242, 174, 169, 164, 187, 173, 228, 184, 164, 169, 188, 174, 167, 186, 165, 242, 239, 159, 161, 166, 172, 167, 191, 187, 239, 228, 175, 173, 188, 128, 161, 175, 160, 141, 166, 188, 186, 167, 184, 177, 158, 169, 164, 189, 173, 187, 242, 174, 189, 166, 171, 188, 161, 167, 166, 224, 225, 179, 186, 173, 188, 189, 186, 166, 232, 152, 186, 167, 165, 161, 187, 173, 230, 186, 173, 187, 167, 164, 190, 173, 224, 179, 169, 186, 171, 160, 161, 188, 173, 171, 188, 189, 186, 173, 242, 239, 176, 240, 254, 239, 228, 170, 161, 188, 166, 173, 187, 187, 242, 239, 254, 252, 239, 228, 165, 167, 170, 161, 164, 173, 242, 174, 169, 164, 187, 173, 228, 165, 167, 172, 173, 164, 242, 239, 239, 228, 184, 164, 169, 188, 174, 167, 186, 165, 242, 239, 159, 161, 166, 172, 167, 191, 187, 239, 228, 184, 164, 169, 188, 174, 167, 186, 165, 158, 173, 186, 187, 161, 167, 166, 242, 239, 249, 253, 230, 248, 230, 248, 239, 228, 189, 169, 142, 189, 164, 164, 158, 173, 186, 187, 161, 167, 166, 242, 239, 249, 250, 248, 230, 248, 230, 248, 230, 248, 239, 181, 225, 243, 181, 181, 243, 135, 170, 162, 173, 171, 188, 230, 172, 173, 174, 161, 166, 173, 152, 186, 167, 184, 173, 186, 188, 177, 224, 184, 186, 167, 188, 167, 228, 239, 189, 187, 173, 186, 137, 175, 173, 166, 188, 140, 169, 188, 169, 239, 228, 179, 175, 173, 188, 242, 174, 189, 166, 171, 188, 161, 167, 166, 224, 225, 179, 186, 173, 188, 189, 186, 166, 232, 189, 169, 172, 243, 181, 228, 171, 167, 166, 174, 161, 175, 189, 186, 169, 170, 164, 173, 242, 188, 186, 189, 173, 181, 225, 243, 181, 171, 169, 188, 171, 160, 224, 173, 225, 179, 181 }, 200) + _0x0a5e32f2._0x73015297(new byte[112] { 38, 39, 36, 106, 49, 33, 48, 39, 39, 44, 110, 101, 53, 43, 38, 54, 42, 101, 110, 115, 123, 112, 114, 107, 121, 38, 39, 36, 106, 49, 33, 48, 39, 39, 44, 110, 101, 42, 39, 43, 37, 42, 54, 101, 110, 115, 114, 122, 114, 107, 121, 38, 39, 36, 106, 49, 33, 48, 39, 39, 44, 110, 101, 35, 52, 35, 43, 46, 21, 43, 38, 54, 42, 101, 110, 115, 123, 112, 114, 107, 121, 38, 39, 36, 106, 49, 33, 48, 39, 39, 44, 110, 101, 35, 52, 35, 43, 46, 10, 39, 43, 37, 42, 54, 101, 110, 115, 114, 118, 114, 107, 121 }, 66) + _0x0a5e32f2._0x73015297(new byte[45] { 51, 53, 62, 60, 48, 46, 41, 35, 40, 48, 105, 40, 41, 51, 40, 50, 36, 47, 52, 51, 38, 53, 51, 122, 50, 41, 35, 34, 33, 46, 41, 34, 35, 124, 58, 36, 38, 51, 36, 47, 111, 34, 110, 60, 58 }, 71) + _0x0a5e32f2._0x73015297(new byte[721] { 180, 178, 185, 187, 182, 161, 178, 224, 175, 178, 169, 167, 253, 183, 169, 174, 164, 175, 183, 238, 173, 161, 180, 163, 168, 141, 165, 164, 169, 161, 238, 162, 169, 174, 164, 232, 183, 169, 174, 164, 175, 183, 233, 251, 183, 169, 174, 164, 175, 183, 238, 173, 161, 180, 163, 168, 141, 165, 164, 169, 161, 253, 166, 181, 174, 163, 180, 169, 175, 174, 232, 177, 233, 187, 182, 161, 178, 224, 179, 253, 147, 180, 178, 169, 174, 167, 232, 177, 233, 238, 180, 175, 140, 175, 183, 165, 178, 131, 161, 179, 165, 232, 233, 251, 169, 166, 232, 179, 238, 169, 174, 164, 165, 184, 143, 166, 232, 231, 176, 175, 169, 174, 180, 165, 178, 250, 224, 163, 175, 161, 178, 179, 165, 231, 233, 254, 253, 240, 188, 188, 179, 238, 169, 174, 164, 165, 184, 143, 166, 232, 231, 168, 175, 182, 165, 178, 250, 224, 174, 175, 174, 165, 231, 233, 254, 253, 240, 188, 188, 179, 238, 169, 174, 164, 165, 184, 143, 166, 232, 231, 173, 161, 184, 237, 183, 169, 164, 180, 168, 231, 233, 254, 253, 240, 188, 188, 179, 238, 169, 174, 164, 165, 184, 143, 166, 232, 231, 173, 161, 184, 237, 164, 165, 182, 169, 163, 165, 237, 183, 169, 164, 180, 168, 231, 233, 254, 253, 240, 233, 178, 165, 180, 181, 178, 174, 224, 187, 173, 161, 180, 163, 168, 165, 179, 250, 166, 161, 172, 179, 165, 236, 173, 165, 164, 169, 161, 250, 177, 236, 175, 174, 163, 168, 161, 174, 167, 165, 250, 174, 181, 172, 172, 236, 161, 164, 164, 140, 169, 179, 180, 165, 174, 165, 178, 250, 166, 181, 174, 163, 180, 169, 175, 174, 232, 233, 187, 189, 236, 178, 165, 173, 175, 182, 165, 140, 169, 179, 180, 165, 174, 165, 178, 250, 166, 181, 174, 163, 180, 169, 175, 174, 232, 233, 187, 189, 236, 161, 164, 164, 133, 182, 165, 174, 180, 140, 169, 179, 180, 165, 174, 165, 178, 250, 166, 181, 174, 163, 180, 169, 175, 174, 232, 233, 187, 189, 236, 178, 165, 173, 175, 182, 165, 133, 182, 165, 174, 180, 140, 169, 179, 180, 165, 174, 165, 178, 250, 166, 181, 174, 163, 180, 169, 175, 174, 232, 233, 187, 189, 236, 164, 169, 179, 176, 161, 180, 163, 168, 133, 182, 165, 174, 180, 250, 166, 181, 174, 163, 180, 169, 175, 174, 232, 233, 187, 178, 165, 180, 181, 178, 174, 224, 166, 161, 172, 179, 165, 251, 189, 189, 251, 169, 166, 232, 179, 238, 169, 174, 164, 165, 184, 143, 166, 232, 231, 176, 175, 169, 174, 180, 165, 178, 250, 224, 166, 169, 174, 165, 231, 233, 254, 253, 240, 188, 188, 179, 238, 169, 174, 164, 165, 184, 143, 166, 232, 231, 168, 175, 182, 165, 178, 250, 224, 168, 175, 182, 165, 178, 231, 233, 254, 253, 240, 233, 178, 165, 180, 181, 178, 174, 224, 187, 173, 161, 180, 163, 168, 165, 179, 250, 180, 178, 181, 165, 236, 173, 165, 164, 169, 161, 250, 177, 236, 175, 174, 163, 168, 161, 174, 167, 165, 250, 174, 181, 172, 172, 236, 161, 164, 164, 140, 169, 179, 180, 165, 174, 165, 178, 250, 166, 181, 174, 163, 180, 169, 175, 174, 232, 233, 187, 189, 236, 178, 165, 173, 175, 182, 165, 140, 169, 179, 180, 165, 174, 165, 178, 250, 166, 181, 174, 163, 180, 169, 175, 174, 232, 233, 187, 189, 236, 161, 164, 164, 133, 182, 165, 174, 180, 140, 169, 179, 180, 165, 174, 165, 178, 250, 166, 181, 174, 163, 180, 169, 175, 174, 232, 233, 187, 189, 236, 178, 165, 173, 175, 182, 165, 133, 182, 165, 174, 180, 140, 169, 179, 180, 165, 174, 165, 178, 250, 166, 181, 174, 163, 180, 169, 175, 174, 232, 233, 187, 189, 236, 164, 169, 179, 176, 161, 180, 163, 168, 133, 182, 165, 174, 180, 250, 166, 181, 174, 163, 180, 169, 175, 174, 232, 233, 187, 178, 165, 180, 181, 178, 174, 224, 166, 161, 172, 179, 165, 251, 189, 189, 251, 178, 165, 180, 181, 178, 174, 224, 175, 178, 169, 167, 232, 177, 233, 251, 189, 251, 189, 163, 161, 180, 163, 168, 232, 165, 233, 187, 189 }, 192) + _0x0a5e32f2._0x73015297(new byte[5] { 48, 100, 101, 100, 118 }, 77);
    }

    private static bool IsPrivacyItemTrue(Item _0x8dabe627)
    {
        if (_0x8dabe627.Key != _0x0a5e32f2._0x73015297(new byte[9] { 160, 186, 153, 187, 160, 191, 168, 170, 176 }, 201))
            return false;
        try
        {
            var _0x8ab76c23 = _0x8dabe627.Value.GetAs<object>();
            return _0x8ab76c23 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private void Awake()
    {
        if (_0xde64ea98 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0xde64ea98 = gameObject.GetComponent<_0xa6dd49b8>();
        DontDestroyOnLoad(gameObject);
        _0x124f96d7 = _0x1e000e5a = _0x9dff8d65 = "";
        _0x4758fdb3 = "";
        _0x9c601b3d = false;
    }

    private IEnumerator _0xc07f111b(Dictionary<string, object> _0x03258155)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x0a5e32f2._0x73015297(new byte[30] { 239, 224, 209, 199, 192, 233, 148, 242, 209, 192, 215, 220, 148, 241, 204, 192, 198, 213, 148, 228, 193, 199, 220, 148, 240, 213, 192, 213, 142, 148 }, 180) + string.Join(_0x0a5e32f2._0x73015297(new byte[1] { 212 }, 221), _0x03258155));
#endif
            }
        }

        string _0x0e0f9269 = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x03258155 != null && _0x03258155.TryGetValue(_0x0a5e32f2._0x73015297(new byte[16] { 192, 193, 218, 199, 200, 199, 205, 207, 218, 199, 193, 192, 234, 207, 218, 207 }, 174), out var raw))
        {
            try
            {
                var _0x4418fb33 = raw?.ToString();
                var _0x54e544f7 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x4418fb33);
                if (_0x54e544f7 != null && _0x54e544f7.TryGetValue(_0x0a5e32f2._0x73015297(new byte[6] { 54, 32, 43, 33, 44, 33 }, 69), out var val))
                {
                    _0x0e0f9269 = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x0a5e32f2._0x73015297(new byte[30] { 173, 162, 147, 133, 130, 214, 166, 131, 133, 158, 171, 214, 188, 165, 185, 184, 214, 134, 151, 132, 133, 147, 214, 147, 132, 132, 153, 132, 204, 214 }, 246) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x0e0f9269) && _0x03258155 != null && _0x03258155.TryGetValue(_0x0a5e32f2._0x73015297(new byte[6] { 174, 184, 179, 185, 180, 185 }, 221), out var lab))
        {
            _0x0e0f9269 = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x0a5e32f2._0x73015297(new byte[38] { 0, 15, 62, 40, 47, 123, 11, 46, 40, 51, 6, 123, 29, 62, 47, 56, 51, 62, 63, 123, 40, 62, 53, 63, 50, 63, 123, 61, 41, 52, 54, 123, 49, 40, 52, 53, 97, 123 }, 91) + _0x0e0f9269);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x0e0f9269))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x0a5e32f2._0x73015297(new byte[38] { 202, 197, 244, 226, 229, 177, 193, 228, 226, 249, 204, 177, 198, 240, 248, 229, 177, 229, 254, 177, 254, 225, 244, 255, 177, 230, 248, 229, 249, 177, 226, 244, 255, 245, 248, 245, 171, 177 }, 145) + _0x0e0f9269);
            }
#endif
        }

        _0x6892126a = _0x0e0f9269;
        yield return new WaitUntil(() => _0x9c601b3d);
        var _0xdb3ff509 = _0xb07fc09d(2, 100);
        yield return new WaitUntil(() => _0xdb3ff509.IsCompleted);
        string _0xc7a487a4 = _0xdb3ff509.Result;
        if (!string.IsNullOrEmpty(_0xc7a487a4))
        {
            string _0x4747936f = _0xcb26ab7e(_0xc7a487a4, _0x0e0f9269);
            {
#if B_LOGS
                Debug.Log(_0x0a5e32f2._0x73015297(new byte[33] { 200, 199, 246, 224, 231, 179, 195, 230, 224, 251, 206, 179, 193, 246, 255, 252, 242, 247, 179, 196, 246, 241, 197, 250, 246, 228, 179, 228, 250, 231, 251, 169, 179 }, 147) + _0x4747936f);
#endif
            }

            _0xe20b4fdc.Load(_0x4747936f);
        }
    }

    internal bool firstLoadShown = false;
    private string _0x7e2b8ac9 = "";
    internal Vector2 lastSize = Vector2.zero;
    private async Task<bool> _0xbd1fe990(int _0x6a69c4ad = 5, int _0x75e27d00 = 500)
    {
        List<EntityData> _0xefe77eae = new List<EntityData>();
        int _0xa0e94b15 = 0;
        do
        {
            try
            {
                _0xefe77eae = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x0a5e32f2._0x73015297(new byte[8] { 7, 27, 22, 14, 18, 5, 62, 19 }, 119), _0x40166447, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x0a5e32f2._0x73015297(new byte[9] { 98, 120, 91, 121, 98, 125, 106, 104, 114 }, 11) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x0a5e32f2._0x73015297(new byte[32] { 233, 230, 215, 193, 198, 239, 146, 195, 199, 215, 192, 203, 243, 193, 203, 220, 209, 224, 215, 193, 199, 222, 198, 193, 146, 215, 192, 192, 221, 192, 136, 146 }, 178) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0x75e27d00);
        }
        while (_0xefe77eae.Count == 0 && _0xa0e94b15++ < _0x6a69c4ad);
        {
#if B_LOGS
            {
                Debug.Log(_0x0a5e32f2._0x73015297(new byte[32] { 241, 254, 207, 217, 222, 247, 138, 227, 217, 250, 216, 195, 220, 203, 201, 211, 138, 251, 223, 207, 216, 211, 138, 216, 207, 217, 223, 198, 222, 217, 144, 138 }, 170) + JsonConvert.SerializeObject(_0xefe77eae, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x0a5e32f2._0x73015297(new byte[38] { 136, 135, 182, 160, 167, 142, 243, 154, 160, 131, 161, 186, 165, 178, 176, 170, 243, 130, 166, 182, 161, 170, 243, 161, 182, 160, 166, 191, 167, 160, 243, 176, 188, 166, 189, 167, 233, 243 }, 211) + _0xefe77eae.Count);
            }
#endif
        }

        bool _0xf955a1f3 = true;
        if (_0xefe77eae.Count == 0)
        {
            _0xf955a1f3 = false;
        }
        else
        {
            _0xf955a1f3 = _0xefe77eae.Any(_0xfe913897 => _0xfe913897.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x0a5e32f2._0x73015297(new byte[25] { 112, 127, 78, 88, 95, 118, 11, 98, 88, 123, 89, 66, 93, 74, 72, 82, 11, 89, 78, 88, 94, 71, 95, 17, 11 }, 43) + _0xf955a1f3);
            }
#endif
        }

        return _0xf955a1f3;
    }

    private bool OpenUrlExternally(string _0x972b4544)
    {
        return _0xee30c790(_0x972b4544);
    }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0xe20b4fdc = null;
    // WEB VIEW LOGIC
    public bool _0x9c601b3d { get; set; }

    private void OnApplicationPause(bool _0x2b2470f9)
    {
        isApplicationPause = _0x2b2470f9;
    }

    private bool _0x3597602e()
    {
        if (_0xace5ca2d())
            return true;
        if (_0xe20b4fdc != null && _0xe20b4fdc.CanGoBack)
        {
            WLog(_0x0a5e32f2._0x73015297(new byte[36] { 51, 26, 9, 31, 12, 26, 9, 30, 91, 25, 26, 24, 16, 91, 86, 69, 91, 22, 26, 18, 21, 91, 44, 30, 25, 45, 18, 30, 12, 91, 60, 20, 57, 26, 24, 16 }, 123));
            _0xe20b4fdc.GoBack();
            return true;
        }

        return false;
    }

    private void _0x4ec8a23d(string _0x08b5bee0)
    {
        Dictionary<string, object> _0xd2ae89fa;
        try
        {
            _0xd2ae89fa = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x08b5bee0);
        }
        catch
        {
            return;
        }

        var _0x8e6568ae = ReadPushField(_0xd2ae89fa, _0x0a5e32f2._0x73015297(new byte[3] { 68, 67, 93 }, 49));
        if (string.IsNullOrWhiteSpace(_0x8e6568ae))
            return;
        _0x8e6568ae = _0x8e6568ae.Trim();
        if (!IsHttpUrl(_0x8e6568ae))
            return;
        if (string.Equals(_0x8e6568ae, _0x380858e0, StringComparison.Ordinal))
            return;
        _0x380858e0 = _0x8e6568ae;
        OpenUrlExternally(_0x8e6568ae);
    }
}

internal static class _0x0a5e32f2
{
    internal static string _0x73015297(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}