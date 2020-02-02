using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dud : MonoBehaviour
{
    public float speed = 8.0f;

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
	}

}
