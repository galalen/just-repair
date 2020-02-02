using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private static float BLOCK_Y = -5.0F;

    public AudioSource audioSource;
    public GameObject block;
    public GameObject blockHolder;
    public GameObject waterBall;
    public float speed = 10.0f;
    public bool haveBlock;
    public int lifes = 3;

    private Rigidbody2D rb;
    private Vector2 movement;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D> ();
        haveBlock = true;
        //UIManager.instance.UpdateLifeText(lifes);
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.gameOver) 
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
        
            // Movement();
            // DropBlock();
            FireBall();
        }
    }

    void FixedUpdate()
    {
        if (!GameManager.instance.gameOver)
        {
            Movement();
        }
    }

    private void Movement() 
    {
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
    }

    private void DropBlock() {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            if (haveBlock)
            {
                Instantiate(block, new Vector3(transform.position.x, BLOCK_Y, 0), Quaternion.identity);
                haveBlock = false;
                blockHolder.SetActive(false);
            }
        }
    }

    private void FireBall()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(waterBall, transform.position + new Vector3(0.5f, 0, 0), Quaternion.identity);
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        // if (other.gameObject.tag == "Collection") {
        //     haveBlock = true;
        //     blockHolder.SetActive(true);
        // }

        if (other.CompareTag("Enemy")) {
            lifes -= 1;
            if (lifes == 0) {
                GameManager.instance.GameOver();
            } else {
                UIManager.instance.UpdateLifeText(lifes);
            }
        }

    }

}