using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlatform : MonoBehaviour
{

	private void OnCollisionExit2D(Collision2D collider)
	{
		if (collider.gameObject.tag == "Player")
		{
			Destroy(gameObject);
		}
	}
	void Update()
	{

	}
}
