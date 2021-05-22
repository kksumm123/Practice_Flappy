using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relocation : MonoBehaviour
{
    [SerializeReference]
    float minX;
    float width;
    void Awake()
    {
        var spriterenderer = GetComponentInChildren<SpriteRenderer>();
        width = spriterenderer.sprite.bounds.size.x * transform.lossyScale.x;
        Debug.Log($" width = {spriterenderer.sprite.bounds.size.x} * {transform.lossyScale.x}");
        minX = -width;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < minX)
            transform.Translate(width * 2, 0, 0);
    }
}
