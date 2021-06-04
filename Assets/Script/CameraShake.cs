using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : Player
{
    public static CameraShake instance;
    private float shakeTimeRemaining, shakePower;
    private void LateUpdate()
    {
        if (shakeTimeRemaining > 0)
        {
            shakeTimeRemaining -= Time.deltaTime;

            float xAmount = Random.Range(-1f, 1f) * shakePower;
            float yAmount = Random.Range(-1f, 1f) * shakePower;
            transform.position += new Vector3(xAmount, yAmount, 0f);
        }
    }

    public void StartShake(float length, float power)
    {
        shakeTimeRemaining = length;
        shakePower = power;
    }

    public void Shake()
    {
         StartShake(.5f, 1f);
    }
}
