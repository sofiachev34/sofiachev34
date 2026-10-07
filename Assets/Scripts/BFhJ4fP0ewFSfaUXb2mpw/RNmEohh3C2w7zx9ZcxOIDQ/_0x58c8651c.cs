using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x58c8651c : MonoBehaviour
{
    private void _0x6f39a93f()
    {
        float _0x6deaee1e, _0x58952a75, _0xd8b46002, _0xb9b38ec8;
        if (this._0x028ddc36 == _0x69d197fb.Landscape)
            this._0xacaed554.orthographicSize = 1f / this._0xacaed554.aspect * this._0xe94f6755 / 2f;
        else
            this._0xacaed554.orthographicSize = this._0xe94f6755 / 2f;
        this._0x8711a6d1 = 2f * this._0xacaed554.orthographicSize;
        this._0xb9b098b0 = this._0x8711a6d1 * this._0xacaed554.aspect;
        float _0x174a74cc = this._0xacaed554.transform.position.x;
        float _0x77e61415 = this._0xacaed554.transform.position.y;
        _0x6deaee1e = _0x174a74cc - this._0xb9b098b0 / 2;
        _0x58952a75 = _0x174a74cc + this._0xb9b098b0 / 2;
        _0xd8b46002 = _0x77e61415 + this._0x8711a6d1 / 2;
        _0xb9b38ec8 = _0x77e61415 - this._0x8711a6d1 / 2;
        this._0x0501f151 = new Vector3(_0x6deaee1e, _0xb9b38ec8, 0);
        this._0x4df992b6 = new Vector3(_0x174a74cc, _0xb9b38ec8, 0);
        this._0x78029143 = new Vector3(_0x58952a75, _0xb9b38ec8, 0);
        this._0xa2131140 = new Vector3(_0x6deaee1e, _0x77e61415, 0);
        this._0xee609573 = new Vector3(_0x174a74cc, _0x77e61415, 0);
        this._0xe4642b00 = new Vector3(_0x58952a75, _0x77e61415, 0);
        this._0x543bf629 = new Vector3(_0x6deaee1e, _0xd8b46002, 0);
        this._0xa616abae = new Vector3(_0x174a74cc, _0xd8b46002, 0);
        this._0x4965546b = new Vector3(_0x58952a75, _0xd8b46002, 0);
    }

    //public bool executeInUpdate;
    private float _0xb9b098b0 { get; set; }
    private Vector3 _0x78029143 { get; set; }

    public enum _0x69d197fb
    {
        Landscape,
        Portrait
    }

    private Vector3 _0xe4642b00 { get; set; }
    private Vector3 _0x0501f151 { get; set; }

    private Color _0x822ad34b = Color.white;
    private float _0xe94f6755 = 1;
    private Vector3 _0x543bf629 { get; set; }
    private Vector3 _0xa2131140 { get; set; }

    private _0x69d197fb _0x028ddc36 = _0x69d197fb.Portrait;
    private static _0x58c8651c _0x24b90cb0;
    private void Awake()
    {
        this._0xacaed554 = this.GetComponent<Camera>();
        _0x24b90cb0 = this;
        this._0x6f39a93f();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x822ad34b;
        Matrix4x4 _0x929791ee = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0xacaed554.orthographic)
        {
            float _0x8ae1fb50 = this._0xacaed554.farClipPlane - this._0xacaed554.nearClipPlane;
            float _0x0da95109 = (this._0xacaed554.farClipPlane + this._0xacaed554.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x0da95109), new Vector3(this._0xacaed554.orthographicSize * 2 * this._0xacaed554.aspect, this._0xacaed554.orthographicSize * 2, _0x8ae1fb50));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0xacaed554.fieldOfView, this._0xacaed554.farClipPlane, this._0xacaed554.nearClipPlane, this._0xacaed554.aspect);
        }

        Gizmos.matrix = _0x929791ee;
    }

    private Vector3 _0xee609573 { get; set; }
    private Vector3 _0xa616abae { get; set; }
    private Vector3 _0x4df992b6 { get; set; }

    private new Camera _0xacaed554;
    private float _0x8711a6d1 { get; set; }
    private Vector3 _0x4965546b { get; set; }
}