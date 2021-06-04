using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{

    private Rigidbody2D rb;

    private bool top;
    void Start()
    {
        rb = GetComponent < Rigidbody2D >(); 
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            Audio.Playsound("gra");
            rb.gravityScale *= -1;
            Rotation();
        }
        if (Input.touchCount > 0)
        {
            if(Input.touches[0].phase == TouchPhase.Began)
            {
                Audio.Playsound("gra");
                rb.gravityScale *= -1;
                Rotation();
            }
        }
    }
    void Rotation()
    {
        if(top == false)
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
