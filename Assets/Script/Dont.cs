using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dont : MonoBehaviour
{
    private static Dont instance = null;
    private AudioSource audio;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            return;
        }
        if (instance == this) return;
        Destroy(gameObject);
    }
}
