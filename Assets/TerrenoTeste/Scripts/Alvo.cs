using UnityEngine;
using System.Collections;

public class Alvo : MonoBehaviour {

	void OnCollisionEnter(Collision c){
		RecomecarJogo.pontos++;
		Destroy (gameObject);
	}
		
}
