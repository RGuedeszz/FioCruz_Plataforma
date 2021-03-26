using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StethoscopeScript : MonoBehaviour
{

    public int scoreStethoscope;
    private CircleCollider2D colisorStethoscope;
    private SpriteRenderer spriteStethoscope;

    void Start()
    {
        colisorStethoscope = GetComponent<CircleCollider2D>();
        spriteStethoscope = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.gameObject.tag == "Player") {
            colisorStethoscope.enabled = false;
            spriteStethoscope.enabled = false;

            Destroy(gameObject, 1f);
        }
    }
}