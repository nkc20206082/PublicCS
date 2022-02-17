using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    Vector3 _pos;

    private void Start()
    {
        InitializePos();
    }
    public void Shake(float duration, float magnitude)
    {
        StartCoroutine(DoShake(duration, magnitude));
    }

    //—h‚ç‚·ˆ—
    private IEnumerator DoShake(float duration, float magnitude)
    {

        var _elapsed = 0f;

        //“n‚³‚ê‚½ŠÔŠu‚ÌŠÔÀs
        while (_elapsed < duration)
        {
            //X,Y²‚ğ“n‚³‚ê‚½—h‚ê‚Ì‹­‚³•¶ƒ‰ƒ“ƒ_ƒ€‚É“®‚©‚·
            var x = _pos.x + Random.Range(-1f, 1f) * magnitude;
            var y = _pos.y + Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, _pos.z);

            _elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = _pos;//—h‚ê‚ªn‚Ü‚Á‚½ˆÊ’u‚É–ß‚·
    }

    public void InitializePos()
    {
        _pos = transform.localPosition;//Œ»İˆÊ’u
    }
}
