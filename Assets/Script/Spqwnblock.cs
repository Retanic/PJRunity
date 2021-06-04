using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spqwnblock : MonoBehaviour
{
    [SerializeField]
    private GameObject Block;
    private float SpawnsWait;
    void Start()
    {
        StartCoroutine(BlockSpawnRoutine());
    }

    IEnumerator BlockSpawnRoutine()
    {

        while (true)
        {
            yield return new WaitForSeconds(SpawnsWait);
            Instantiate(Block, new Vector3(39, 0f, 0), Quaternion.identity);
        }
    }
    void Update()
    {
        SpawnsWait = Random.Range(1f, 7f);
    }
}
