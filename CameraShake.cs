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

    //揺らす処理
    private IEnumerator DoShake(float duration, float magnitude)
    {

        var _elapsed = 0f;

        //渡された間隔の間実行
        while (_elapsed < duration)
        {
            //X,Y軸を渡された揺れの強さ文ランダムに動かす
            var x = _pos.x + Random.Range(-1f, 1f) * magnitude;
            var y = _pos.y + Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, _pos.z);

            _elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = _pos;//揺れが始まった位置に戻す
    }

    public void InitializePos()
    {
        _pos = transform.localPosition;//現在位置
    }
}
