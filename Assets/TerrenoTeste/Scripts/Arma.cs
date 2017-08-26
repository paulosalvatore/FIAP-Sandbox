using UnityEngine;
using System.Collections;

public class Arma : MonoBehaviour {

	public bool auto;
	public GameObject projetil;

	// Use this for initialization
	void Start () {
		if (auto) {
			StartCoroutine (AutoDisparo ());
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (!auto) {
			// Clique com botao esquerdo do mouse sendo que equivale a um toque na tela
			if (Input.GetMouseButtonDown (0)) {
				Instantiate (projetil, transform.position, transform.rotation);
			}
		}

	}
		
	// Tiro automatico
	IEnumerator AutoDisparo(){
		yield return new WaitForSeconds (0.8f);
		Instantiate (projetil, transform.position, transform.rotation);
		StartCoroutine (AutoDisparo ());
	}



}
