using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class ReadConfig : MonoBehaviour
{
    protected string ConfigFlieName;
    [SerializeField]
    protected int PlayerNo = 0;
    protected Rigidbody r2b;
    [SerializeField]
    protected float speed = 1.0f;
    public float i = 0.3f;
    private void Awake()
    {
        ConfigFlieName = "Book2.csv";    
    }
   
    void Start()
    {
        r2b = GetComponent<Rigidbody>();
        SetupPlayer();
    }

    void SetupPlayer()
    {
        StreamReader input = null;
        try
        {
            input = File.OpenText(Path.Combine(Application.streamingAssetsPath, ConfigFlieName));
            string header = input.ReadLine();
            string values = input.ReadLine();
            while (values != null)
            {
                string[] valueSplit = values.Split(',');
                 if (PlayerNo == int.Parse(valueSplit[0]))
                {
                    transform.name = valueSplit[1];
                    speed = float.Parse(valueSplit[2]);
                }
                values = input.ReadLine();
            }
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
        finally
        {
            if (input != null)
            {
                input.Close();
            }
        }
    }
   
    public void show()
    {
        if (PlayerNo == 3)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime * i);
            i = i + 0.0008f;
            if (transform.position.x <= -30.68f)
            {
                Destroy(this.gameObject);
            }
        }
    }

}
