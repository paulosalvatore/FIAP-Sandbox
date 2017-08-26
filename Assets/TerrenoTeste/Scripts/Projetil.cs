using UnityEngine;
using System.Collections;

public class Projetil : MonoBehaviour {

	void Start(){
		StartCoroutine (Destruir ());
	}

	void Update () {
		transform.Translate (Vector3.forward * 30.0f * Time.deltaTime);
	}


	IEnumerator Destruir(){
		yield return new WaitForSeconds (1.0f);
		Destroy (gameObject);
	}

}
