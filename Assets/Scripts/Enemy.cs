using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
	public float speed = 0.1f;
	public int health = 1;

	public GameObject dud;

	void Update() 
	{
		transform.Translate(Vector3.left * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.tag == "Wall") {
			Destroy(this.gameObject);
		}

	}

	public void TakeDamage()
	{
		health -= health;
		if (health == 0)
		{
			UIManager.instance.UpdateScoreText();
			Instantiate(dud, transform.position, Quaternion.identity);
			Destroy(this.gameObject);
		}
	}
	
	
}
