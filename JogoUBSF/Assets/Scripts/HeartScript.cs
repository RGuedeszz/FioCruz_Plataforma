using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour
{

    public int scoreHeart;
    private CircleCollider2D colisorHeart;
    private SpriteRenderer spriteHeart;

    void Start()
    {
        colisorHeart = GetComponent<CircleCollider2D>();
        spriteHeart = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.gameObject.tag == "Player") {
            colisorHeart.enabled = false;
            spriteHeart.enabled = false;

            Destroy(gameObject, 1f);
        }
    }
}