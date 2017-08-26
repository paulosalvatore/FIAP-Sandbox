using UnityEngine;
using System.Collections;

public class RecomecarJogo : MonoBehaviour {

	public static int pontos;

	void Start(){
		pontos = 0;
	}
		
	void Update () {
	
		if (pontos >= 9) {
			Application.LoadLevel ("vr-game");
		}

	}
}
