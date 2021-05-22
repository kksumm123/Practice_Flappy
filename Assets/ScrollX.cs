using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollX : MonoBehaviour
{
    public float speed = -1f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * GameManager.instance.ScrollSpeedMult, 0, 0);
    }
}
