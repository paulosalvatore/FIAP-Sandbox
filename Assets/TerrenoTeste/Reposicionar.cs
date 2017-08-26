using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposicionar : MonoBehaviour
{
	private Vector3 posicaoInicial;

	private void Start()
	{
		posicaoInicial = transform.position;
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Joystick1Button0) || Input.GetKeyDown(KeyCode.X))
		{
			transform.position = new Vector3(
				transform.position.x,
				transform.position.y + 10,
				transform.position.z
			);
		}
		else if (Input.GetKeyDown(KeyCode.Joystick1Button1) || Input.GetKeyDown(KeyCode.C))
		{
			transform.position = posicaoInicial;
		}
	}
}
