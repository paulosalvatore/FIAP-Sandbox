using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionarTeste : MonoBehaviour
{
	float a = 0;
	float b = 30;

	private void Update()
	{
		float y = Mathf.LerpAngle(a, b, 0.00001f);

		if ((y >= Mathf.Max(a, b) - 1) || (y <= Mathf.Min(a, b) + 1))
		{
			float c = b;
			b = a;
			a = c;
		}

		transform.rotation = new Quaternion(
			transform.rotation.x,
			y,
			transform.rotation.z,
			transform.rotation.w
		);
	}
}
