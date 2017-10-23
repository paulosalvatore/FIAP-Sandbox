using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscilarTester : MonoBehaviour
{
	private new Light light;

	private void Start()
	{
		light = GetComponent<Light>();

		InvokeRepeating("Oscilar", 0f, 0.1f);
	}

	private void Oscilar()
	{
		light.intensity = Random.Range(2.5f, 3.5f);
	}
}
