using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private static float BLOCK_Y = -5.0F;

    public GameObject block;
    public GameObject blockHolder;
    public int speed = 10;
    public bool haveBlock;

    private Rigidbody2D rigidbody2d;
    private GameManager gameManager;
    

    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D> ();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        haveBlock = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameManager.gameOver) 
        {
            Movement();
            DropBlock();
        }
    }

    private void Movement() 
    {
        if (Input.GetKeyDown(KeyCode.A))
        {

             transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        } 

        if (Input.GetKeyDown(KeyCode.D)) 
        {
            transform.Translate(Vector3.left * -speed * Time.deltaTime, Space.World);
        }
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

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Collection") {
            haveBlock = true;
            blockHolder.SetActive(true);
        }
    }

}