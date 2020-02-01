using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public Enemy enemy;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		Debug.Log ("Touch the collider");		
		if (collider.gameObject.tag == "enemy") {
			



			Vector2 temp = new Vector2 (transform.position.x, transform.position.y + 1);

			enemy = collider.gameObject.GetComponent<Enemy>();

			enemy.is_moving = false;
			

			//Debug.Log (enemy.tag);
			//enemy.is_moving = false;
				
		}
	}
	void OnColliderEnter2D (Collider2D collider)
	{
		Debug.Log ("Touch the collider");		
		if (collider.gameObject.tag == "enemy") {

			Vector2 temp = new Vector2 (transform.position.x, transform.position.y + 1);

			enemy.transform.position = temp;

			//Debug.Log (enemy.tag);
			//enemy.is_moving = false;

		}
	}
	void OnCollisionEnter2D (Collision2D collider)
	{
		Debug.Log ("Touch the collider");		
		if (collider.gameObject.tag == "enemy") {

			//is_moving = false;
			//Vector2 temp = new Vector2 (transform.position.x, transform.position.y + 1);

			//enemy.transform.position = temp;

			//Debug.Log (enemy.tag);
			//enemy.is_moving = false;

		}
	}
}
