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
            //�@�S�̂̃^�C���X�P�[����ύX����
            _timeManager.SlowDown();
    }
}
