using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    [SerializeField]
    private GameObject PlatformUP;
    [SerializeField]
    private GameObject PlatformDOWN;
    [SerializeField]
    private GameObject DangerUP;
    [SerializeField]
    private GameObject DangerDOWN;
    [SerializeField]
    private GameObject PowerUP;
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
        StartCoroutine(PowerUPSpawnRoutine());
        StartCoroutine(typerandom());
    }
    IEnumerator typerandom()
    {
        while (true)
        {
            yield return new WaitForSeconds(Wait);
            type = Random.Range(1, 3);
        }

    }
    IEnumerator PowerUPSpawnRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(SpawnsWait3);
            if (type == 1)
            {
                Instantiate(PowerUP, new Vector3(35, -1.95f, 0), Quaternion.identity);
            }
            if (type == 2)
            {
                Instantiate(PowerUP, new Vector3(35, 1.51f, 0), Quaternion.identity);
            }

        }
    }
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

    void Update()
    {
        SpawnsWait = Random.Range(1f, 7f);
        SpawnsWait2 = Random.Range(0.6f, 7f);
        SpawnsWait3 = Random.Range(10f, 15f);
        Wait = Random.Range(1f, 2f);

    }
}
