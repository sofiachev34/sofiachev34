using UnityEngine;

public class _0xfa938ad6 : MonoBehaviour
{
    public bool IsStoryEnabled;
    public bool IsTutorialEnabled;
    public bool IsLevelIncrementOnWin;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0xfa938ad6>();
            DontDestroyOnLoad(this.gameObject);
            this._0xfc0cc607();
        }
        else
        {
            this._0x6914aa63();
            Destroy(this.gameObject);
        }
    }

    private void _0x6914aa63()
    {
    }

    private void _0xfc0cc607()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsBestScoreEnabled;
    public bool IsLevelSelectorEnabled;
    public bool IsCheckScoreEnabled;
    public bool IsTimerEnabled;
    public bool IsOnlyWinGameEndEnabled;
    public static _0xfa938ad6 Instance;
    public bool IsSkipSplashEnabled;
}