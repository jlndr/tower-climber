using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
	public GameObject platform;

	void Start()
	{
		Instantiate(platform, transform.position, Quaternion.identity);

	}
}
