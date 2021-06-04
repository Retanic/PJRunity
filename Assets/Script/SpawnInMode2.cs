using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInMode2 : MonoBehaviour
{
    [SerializeField]
    private GameObject DangerUp1;
    [SerializeField]
    private GameObject DangerUp2;
    [SerializeField]
    private GameObject DangerDown1;
    [SerializeField]
    private GameObject DangerDown2;
    private float SpawnsWait;
    private float SpawnsWait2;
    private float SpawnsWait3;
    private float Wait;
    [SerializeField]
    private int type2 = 0;
    private int type = 0;
    void Start()
    {
        
        StartCoroutine(DOWNSpawnRoutine());
        StartCoroutine(UPSpawnRoutine());
        StartCoroutine(typerandom());
        StartCoroutine(typerandom2());
    }
    IEnumerator typerandom()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            type = Random.Range(1, 3);

        }

    }
    IEnumerator typerandom2()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            type2 = Random.Range(1, 3);

        }

    }
    IEnumerator UPSpawnRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            if (type == 1)
            {
                Instantiate(DangerUp1, new Vector3(20, 3.1f, 0), Quaternion.identity);
            }
            if (type == 2)
            {
                Instantiate(DangerUp2, new Vector3(20, 1.48f, 0), Quaternion.identity);
            }
        }
    }


    IEnumerator DOWNSpawnRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            if (type2 == 1)
            {
                Instantiate(DangerDown1, new Vector3(20, -1.64f, 0), Quaternion.identity);
            }
            if (type2 == 2)
            {
                Instantiate(DangerDown2, new Vector3(20, -3.26f, 0), Quaternion.identity);
            }
        }
    }

   

    void Update()
    {
        SpawnsWait = Random.Range(1f, 7f);
        SpawnsWait2 = Random.Range(0.6f, 7f);


    }
}
