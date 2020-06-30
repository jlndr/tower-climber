using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
	public GameObject platform;

	public float maxHeight = 13.0f;

	private float timeBtwSpawn;
	public float startTimeBtwSpawn = 2;

	private void Update()
	{
		float multiplier = Platform.speed < 4.0f ? Platform.speed : 4.0f;

		if (timeBtwSpawn <= 0)
		{
			Instantiate(platform, transform.position, Quaternion.identity);
			timeBtwSpawn = startTimeBtwSpawn + Random.Range(-0.5f, 0.5f);
		}
		else
		{
			timeBtwSpawn -= Time.deltaTime;
		}

		if (transform.position.y <= maxHeight)
		{
			Vector3 pos = transform.position;
			pos.y += 0.008f;
			transform.position = pos;
		}
	}
}
