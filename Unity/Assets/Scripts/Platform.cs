using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Platform : MonoBehaviour
{

	public static float speed = 0.3f;
	public bool collided = false;
	public float maxFallDistance = -10.0f;

	public void Reset()
	{
		speed = 0.3f;
	}

	void OnEnable()
	{
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		Reset();
	}

	private void OnCollisionExit2D(Collision2D collider)
	{

		if (collider.gameObject.tag == "Player" && collider.transform.position.y > transform.position.y)
		{
			collider.gameObject.SendMessage("IncrementPoints");
			speed += (float)0.05;

			StartCoroutine(ButtonDelay());
		}
		else
		{
			collided = true;
		}
	}

	void Update()
	{
		transform.Translate(Vector2.down * speed * Time.deltaTime);
		if (transform.position.y <= maxFallDistance)
		{
			Destroy(gameObject);
		}
	}

	IEnumerator ButtonDelay()
	{
		yield return new WaitForSeconds(0.5f);
		Destroy(gameObject);
	}
}
