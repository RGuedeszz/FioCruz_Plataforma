using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicineScript : MonoBehaviour
{

    public int scoreMedicine;
    private BoxCollider2D colisorMedicine;
    private SpriteRenderer spriteMedicine;

    void Start()
    {
        colisorMedicine = GetComponent<BoxCollider2D>();
        spriteMedicine = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.gameObject.tag == "Player") {
            colisorMedicine.enabled = false;
            spriteMedicine.enabled = false;

            Destroy(gameObject, 1f);
        }
    }
}