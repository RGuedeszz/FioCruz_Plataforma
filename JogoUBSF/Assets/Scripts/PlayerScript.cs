using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    private Rigidbody2D rig;
    private Animator anim;
    public float speed;
    public bool isJumpping;
    public float jumpForce;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Move();
        Jump();
    }

    void Move() {
        // Movimento em si //
        float movement = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(movement * speed, rig.velocity.y);

        // Animação //
        if (movement > 0f) {
            anim.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        } else if (movement < 0f) {
            anim.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        } else {
            anim.SetBool("walk", false);
        }
    }

    void Jump() {
        if (Input.GetButtonDown("Jump") && !isJumpping) { // Se eu apertar o botao de Jump
            rig.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.layer == LayerMask.NameToLayer("Ground")) {
            isJumpping = false;
            anim.SetBool("jump", false);
        }
    }

    void OnCollisionExit2D(Collision2D col) {
        if (col.gameObject.layer == LayerMask.NameToLayer("Ground")) {
            isJumpping = true;
            anim.SetBool("jump", true);
        }
    }
}
