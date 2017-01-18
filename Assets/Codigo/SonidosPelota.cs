using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosPelota : MonoBehaviour {

	public AudioSource rebotes;
	public AudioSource puntos;


	void OnCollisionEnter (Collision otro){
	

		//Comparamos el Tag del objeto para decidir si el audio que se escucha es el de puntos o el de rebotes.
		if (otro.gameObject.CompareTag ("Bloques")) {
			puntos.Play ();
		
		} else {
		
			rebotes.Play ();
		
		}
	}
}
