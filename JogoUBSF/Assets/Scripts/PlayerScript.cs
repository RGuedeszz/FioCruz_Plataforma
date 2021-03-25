using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public float speed;
    public bool isJumpping;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move() {
        // Movimento em si //
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;
        // Animação //
        if (Input.GetAxis("Horizontal") > 0f) { // horizontal > 0 ----> direita

        } else if (Input.GetAxis("Horizontal") < 0f) { // horizontal < 0 ----> esquerda

        } else { // Parado

        }
    }

    void Jump() {
        if (Input.GetButtonDown("Jump")) { // Se eu apertar o botao de Jump
        
        }
    }

    void OnCollisionEnter2D(Collision2D col) {

    }

    void OnCollisionExit2D(Collision2D col) {

    }
}
