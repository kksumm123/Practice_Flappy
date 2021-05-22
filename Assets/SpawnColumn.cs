using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnColumn : MonoBehaviour
{
    public GameObject column;
    public float spawnPosX = 8;
    public float spawnRandY = 2;
    public float spawnDelay = 4;
    public float spawnRandDelay = 1;
    Vector3 pos;
    IEnumerator Start()
    {
        while (true)
        {
            pos.x = spawnPosX;
            pos.y = column.transform.position.y + Random.Range(-spawnRandY, spawnRandY);
            pos.z = 0;
            Instantiate(column, pos, column.transform.rotation);
            yield return new WaitForSeconds(spawnDelay + Random.Range(-spawnRandDelay, spawnRandDelay));
        }
    }


}
