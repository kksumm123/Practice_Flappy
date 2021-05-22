using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GODestroy : MonoBehaviour
{
    public int minX = 15;
    float spawnPos;
    private void Awake()
    {
        spawnPos = transform.position.x;
    }
    void Update()
    {
        if (Mathf.Abs(spawnPos - transform.position.x) > minX)
            Destroy(gameObject);
    }
}
