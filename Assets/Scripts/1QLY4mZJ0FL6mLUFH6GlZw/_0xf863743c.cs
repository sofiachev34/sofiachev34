using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

/// Spawns and drives the stones. Every length on screen is derived from the camera
/// through HexGeometry, so the field keeps its shape on any aspect.
public sealed class _0xf863743c : MonoBehaviour
{
    [SerializeField]
    private float _boardCentreY = 0.05f;
    public void _0xf0bef678(int _0xcf2a2f4d)
    {
        if (this._0x64b9016a >= 0 && this._0x64b9016a < this._0x700c4ba1.Count)
            this._0x700c4ba1[this._0x64b9016a]._0x42cf224c(false);
        this._0x64b9016a = _0xcf2a2f4d;
        if (_0xcf2a2f4d >= 0 && _0xcf2a2f4d < this._0x700c4ba1.Count)
            this._0x700c4ba1[_0xcf2a2f4d]._0x42cf224c(true);
    }

    /// A stone lights up once every one of its ends meets an end on the far side.
    public void _0xbf856c74()
    {
        if (this._0xea963041 == null)
            return;
        int _0x94c8f65d = this._0xea963041._0xf94c1b7e < this._0x700c4ba1.Count ? this._0xea963041._0xf94c1b7e : this._0x700c4ba1.Count;
        for (int _0xc562cb78 = 0; _0xc562cb78 < _0x94c8f65d; _0xc562cb78++)
        {
            int _0xbd517526 = this._0xea963041._0xbc62c423(_0xc562cb78);
            bool _0xe8d8df3c = _0xbd517526 != 0;
            for (int _0x31d4492f = 0; _0x31d4492f < _0x6ef3ea18.EdgeCount && _0xe8d8df3c; _0x31d4492f++)
            {
                if ((_0xbd517526 & (1 << _0x31d4492f)) == 0)
                    continue;
                int _0x4e772bba = this._0xea963041._0xf3f4f447(_0xc562cb78, _0x31d4492f);
                if (_0x4e772bba < 0 || (this._0xea963041._0xbc62c423(_0x4e772bba) & (1 << _0x6ef3ea18.Opposite(_0x31d4492f))) == 0)
                    _0xe8d8df3c = false;
            }

            this._0x700c4ba1[_0xc562cb78]._0xdc3c7b18(_0xe8d8df3c);
        }
    }

    /// How far this shape has been turned away from the angle its PNG is drawn at.
    private static int TurnsOf(int _0x9c2592aa, int _0x52710534)
    {
        int _0x1897aef7 = _0xf2c3ff1c.BaseMask(_0x9c2592aa);
        for (int _0x0ad8b788 = 0; _0x0ad8b788 < _0x6ef3ea18.EdgeCount; _0x0ad8b788++)
            if (_0x6ef3ea18.RotateMask(_0x1897aef7, _0x0ad8b788) == _0x52710534)
                return _0x0ad8b788;
        return 0;
    }

    [SerializeField]
    private Camera _camera;
    private _0xc1d42807 _0xd57ea4a7;
    private int _0x64b9016a = -1;
    [SerializeField]
    private Sprite[] _kindSprites;
    public void _0x29321f6e()
    {
        if (this._plate == null || this._0xd57ea4a7 == null)
            return;
        Vector2 _0xc0402797 = new Vector2(this._0xd57ea4a7._0x83079a50 + this._plateMargin, this._0xd57ea4a7._0x4b311a29 + this._plateMargin);
        DOTween.Kill(this._plate, true);
        Sequence _0xc3957cdb = DOTween.Sequence();
        _0xc3957cdb.Append(DOTween.To(() => this._plate.size, _0x76d62a2a => this._plate.size = _0x76d62a2a, _0xc0402797 * 1.04f, 0.22f));
        _0xc3957cdb.Append(DOTween.To(() => this._plate.size, _0x76d62a2a => this._plate.size = _0x76d62a2a, _0xc0402797, 0.22f));
        _0xc3957cdb.SetTarget(this._plate);
    }

    public void _0x835d4844(_0x6ef3ea18 _0x18562521)
    {
        this._0xea963041 = _0x18562521;
        float _0xf0c7b722 = this._camera != null ? this._camera.orthographicSize : 5f;
        float _0x31ee64cc = this._camera != null ? this._camera.aspect : 0.4615f;
        this._0xd57ea4a7 = new _0xc1d42807(_0xf0c7b722, _0x31ee64cc, _0x18562521._0x66019758, this._boardCentreY);
        for (int _0x039aa60a = 0; _0x039aa60a < this._0x700c4ba1.Count; _0x039aa60a++)
            if (this._0x700c4ba1[_0x039aa60a] != null)
                Destroy(this._0x700c4ba1[_0x039aa60a].gameObject);
        this._0x700c4ba1.Clear();
        float _0xff7a1264 = this._0xd57ea4a7._0xe9f620d0;
        for (int _0xfdd125bb = 0; _0xfdd125bb < _0x18562521._0xf94c1b7e; _0xfdd125bb++)
        {
            _0xec002f89 _0xbe5c4186 = Instantiate(this._tilePrefab, this._tileHost);
            Vector2 _0x63085112 = this._0xd57ea4a7._0xbdd4da31(_0x18562521._0x25b5e108(_0xfdd125bb), _0x18562521._0xf701af3f(_0xfdd125bb));
            _0xbe5c4186.transform.localPosition = new Vector3(_0x63085112.x, _0x63085112.y, 0f);
            _0xbe5c4186.transform.localScale = Vector3.one;
            _0xbe5c4186._0x51358ce2(this._0x7510e0b3(_0x18562521._0xc52a22cc(_0xfdd125bb)), _0xff7a1264, this._litColour, this._focusColour);
            // the generator hands over a SCRAMBLED mask, so the stone has to be stood up
            // already turned: drawing every shape at its base angle would leave the
            // picture and the puzzle disagreeing from the first frame, and no amount of
            // tapping could ever bring them back into step.
            _0xbe5c4186._0x68ad5094(TurnsOf(_0x18562521._0xc52a22cc(_0xfdd125bb), _0x18562521._0xbc62c423(_0xfdd125bb)));
            this._0x700c4ba1.Add(_0xbe5c4186);
        }

        if (this._plate != null)
        {
            this._plate.size = new Vector2(this._0xd57ea4a7._0x83079a50 + this._plateMargin, this._0xd57ea4a7._0x4b311a29 + this._plateMargin);
            this._plate.transform.localPosition = new Vector3(0f, this._0xd57ea4a7._0x6031651a, 0f);
            this._plate.transform.localScale = Vector3.one;
        }

        this._0xbf856c74();
    }

    private Sprite _0x7510e0b3(int _0xc41b410a)
    {
        if (this._kindSprites == null || _0xc41b410a < 0 || _0xc41b410a >= this._kindSprites.Length)
            return null;
        return this._kindSprites[_0xc41b410a];
    }

    [SerializeField]
    private float _plateMargin = 0.42f;
    [SerializeField]
    private Transform _tileHost;
    public _0xc1d42807 _0xd9c16682
    {
        get
        {
            return this._0xd57ea4a7;
        }
    }

    public void _0xa55e52c9(int _0x1ebb9ddc)
    {
        if (_0x1ebb9ddc >= 0 && _0x1ebb9ddc < this._0x700c4ba1.Count)
            this._0x700c4ba1[_0x1ebb9ddc]._0xcfd498ff();
    }

    private readonly List<_0xec002f89> _0x700c4ba1 = new List<_0xec002f89>();
    [SerializeField]
    private Color _litColour = new Color(0.957f, 0.765f, 0.306f, 1f);
    private _0x6ef3ea18 _0xea963041;
    public void _0x49c77f6b(int _0xb7c0eeaf)
    {
        if (_0xb7c0eeaf >= 0 && _0xb7c0eeaf < this._0x700c4ba1.Count)
            this._0x700c4ba1[_0xb7c0eeaf]._0xd2f08738();
    }

    [SerializeField]
    private _0xec002f89 _tilePrefab;
    /// Closest cell centre to a world point, accepted only inside the stone. The cell
    /// centres come from HexGeometry in the host's own space, which is where Build put
    /// the stones, so the tap is converted into that space first - comparing a world
    /// point against host-local centres silently misses whenever the host (or the
    /// camera it hangs under) is not sitting on the origin.
    public int _0x96072316(Vector2 _0x64d9ec98)
    {
        if (this._0xea963041 == null || this._0xd57ea4a7 == null)
            return -1;
        Vector2 _0x4845de1b = _0x64d9ec98;
        if (this._tileHost != null)
        {
            Vector3 _0x60406ee9 = this._tileHost.InverseTransformPoint(new Vector3(_0x64d9ec98.x, _0x64d9ec98.y, 0f));
            _0x4845de1b = new Vector2(_0x60406ee9.x, _0x60406ee9.y);
        }

        float _0x4e8f0a0e = this._0xd57ea4a7._0x69336897 * 0.95f;
        int _0xe432bcf9 = -1;
        float _0x42156565 = float.MaxValue;
        for (int _0xdfbb8b93 = 0; _0xdfbb8b93 < this._0xea963041._0xf94c1b7e; _0xdfbb8b93++)
        {
            Vector2 _0x0dd9e313 = this._0xd57ea4a7._0xbdd4da31(this._0xea963041._0x25b5e108(_0xdfbb8b93), this._0xea963041._0xf701af3f(_0xdfbb8b93));
            float _0x20134894 = (_0x0dd9e313 - _0x4845de1b).sqrMagnitude;
            if (_0x20134894 < _0x42156565)
            {
                _0x42156565 = _0x20134894;
                _0xe432bcf9 = _0xdfbb8b93;
            }
        }

        return _0x42156565 <= _0x4e8f0a0e * _0x4e8f0a0e ? _0xe432bcf9 : -1;
    }

    [SerializeField]
    private SpriteRenderer _plate;
    [SerializeField]
    private Color _focusColour = new Color(0.22f, 0.784f, 1f, 1f);
}