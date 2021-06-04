using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUP : ReadConfig
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        show();
        if (transform.position.x <= -30.68f)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("Player"))
        {
            Speed.i -= 0.15f;
            if(Speed.i <= 0.75)
                {
                Speed.i = 0.75f;
                }
            Destroy(this.gameObject);
        }
    }
}
