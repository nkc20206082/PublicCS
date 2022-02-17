using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitStop : MonoBehaviour
{
    [SerializeField]
    private TimeMane _timeManager;
    // Update is called once per frame
    public void Hitstop()
    {
            //　全体のタイムスケールを変更する
            _timeManager.SlowDown();
    }
}
