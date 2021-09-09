using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private Collider2D collider2D;
    [SerializeField]
    private SpriteRenderer spriteRenderer;
    public void Hit()
    {
        collider2D.enabled = false;
        spriteRenderer.enabled = false;
    }
    public void Restore()
    {
        collider2D.enabled = true;
        spriteRenderer.enabled = true;
    }
}
