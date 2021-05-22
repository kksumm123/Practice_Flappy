using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relocation : MonoBehaviour
{
    [SerializeReference]
    Vector2 ownPos;
    float width;
    void Awake()
    {
        var spriterenderer = GetComponentInChildren<SpriteRenderer>();
        ownPos = transform.position;
        width = spriterenderer.sprite.bounds.size.x * transform.lossyScale.x;
        Debug.Log($" width = {spriterenderer.sprite.bounds.size.x} * {transform.lossyScale.x}");
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(ownPos.x - transform.position.x) >= width)
            transform.Translate(width * 2, 0, 0);
    }
}
