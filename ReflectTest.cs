using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectTest : MonoBehaviour
{
    public float force = 10.0f;
    private Vector2 _lastVelocity;
    private Rigidbody2D _rb;
    [SerializeField]private ShakeTest _shake;
    [SerializeField] private HitStop _hitStop;
    [SerializeField] private bool _Iniflg;

    //rigidbody‚Ì‘ã“ü
    void Start()
    {
        this._rb = this.GetComponent<Rigidbody2D>();
    }

    //‘¬“x‚Ì•Û‘¶
    void FixedUpdate()
    {
        this._lastVelocity = this._rb.velocity;
        if (Input.GetKeyDown(KeyCode.Z))
        {
            _rb.AddForce(transform.right * force, ForceMode2D.Impulse);
        }
    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        StartCoroutine("MoveReStart");
        Vector2 refrectVec = Vector2.Reflect(this._lastVelocity, coll.contacts[0].normal);
        this._rb.velocity = refrectVec;

        if (coll.gameObject.tag != "Enemy" && _Iniflg)
        {
            //_hitStop.Hitstop();
            _shake.Shaking();
        }
    }

    IEnumerator MoveReStart()
    {
        _rb.simulated = false;
        yield return new WaitForSeconds(0.2f);
        _rb.simulated = true;
    }
}
