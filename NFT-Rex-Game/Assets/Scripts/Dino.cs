using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dino : MonoBehaviour
{
    Rigidbody2D rb;
    bool jump;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jump = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && jump == false){
            rb.velocity = new Vector3(0, 17, 0);
            jump = true;
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jump = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "obstacle" || collision.tag == "cactus3")
        {
            gameManager.GameOver();
        }
    }
}
