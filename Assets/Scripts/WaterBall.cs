using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBall : MonoBehaviour
{
    public float speed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Ground") {
			Destroy(this.gameObject);
		}

        if (other.gameObject.tag == "Enemy") {
            other.gameObject.GetComponent<Enemy>().TakeDamage();
            Destroy(this.gameObject);
        }
	}
}
