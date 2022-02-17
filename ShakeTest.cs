using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeTest : MonoBehaviour
{
    [SerializeField] private float duration;
    [SerializeField] private float magnitude;
    [SerializeField] CameraShake shake;

    public void Shaking()
    {
            shake.Shake(duration, magnitude);
    }
}
