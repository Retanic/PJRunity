using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatandDan : ReadConfig
{
    [SerializeField]
    private GameObject PlatformUP;
    [SerializeField]
    private GameObject PlatformDOWN;
    [SerializeField]
    private GameObject DangerUP;
    [SerializeField]
    private GameObject DangerDOWN;
    private float SpawnsWait;
    private float SpawnsWait2;
    private float SpawnsWait3;
    private float Wait;
    [SerializeField]
    private int type = 0;


    void Start()
    {
        StartCoroutine(PlatformUPSpawnRoutine());
        StartCoroutine(PlatformDOWNSpawnRoutine());
    }
    
    public float i = 0.3f;

    IEnumerator PlatformUPSpawnRoutine()
    {

        while (true)
        {
            yield return new WaitForSeconds(SpawnsWait);
            Instantiate(PlatformUP, new Vector3(39, 4.72f, 0), Quaternion.identity);
            Instantiate(DangerUP, new Vector3(Random.Range(28.84f, 50.73f), 3.04f, 0), Quaternion.identity);
        }
    }
    IEnumerator PlatformDOWNSpawnRoutine()
    {

        while (true)
        {
            yield return new WaitForSeconds(SpawnsWait2);
            Instantiate(PlatformDOWN, new Vector3(39, -4.79f, 0), Quaternion.identity);
            Instantiate(DangerDOWN, new Vector3(Random.Range(28.84f, 50.73f), -3.3f, 0), Quaternion.identity);
        }
    }
    public  void Platform()
    {
            transform.Translate(Vector2.left * speed * Time.deltaTime * i);
            i = i + 0.0008f;
            if (transform.position.x <= -30.68f)
            {
                Destroy(this.gameObject);
            }
     
      
    }

    
   public void Danger()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime * i);
        i = i + 0.0008f;
        if (transform.position.x <= -30.68f)
        {
            Destroy(this.gameObject);
        }
    }
    void Update()
    {
        SpawnsWait = Random.Range(1f, 7f);
        SpawnsWait2 = Random.Range(0.6f, 7f);
       
        Wait = Random.Range(1f, 2f);

    }
}
