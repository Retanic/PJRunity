using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public float speed;

    public static float i = 1f;
    void Update()
    {
        Debug.Log(i);
        transform.Translate(Vector3.left * speed * Time.deltaTime * i);
        i = i + 0.00001f;
        if (i >= 20f)
        {
            i = 20f;
        }

        if (transform.position.x <= -30.68f)
        {
            Destroy(gameObject);
        }
    }
}
