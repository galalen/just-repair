using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public Rigidbody2D  body;
	public float speed=10;
	public float enemy_moving = -2;
	public bool is_moving = true;

	// Use this for initialization
	void Start () {
		InvokeRepeating("SetRandomPos",0.0f,0.2f);
		body = GetComponent<Rigidbody2D> ();
		//Random.Range();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void SetRandomPos() {
		if (is_moving) {
			Vector2 temp = new Vector3 (transform.position.x + (enemy_moving * Time.deltaTime), transform.position.y, transform.position.z);
		 
			
			transform.position = temp;
		} else {
			is_moving = !is_moving;
			enemy_moving *= -1;
		}
	}
	void OnTriggerEnter2D(Collider2D collider)
	{
		Debug.Log ("Touch the collider");		
		if (collider.gameObject.tag == "enemy") {



			is_moving = false;
			//Vector2 temp = new Vector2 (transform.position.x, transform.position.y + 1);

			//enemy.transform.position = temp;


			//Debug.Log (enemy.tag);
			//enemy.is_moving = false;

		}
	}
	void OnColliderEnter2D (Collider2D collider)
	{
		Debug.Log ("Touch the collider");		
		if (collider.gameObject.tag == "ground") {



			is_moving = false;
			//Vector2 temp = new Vector2 (transform.position.x, transform.position.y + 1);

			//enemy.transform.position = temp;


			//Debug.Log (enemy.tag);
			//enemy.is_moving = false;

		}
	}
	void OnCollisionEnter2D (Collision2D collider)
	{
		Debug.Log ("Touch the collider");		
		if (collider.gameObject.tag == "ground") {



			is_moving = false;
			//Vector2 temp = new Vector2 (transform.position.x, transform.position.y + 1);

			//enemy.transform.position = temp;


			//Debug.Log (enemy.tag);
			//enemy.is_moving = false;

		}
	}
}
