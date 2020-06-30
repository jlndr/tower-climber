using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
	public int points = 0;
	public float maxFallDistance = -10.0f;
	public Text scoreDisplay;
	// AudioSource source;
	public AudioClip clip;

	public GameObject jumpEffect;

	void IncrementPoints()
	{
		++points;
		scoreDisplay.text = "Score: " + points.ToString();
	}

	void Update()
	{
		if (!gameObject && Input.GetKeyDown(KeyCode.R))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
		else
		{

			if (Input.GetKeyDown("space"))
			{
				Instantiate(jumpEffect, transform.position, Quaternion.identity);
			}
			if (transform.position.y <= maxFallDistance)
			{
				AudioSource.PlayClipAtPoint(clip, transform.position);
				Destroy(gameObject);

				scoreDisplay.text = "Game Over.\nFinal score: " + points.ToString() + ".\nHit R to restart game.";
			}
		}

	}
}
