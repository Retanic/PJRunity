using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity2 : MonoBehaviour
{

   

    private bool top;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Audio.Playsound("gra");
            rb.gravityScale *= -1;
            Rotation();
        }
    }
    void Rotation()
    {
        if (top == false)
        {
            transform.eulerAngles = new Vector3(0, 180f, 180f);
        }
        else
        {
            transform.eulerAngles = Vector3.zero;
        }
        top = !top;
    }
}
